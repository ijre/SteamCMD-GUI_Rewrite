using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace SteamCMD_GUI
{
  public partial class MainForm : Form
  {
    // ReSharper disable once FieldCanBeMadeReadOnly.Local
    private string[][] GameInfo = GetGames();
    private const string ReleaseUrl = "https://github.com/ijre/SteamCMD-GUI_Rewrite/releases/latest";

    public MainForm()
    {
      InitializeComponent();
      Icon = Properties.Resources.Icon;

      if (GameInfo == null)
      {
        if (MessageBox.Show("GAMES.cfg missing; download from repository?", "Fatal Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
        {
          Process.Start("https://github.com/ijre/SteamCMD-GUI_Rewrite");
        }

        Close();
        return;
      }

      for (int i = 0; i < GameInfo.GetLength(0); i++)
      {
        if (GameInfo[i][0] == null)
        {
          break;
        }

        GameListUpdateTab.Items.Add(GameInfo[i][2]);
        GameListRunTab.Items.Add(GameInfo[i][2]);
      }

      GameListUpdateTab.SelectedIndex = 0;
      GameListRunTab.SelectedIndex = 0;
      NetworkType.SelectedIndex = 0;
    }

    #region Events
    #region Settings
    private void SaveSettings_Click(object sender, EventArgs e)
    {
      using var diag = new SaveFileDialog
      {
        Title = "Choose where to save your config",
        DefaultExt = "txt",
        Filter = "(*.txt) | *.txt",
        RestoreDirectory = true
      };
      if (diag.ShowDialog() != DialogResult.OK)
        return;

      string buff = "";

      var interactable = GetAllInteractables();

      for (int i = 0; i < interactable.Count; i++)
      {
        string input = "";

        bool user = interactable[i].Name == Username.Name && !AnonymousLogin.Checked;
        bool pass = interactable[i].Name == PasswordLogin.Name && !AnonymousLogin.Checked;
        bool rcon = interactable[i].Name == Rcon.Name;

        if (user && !SaveLoginDetails.Checked
            ||
            pass && SaveLoginDetails.CheckState != CheckState.Checked)
        {
          continue;
        }

        if (rcon && !SaveRCON.Checked)
        {
          continue;
        }

        switch (interactable[i])
        {
          case NumericUpDown _:
          case TextBox _:
            input = interactable[i].Text;
            break;
          case CheckBox child:
            input = ((int)child.CheckState).ToString();
            break;
          case ComboBox child:
            if (child.Name != MapList.Name)
            {
              input = child.SelectedIndex.ToString();
            }
            else if (child.SelectedIndex != -1)
            {
              input = child.SelectedItem.ToString();
            }

            break;
          default:
            continue;
        }

        buff += $"{interactable[i].Name} {input}\n";
      }

      File.WriteAllText(diag.FileName, buff);
    }

    private void LoadSettings_Click(object sender, EventArgs e)
    {
      using var diag = new OpenFileDialog
      {
        Title = "Choose which config to load",
        DefaultExt = "txt",
        Filter = "(*.txt) | *.txt",
        RestoreDirectory = true
      };
      if (diag.ShowDialog() != DialogResult.OK)
        return;

      var lines = File.ReadAllLines(diag.FileName);
      var total = GetAllInteractables();

      string mapToSelect = "";

      for (int index = 0; index < lines.Length; index++)
      {
        var controlName = lines[index].Substring(0, lines[index].IndexOf(" "));
        var controlValue = lines[index].Substring(lines[index].IndexOf(" ")).TrimStart();

        for (int control = 0; control < total.Count; control++)
        {
          if (controlName != total[control].Name)
          {
            continue;
          }

          switch (total[control])
          {
            case NumericUpDown _:
            case TextBox _:
              total[control].Text = controlValue;
              break;

            case CheckBox child:
              child.CheckState = (CheckState)int.Parse(controlValue);
              break;

            case ComboBox child:
              if (child.Name != MapList.Name)
              {
                child.SelectedIndex = int.Parse(controlValue);
              }
              else
              {
                mapToSelect = controlValue;
              }

              break;

            default:
              continue;
          }
        }
      }

      RunServer.Enabled = true;
      UpdateServer.Enabled = true;
      MapList.Enabled = true;
      MapList_EnterOrLeave(sender, EventArgs.Empty); // called to refresh list

      MapList.SelectedItem = mapToSelect;
    }
    #endregion // Settings

    private void UpdateServerButton_Click(object sender, EventArgs e)
    {
      string arguments = $"SteamCmd +force_install_dir \"{ServerPath.Text}\" +login ";
      if (AnonymousLogin.Checked)
      {
        arguments += "anonymous ";
      }
      else if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(PasswordLogin.Text))
      {
        arguments += $"{Username.Text} {PasswordLogin.Text} ";
      }
      else
      {
        MessageBox.Show("Anonymous login unchecked, but the Username or Password fields are blank; canceling Update/Install",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      arguments += $"{ AdditionalSteamCMDCommands.Text } ";

      arguments += $"+app_update {GameInfo[GameListUpdateTab.SelectedIndex][0]}";

      if (ValidateInstall.Checked)
        arguments += " validate";

      StartCLI(SteamCMDPath.Text, arguments.TrimEnd());
    }

    private void RunServerButton_Click(object sender, EventArgs e)
    {
      string buttonParams = "";

      if (SourceTV.Checked)
      {
        buttonParams += "+tv_enable 1 ";
      }
      else
      {
        buttonParams += "-nohltv ";
      }

      if (Insecure.Checked)
      {
        buttonParams += "-insecure ";
      }
      if (NoBots.Checked)
      {
        buttonParams += "-nobots ";
      }
      if (DevMessages.Checked)
      {
        buttonParams += "-dev ";
      }

      string arguments =
          $"-console -game {GameInfo[GameListRunTab.SelectedIndex][1]} -port {UDPPort.Text} +hostname \"{Hostname.Text}\" " +
          $"+map {MapList.SelectedItem} +maxplayers {MaxPlayers.Text} +sv_lan {NetworkType.SelectedIndex} " +
          $"+rcon_password {Rcon.Text} +sv_password {PasswordServer.Text} " +
          $"{buttonParams} {AdditionalCommands.Text}";


      StartCLI(SrcdsPath.Text, arguments);
    }

    private int lastCount;
    private void MapList_EnterOrLeave(object sender, EventArgs e)
    {
      string root = GameInfo[GameListRunTab.SelectedIndex][1];

      List<string> maps;

      try
      {
        maps = Directory.GetFiles($"{SrcdsPath.Text.Substring(0, SrcdsPath.Text.LastIndexOf("\\"))}\\{root}\\maps").ToList();
      }
      catch (DirectoryNotFoundException)
      {
        if (lastCount != -2)
        {
          MessageBox.Show("Error! Invalid directory or game for said directory. Please try again.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
          lastCount = -2;
        }

        // HACK: Because this event happens on leaving the control as well as entering, I don't want to yell at the user a second time
        // So I re-use the lastCount var as it'll be an invalid number anyways

        return;
      }

      if (maps.Count != lastCount)
      {
        lastCount = maps.Count;
        MapList.Items.Clear();
      }
      else
        return;

      for (int i = 0; i < maps.Count; i++)
      {
        if (!maps[i].EndsWith(".bsp"))
        {
          maps.RemoveAt(i);
          i--;
          continue;
        }

        maps[i] = maps[i].Substring(maps[i].LastIndexOf("\\") + 1); // remove slashes from absolute dir
        maps[i] = maps[i].Remove(maps[i].LastIndexOf("."), 4); // remove ext because it breaks srcds
      }

      MapList.Items.AddRange(maps.ToArray());
    }
    #endregion // Events

    #region Helpers
    private List<Control> GetAllInteractables()
    {
      List<Control> buff = new List<Control>();

      for (int tab = 0; tab < MainTabs.TabCount; tab++)
      {
        var tabObj = MainTabs.TabPages[tab];

        for (int groups = 0; groups < tabObj.Controls.Count; groups++)
        {
          if (tabObj.Controls[groups].GetType() != typeof(GroupBox))
            continue;

          var groupObj = tabObj.Controls[groups];

          for (int children = 0; children < groupObj.Controls.Count; children++)
          {
            buff.Add(groupObj.Controls[children]);
          }
        }
      }

      buff.Add(AdditionalCommands);
      buff.Add(AdditionalSteamCMDCommands);

      return buff;
    }

    private static void StartCLI(string path, string args)
    {
      Process process = new Process
      {
        StartInfo =
                {
                    FileName = path,
                    Arguments = args,
                    UseShellExecute = false
                }
      };

      process.Start();
    }

    private static string[][] GetGames()
    {
      if (!File.Exists("GAMES.cfg"))
      {
        return null;
      }

      string[] gamesRaw = File.ReadAllLines("GAMES.cfg");
      int size = gamesRaw.Length;

      string[][] games = new string[size][];
      for (int i = 0; i < size; i++)
      {
        games[i] = new string[3];
      }

      int linesToSkip = 0;

      for (int i = 0; i < size; i++)
      {
        string line = gamesRaw[i];
        if (line.Trim().Equals("") || line.Trim().StartsWith("//"))
        {
          linesToSkip++;
          continue;
        }

        int trueIndex = i - linesToSkip;

        string[] split = line.Split(' ');
        int splitSize = split.Length;

        for (int i2 = 0; i2 < splitSize; i2++)
        {
          if (split[i2].Equals(""))
          {
            continue;
          }

          if (string.IsNullOrEmpty(games[trueIndex][0]))
          {
            games[trueIndex][0] = split[i2];
          }
          else if (string.IsNullOrEmpty(games[trueIndex][1]))
          {
            games[trueIndex][1] = split[i2];
          }
          else
          {
            games[trueIndex][2] += $"{ split[i2] }{ (i2 != splitSize - 1 ? " " : "") }";
          }
        }
      }

      return games;
    }

    private static string GetFolder(string title)
    {
      using var diag = new CommonOpenFileDialog
      {
        Title = title,
        IsFolderPicker = true,
      };

      return diag.ShowDialog() == CommonFileDialogResult.Ok ? diag.FileName : "";
    }

    private static string GetFile(string title, string fileName)
    {
      using var diag = new OpenFileDialog
      {
        Title = title,
        Filter = $"|{fileName}"
      };

      return diag.ShowDialog() == DialogResult.OK ? diag.FileName : "";
    }
    #endregion // Helpers

    // small as in a few lines of code
    #region SmallEvents
    private void SteamCMDPathBrowse_Click(object sender, EventArgs e)
    {
      string file = GetFile("Select your steamcmd.exe file", "steamcmd.exe");

      if (string.IsNullOrWhiteSpace(file))
        return;

      SteamCMDPath.Text = file;
      UpdateServer.Enabled = !string.IsNullOrWhiteSpace(ServerPath.Text);
    }

    private void ServerPathBrowse_Click(object sender, EventArgs e)
    {
      string folder = GetFolder("Select the root of your server");

      if (string.IsNullOrWhiteSpace(folder))
        return;

      ServerPath.Text = folder;
      UpdateServer.Enabled = !string.IsNullOrWhiteSpace(SteamCMDPath.Text);
    }

    private void SrcdsPathBrowse_Click(object sender, EventArgs e)
    {
      string file = GetFile("Select the srcds.exe file", "srcds.exe");

      if (string.IsNullOrWhiteSpace(file))
        return;

      SrcdsPath.Text = file;
      MapList.Enabled = true;
    }

    private void MapList_SelectedIndexChanged(object sender, EventArgs e)
    {
      RunServer.Enabled = MapList.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(MapList.SelectedItem.ToString());
    }

    private void HideRCON_CheckedChanged(object sender, EventArgs e)
    {
      Rcon.UseSystemPasswordChar = HideRCON.Checked;
    }

    private TextBox GetMenuForResponsibleLaunchParam(object objSender)
    {
      switch (((Control)objSender).Name)
      {
        case "AddLaunchParams":
          return AdditionalCommands;
        case "AddSteamCMDLaunchParams":
          return AdditionalSteamCMDCommands;
        default:
          throw new Exception("\"GetMenuForResponsibleLaunchParam func\" called with objSender other than the \"add launch param\" controls?");
      }
    }

    private void AddLaunchParams_Click(object sender, EventArgs e)
    {
      TextBox cmds = GetMenuForResponsibleLaunchParam(sender);

      cmds.Visible = true;
      cmds.BringToFront();
      cmds.Focus();
    }

    private void AdditionalCommands_Leave(object sender, EventArgs e)
    {
      TextBox cmds = (TextBox)sender;

      cmds.Visible = false;
      cmds.SendToBack();
      cmds.Text = cmds.Text.Replace("\r\n", " ");
    }

    private void AdditionalCommands_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        e.SuppressKeyPress = true;
        AdditionalCommands_Leave(sender, EventArgs.Empty);
      }
    }

    private void AnonymousLogin_CheckedChanged(object sender, EventArgs e)
    {
      SaveLoginDetails.Visible = Username.Enabled = PasswordLogin.Enabled = !AnonymousLogin.Checked;
      // what if there's a mantrain
    }

    private void CheckForUpdates_Click(object sender, EventArgs e)
    {
      WebClient client = new WebClient
      {
        Proxy = WebRequest.DefaultWebProxy
      };
      client.Proxy.Credentials = CredentialCache.DefaultCredentials;

      string rawVersionResponse = client.DownloadString(ReleaseUrl);

      int versionNumRawStart = rawVersionResponse.IndexOf("Release v");
      int versionNumRawEnd = rawVersionResponse.IndexOf("\n", versionNumRawStart) - versionNumRawStart;
      int versionNumRawShortened = rawVersionResponse.Substring(versionNumRawStart, versionNumRawEnd).LastIndexOf(".") + 2;

      string versionNum = rawVersionResponse.Substring(versionNumRawStart, versionNumRawShortened).Remove(0, 9);
      // removing the now unrequired "Release v"

      if (string.Equals(ProductVersion, versionNum)
          ||
          int.Parse(ProductVersion.Replace(".", "")) > int.Parse(versionNum.Replace(".", "")))
      {
        return;
      }

      if (MessageBox.Show("New version available! Would you like to update now?", "New Version Available", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        Process.Start(ReleaseUrl);
      }
    }

    private void DownloadSteamCMD_Click(object sender, EventArgs e)
    {
      Process.Start("http://media.steampowered.com/installer/steamcmd.zip");
    }

    private void SrcdsLaunchOptions_Click(object sender, EventArgs e)
    {
      Process.Start("https://developer.valvesoftware.com/wiki/Command_Line_Options#Source_Dedicated_Server");
    }
    #endregion // SmallEvents
  }
}

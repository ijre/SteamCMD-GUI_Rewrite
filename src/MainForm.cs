using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace SteamCMD_GUI_Rewrite
{
    public partial class MainForm : Form
    {
        private readonly static string SettingsDir = $"{Application.StartupPath}\\settings";
        private readonly string CustomGamesList = $"{SettingsDir}\\GameListCustom.txt";
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private string[][] GameInfo = GetDefaultGames();

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < GameInfo.GetLength(0); i++)
            {
                GameListUpdateTab.Items.Add(GameInfo[i][1]);
                GameListRunTab.Items.Add(GameInfo[i][1]);
            }

            if (!Directory.Exists(SettingsDir))
            {
                Directory.CreateDirectory(SettingsDir);
            }

            if (!File.Exists(CustomGamesList))
            {
                // TODO: write tutorial for adding custom games
            }
            else if (!string.IsNullOrWhiteSpace(File.ReadAllText(CustomGamesList)))
            {
                // TODO: handle loading custom games
            }

            GameListUpdateTab.SelectedIndex = 0;
            GameListRunTab.SelectedIndex = 0;
            NetworkType.SelectedIndex = 0;
        }

        #region Events
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            using var diag = new SaveFileDialog
            {
                DefaultExt = "txt",
                Filter = "text files (*.txt) | *.txt",
                RestoreDirectory = true,
                InitialDirectory = SettingsDir
            };
            if (diag.ShowDialog() != DialogResult.OK)
                return;

            string buff = "";

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
                        string input;

                        var childObj = groupObj.Controls[children];

                        switch (childObj)
                        {
                            case NumericUpDown _:
                            case TextBox _:
                                input = childObj.Text;
                                break;
                            case CheckBox child:
                                input = ((int)child.CheckState).ToString();
                                break;
                            case ComboBox child:
                                input = child.SelectedIndex.ToString();
                                break;
                            default:
                                continue;
                        }

                        buff += $"{groupObj.Controls[children].Name} {input}\n";
                    }
                }
            }

            File.WriteAllText(diag.FileName, buff);
        }

        private void LoadSettings_Click(object sender, EventArgs e)
        {

        }

        private void UpdateServerButton_Click(object sender, EventArgs e)
        {
            string arguments = "SteamCmd +login ";
            if (AnonymousLogin.Checked)
            {
                arguments += "anonymous ";
            }
            else if (!string.IsNullOrWhiteSpace(Username.Text) && !string.IsNullOrWhiteSpace(Password.Text))
            {
                arguments += $"{Username.Text} {Password.Text} ";
            }
            else
            {
                MessageBox.Show("Anonymous login unchecked, but the Username or Password fields are blank; canceling Update/Install",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arguments += $"+force_install_dir \"{ServerPath.Text}\" +app_update {GameInfo[GameListUpdateTab.SelectedIndex][0]}";

            if (ValidateInstall.Checked)
                arguments += " validate";


            StartCLI(SteamCMDPath.Text, arguments);
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
                $"-console -game {GameInfo[GameListRunTab.SelectedIndex][2]} -port {UDPPort.Text} +hostname \"{Hostname.Text}\" " +
                $"+map {MapList.SelectedItem} +maxplayers {MaxPlayers.Text} +sv_lan {NetworkType.SelectedIndex} " +
                $"+rcon_password {Rcon.Text} {buttonParams} {AdditionalCommands.Text}";


            StartCLI(SrcdsPath.Text, arguments);
        }

        private int lastCount;
        private void MapList_EnterOrLeave(object sender, EventArgs e)
        {
            string root = GameInfo[GameListRunTab.SelectedIndex][2];

            var maps = Directory.GetFiles($"{SrcdsPath.Text.Substring(0, SrcdsPath.Text.LastIndexOf("\\"))}\\{root}\\maps").ToList();

            if (maps.Count != lastCount)
            {
                lastCount = maps.Count;
                MapList.Items.Clear();
            }
            else
                return; // no need to constantly do this expensive loop if nothing's changed

            for (int i = 0; i < maps.Count; i++)
            {
                if (!maps[i].EndsWith(".bsp"))
                    maps.RemoveAt(i);

                maps[i] = maps[i].Substring(maps[i].LastIndexOf("\\") + 1);
                maps[i] = maps[i].Remove(maps[i].LastIndexOf("."), 4);
            }

            MapList.Items.AddRange(maps.ToArray());
        }
        #endregion // Events

        #region Helpers
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

        private static string[][] GetDefaultGames()
        {
            return new[]
            {
                new[] { "232250", "Team Fortress 2", "tf" },
                new[] { "740", "Counter-Strike: Global Offensive", "csgo" },
                new[] { "232330", "Counter-Strike: Source", "cstrike" }
            };
        }

        private static string GetFolder(string title)
        {
            using var diag = new CommonOpenFileDialog
            {
                Title = title,
                IsFolderPicker = true,
                RestoreDirectory = true
            };

            return diag.ShowDialog() == CommonFileDialogResult.Ok ? diag.FileName : "";
        }

        private static string GetFile(string title, string fileName)
        {
            using var diag = new OpenFileDialog
            {
                Title = title,
                RestoreDirectory = true,
                Filter = $"|{fileName}"
            };

            return diag.ShowDialog() == DialogResult.OK ? diag.FileName : "";
        }
        #endregion // Helpers

        // small as in a few lines of code
        #region SmallEvents
        private void SteamCMDPathBrowse_Click(object sender, EventArgs e)
        {
            string file = GetFile("Select the steamcmd.exe file", "steamcmd.exe");

            if (string.IsNullOrWhiteSpace(file))
                return;

            SteamCMDPath.Text = file;
            UpdateServer.Enabled = !string.IsNullOrWhiteSpace(ServerPath.Text);
        }

        private void ServerPathBrowse_Click(object sender, EventArgs e)
        {
            string folder = GetFolder("Select the root of the server");

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

        private void AddLaunchParams_Click(object sender, EventArgs e)
        {
            AdditionalCommands.Visible = true;
            AdditionalCommands.BringToFront();
            AdditionalCommands.Focus();
        }

        private void AdditionalCommands_Leave(object sender, EventArgs e)
        {
            AdditionalCommands.Visible = false;
            AdditionalCommands.SendToBack();
            AdditionalCommands.Text = AdditionalCommands.Text.Replace("\r\n", " ");
        }

        private void AdditionalCommands_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                AdditionalCommands_Leave(sender, new EventArgs());
            }
        }

        private void CheckForUpdates_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ijre/SteamCMD-GUI/releases/latest");
        }

        private void DownloadSteamCMD_Click(object sender, EventArgs e)
        {
            Process.Start("http://media.steampowered.com/installer/steamcmd.zip");
        }

        private void ValveDeveloperCommunity_Click(object sender, EventArgs e)
        {
            Process.Start("https://developer.valvesoftware.com/wiki/SteamCMD");
        }
        #endregion // SmallEvents
    }
}

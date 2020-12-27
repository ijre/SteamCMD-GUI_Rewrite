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


            Process process = new Process
            {
                StartInfo =
                {
                    FileName = SteamCMDPath.Text,
                    UseShellExecute = false,
                    Arguments = arguments
                }
            };

            process.Start();
        }

        private void RunServerButton_Click(object sender, EventArgs e)
        {

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
            }

            MapList.Items.AddRange(maps.ToArray());
        }
        #endregion // Events

        #region Helpers
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

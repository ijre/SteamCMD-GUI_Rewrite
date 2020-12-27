using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Shell;

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

            if (!Directory.Exists(SettingsDir))
            {
                Directory.CreateDirectory(SettingsDir);
            }

            for (int i = 0; i < GameInfo.GetLength(0); i++)
            {
                GameListUpdateTab.Items.Add(GameInfo[i][1]);
            }
            GameListRunTab = GameListUpdateTab;

            if (!File.Exists(CustomGamesList))
            {
                File.WriteAllText(CustomGamesList, "");
            }
            else if (!string.IsNullOrWhiteSpace(File.ReadAllText(CustomGamesList)))
            {
                // TODO: handle loading custom games
            }
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
                arguments += $"{Username} {Password} ";
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

        #region Helpers
        private static string[][] GetDefaultGames()
        {
            return new[]
            {
                new[] { "232250", "Team Fortress 2" },
                new[] { "740", "Counter-Strike: Global Offensive" },
                new[] { "232330", "Counter-Strike: Source" }
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
                Filter = $"|{fileName}"
            };

            return diag.ShowDialog() == DialogResult.OK ? diag.FileName : "";
        }
        #endregion

        #region SmallClickEvents
        // small as in a few lines of code
        private void SteamCMDPathBrowse_Click(object sender, EventArgs e)
        {
            string file = GetFile("Select the steamcmd.exe file", "steamcmd.exe");

            if (string.IsNullOrWhiteSpace(file))
                return;

            SteamCMDPath.Text = file;

            if (!string.IsNullOrWhiteSpace(ServerPath.Text))
                UpdateServer.Enabled = true;
        }

        private void ServerPathBrowse_Click(object sender, EventArgs e)
        {
            string folder = GetFolder("Select the folder for the root of the server");

            if (string.IsNullOrWhiteSpace(folder))
                return;

            ServerPath.Text = folder;

            if (!string.IsNullOrWhiteSpace(SteamCMDPath.Text))
                UpdateServer.Enabled = true;
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
        #endregion
    }
}

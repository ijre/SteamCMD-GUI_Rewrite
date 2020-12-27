
namespace SteamCMD_GUI_Rewrite
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.SteamCMDConfigGroup = new System.Windows.Forms.GroupBox();
            this.SteamCMDPathBrowse = new System.Windows.Forms.Button();
            this.SteamCMDPath = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.ServerConfigGroup = new System.Windows.Forms.GroupBox();
            this.ValidateInstall = new System.Windows.Forms.CheckBox();
            this.ServerPathBrowse = new System.Windows.Forms.Button();
            this.UpdateServer = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.ServerPath = new System.Windows.Forms.TextBox();
            this.SaveLoginDetails = new System.Windows.Forms.CheckBox();
            this.AnonymousLogin = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.GameListUpdateTab = new System.Windows.Forms.ComboBox();
            this.SrcdsExeBrowserButton = new System.Windows.Forms.Button();
            this.SrcdsExePathTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.AddLaunchParams = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.InsecureCheckBox = new System.Windows.Forms.CheckBox();
            this.DevModeCheckBox = new System.Windows.Forms.CheckBox();
            this.RunServerButton = new System.Windows.Forms.Button();
            this.BotsCheckBox = new System.Windows.Forms.CheckBox();
            this.SourceTVCheckBox = new System.Windows.Forms.CheckBox();
            this.DebugModeCheckBox = new System.Windows.Forms.CheckBox();
            this.UDPPortTexBox = new System.Windows.Forms.NumericUpDown();
            this.RconTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.NetworkComboBox = new System.Windows.Forms.ComboBox();
            this.ServerNameTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.MaxPlayersTexBox = new System.Windows.Forms.NumericUpDown();
            this.CustomModTextBox = new System.Windows.Forms.TextBox();
            this.GameListRunTab = new System.Windows.Forms.ComboBox();
            this.CustomModCheckBox = new System.Windows.Forms.CheckBox();
            this.MapList = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.RunTab = new System.Windows.Forms.TabPage();
            this.IPTextbox = new System.Windows.Forms.TextBox();
            this.IPButton = new System.Windows.Forms.Button();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadSteamCMD = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ValveDeveloperCommunity = new System.Windows.Forms.ToolStripMenuItem();
            this.Status = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UpdateTab.SuspendLayout();
            this.SteamCMDConfigGroup.SuspendLayout();
            this.ServerConfigGroup.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDPPortTexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPlayersTexBox)).BeginInit();
            this.RunTab.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.SteamCMDConfigGroup);
            this.UpdateTab.Controls.Add(this.ServerConfigGroup);
            this.UpdateTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(395, 277);
            this.UpdateTab.TabIndex = 0;
            this.UpdateTab.Text = "Update/Install";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // SteamCMDConfigGroup
            // 
            this.SteamCMDConfigGroup.Controls.Add(this.SteamCMDPathBrowse);
            this.SteamCMDConfigGroup.Controls.Add(this.SteamCMDPath);
            this.SteamCMDConfigGroup.Controls.Add(this.Label4);
            this.SteamCMDConfigGroup.Location = new System.Drawing.Point(4, 3);
            this.SteamCMDConfigGroup.Name = "SteamCMDConfigGroup";
            this.SteamCMDConfigGroup.Size = new System.Drawing.Size(386, 48);
            this.SteamCMDConfigGroup.TabIndex = 0;
            this.SteamCMDConfigGroup.TabStop = false;
            this.SteamCMDConfigGroup.Text = "SteamCMD Configuration";
            // 
            // SteamCMDPathBrowse
            // 
            this.SteamCMDPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SteamCMDPathBrowse.Location = new System.Drawing.Point(313, 15);
            this.SteamCMDPathBrowse.Name = "SteamCMDPathBrowse";
            this.SteamCMDPathBrowse.Size = new System.Drawing.Size(68, 23);
            this.SteamCMDPathBrowse.TabIndex = 0;
            this.SteamCMDPathBrowse.Text = "Browse";
            this.SteamCMDPathBrowse.UseVisualStyleBackColor = true;
            this.SteamCMDPathBrowse.Click += new System.EventHandler(this.SteamCMDPathBrowse_Click);
            // 
            // SteamCMDPath
            // 
            this.SteamCMDPath.Location = new System.Drawing.Point(90, 17);
            this.SteamCMDPath.Name = "SteamCMDPath";
            this.SteamCMDPath.ReadOnly = true;
            this.SteamCMDPath.ShortcutsEnabled = false;
            this.SteamCMDPath.Size = new System.Drawing.Size(217, 20);
            this.SteamCMDPath.TabIndex = 0;
            this.SteamCMDPath.TabStop = false;
            this.SteamCMDPath.Click += new System.EventHandler(this.SteamCMDPathBrowse_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(6, 20);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "SteamCMD Path";
            // 
            // ServerConfigGroup
            // 
            this.ServerConfigGroup.Controls.Add(this.ValidateInstall);
            this.ServerConfigGroup.Controls.Add(this.ServerPathBrowse);
            this.ServerConfigGroup.Controls.Add(this.UpdateServer);
            this.ServerConfigGroup.Controls.Add(this.Label2);
            this.ServerConfigGroup.Controls.Add(this.ServerPath);
            this.ServerConfigGroup.Controls.Add(this.SaveLoginDetails);
            this.ServerConfigGroup.Controls.Add(this.AnonymousLogin);
            this.ServerConfigGroup.Controls.Add(this.label12);
            this.ServerConfigGroup.Controls.Add(this.label9);
            this.ServerConfigGroup.Controls.Add(this.Label1);
            this.ServerConfigGroup.Controls.Add(this.Username);
            this.ServerConfigGroup.Controls.Add(this.Password);
            this.ServerConfigGroup.Controls.Add(this.GameListUpdateTab);
            this.ServerConfigGroup.Location = new System.Drawing.Point(4, 57);
            this.ServerConfigGroup.Name = "ServerConfigGroup";
            this.ServerConfigGroup.Size = new System.Drawing.Size(387, 217);
            this.ServerConfigGroup.TabIndex = 1;
            this.ServerConfigGroup.TabStop = false;
            this.ServerConfigGroup.Text = "Server Configuration";
            // 
            // ValidateInstall
            // 
            this.ValidateInstall.AutoSize = true;
            this.ValidateInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ValidateInstall.Location = new System.Drawing.Point(5, 174);
            this.ValidateInstall.Name = "ValidateInstall";
            this.ValidateInstall.Size = new System.Drawing.Size(88, 17);
            this.ValidateInstall.TabIndex = 17;
            this.ValidateInstall.TabStop = false;
            this.ValidateInstall.Text = "Validate Files";
            this.ValidateInstall.UseVisualStyleBackColor = true;
            // 
            // ServerPathBrowse
            // 
            this.ServerPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ServerPathBrowse.Location = new System.Drawing.Point(313, 140);
            this.ServerPathBrowse.Name = "ServerPathBrowse";
            this.ServerPathBrowse.Size = new System.Drawing.Size(68, 23);
            this.ServerPathBrowse.TabIndex = 7;
            this.ServerPathBrowse.Text = "Browse";
            this.ServerPathBrowse.UseVisualStyleBackColor = true;
            this.ServerPathBrowse.Click += new System.EventHandler(this.ServerPathBrowse_Click);
            // 
            // UpdateServer
            // 
            this.UpdateServer.Enabled = false;
            this.UpdateServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpdateServer.Location = new System.Drawing.Point(208, 168);
            this.UpdateServer.Name = "UpdateServer";
            this.UpdateServer.Size = new System.Drawing.Size(99, 23);
            this.UpdateServer.TabIndex = 16;
            this.UpdateServer.Text = "Update/Install";
            this.UpdateServer.UseVisualStyleBackColor = true;
            this.UpdateServer.Click += new System.EventHandler(this.UpdateServerButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(2, 126);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Server Path";
            // 
            // ServerPath
            // 
            this.ServerPath.Location = new System.Drawing.Point(5, 142);
            this.ServerPath.Name = "ServerPath";
            this.ServerPath.ReadOnly = true;
            this.ServerPath.ShortcutsEnabled = false;
            this.ServerPath.Size = new System.Drawing.Size(302, 20);
            this.ServerPath.TabIndex = 0;
            this.ServerPath.TabStop = false;
            this.ServerPath.Click += new System.EventHandler(this.ServerPathBrowse_Click);
            // 
            // SaveLoginDetails
            // 
            this.SaveLoginDetails.AutoSize = true;
            this.SaveLoginDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveLoginDetails.Location = new System.Drawing.Point(181, 100);
            this.SaveLoginDetails.Name = "SaveLoginDetails";
            this.SaveLoginDetails.Size = new System.Drawing.Size(130, 17);
            this.SaveLoginDetails.TabIndex = 6;
            this.SaveLoginDetails.Text = "Save Details in Config";
            this.SaveLoginDetails.ThreeState = true;
            this.SaveLoginDetails.UseVisualStyleBackColor = true;
            // 
            // AnonymousLogin
            // 
            this.AnonymousLogin.AutoSize = true;
            this.AnonymousLogin.Checked = true;
            this.AnonymousLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnonymousLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AnonymousLogin.Location = new System.Drawing.Point(181, 74);
            this.AnonymousLogin.Name = "AnonymousLogin";
            this.AnonymousLogin.Size = new System.Drawing.Size(124, 17);
            this.AnonymousLogin.TabIndex = 6;
            this.AnonymousLogin.Text = "Login as Anonymous";
            this.AnonymousLogin.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(75, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Login";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(75, 72);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(75, 96);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 5;
            // 
            // GameListUpdateTab
            // 
            this.GameListUpdateTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameListUpdateTab.FormattingEnabled = true;
            this.GameListUpdateTab.IntegralHeight = false;
            this.GameListUpdateTab.Location = new System.Drawing.Point(75, 25);
            this.GameListUpdateTab.Name = "GameListUpdateTab";
            this.GameListUpdateTab.Size = new System.Drawing.Size(215, 21);
            this.GameListUpdateTab.TabIndex = 1;
            // 
            // SrcdsExeBrowserButton
            // 
            this.SrcdsExeBrowserButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SrcdsExeBrowserButton.Location = new System.Drawing.Point(312, 14);
            this.SrcdsExeBrowserButton.Name = "SrcdsExeBrowserButton";
            this.SrcdsExeBrowserButton.Size = new System.Drawing.Size(68, 23);
            this.SrcdsExeBrowserButton.TabIndex = 0;
            this.SrcdsExeBrowserButton.Text = "Browse";
            this.SrcdsExeBrowserButton.UseVisualStyleBackColor = true;
            // 
            // SrcdsExePathTextBox
            // 
            this.SrcdsExePathTextBox.Location = new System.Drawing.Point(71, 17);
            this.SrcdsExePathTextBox.Name = "SrcdsExePathTextBox";
            this.SrcdsExePathTextBox.ReadOnly = true;
            this.SrcdsExePathTextBox.Size = new System.Drawing.Size(235, 20);
            this.SrcdsExePathTextBox.TabIndex = 0;
            this.SrcdsExePathTextBox.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(6, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Srcds Path";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.SrcdsExeBrowserButton);
            this.GroupBox5.Controls.Add(this.SrcdsExePathTextBox);
            this.GroupBox5.Controls.Add(this.Label3);
            this.GroupBox5.Location = new System.Drawing.Point(4, 6);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(386, 48);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Srcds Configuration";
            // 
            // AddLaunchParams
            // 
            this.AddLaunchParams.BackgroundImage = global::SteamCMD_GUI_Rewrite.Properties.Resources.Add;
            this.AddLaunchParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddLaunchParams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddLaunchParams.Location = new System.Drawing.Point(346, 175);
            this.AddLaunchParams.Name = "AddLaunchParams";
            this.AddLaunchParams.Size = new System.Drawing.Size(23, 23);
            this.AddLaunchParams.TabIndex = 22;
            this.ToolTip.SetToolTip(this.AddLaunchParams, "Add More Command Line Params");
            this.AddLaunchParams.UseVisualStyleBackColor = true;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.AddLaunchParams);
            this.GroupBox6.Controls.Add(this.InsecureCheckBox);
            this.GroupBox6.Controls.Add(this.DevModeCheckBox);
            this.GroupBox6.Controls.Add(this.RunServerButton);
            this.GroupBox6.Controls.Add(this.BotsCheckBox);
            this.GroupBox6.Controls.Add(this.SourceTVCheckBox);
            this.GroupBox6.Controls.Add(this.DebugModeCheckBox);
            this.GroupBox6.Controls.Add(this.UDPPortTexBox);
            this.GroupBox6.Controls.Add(this.RconTextBox);
            this.GroupBox6.Controls.Add(this.Label11);
            this.GroupBox6.Controls.Add(this.Label10);
            this.GroupBox6.Controls.Add(this.NetworkComboBox);
            this.GroupBox6.Controls.Add(this.ServerNameTextBox);
            this.GroupBox6.Controls.Add(this.Label7);
            this.GroupBox6.Controls.Add(this.MaxPlayersTexBox);
            this.GroupBox6.Controls.Add(this.CustomModTextBox);
            this.GroupBox6.Controls.Add(this.GameListRunTab);
            this.GroupBox6.Controls.Add(this.CustomModCheckBox);
            this.GroupBox6.Controls.Add(this.MapList);
            this.GroupBox6.Controls.Add(this.Label6);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.Controls.Add(this.Label5);
            this.GroupBox6.Location = new System.Drawing.Point(4, 60);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(386, 211);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Game Configuration";
            // 
            // InsecureCheckBox
            // 
            this.InsecureCheckBox.AutoSize = true;
            this.InsecureCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InsecureCheckBox.Location = new System.Drawing.Point(11, 179);
            this.InsecureCheckBox.Name = "InsecureCheckBox";
            this.InsecureCheckBox.Size = new System.Drawing.Size(67, 17);
            this.InsecureCheckBox.TabIndex = 16;
            this.InsecureCheckBox.Text = "Insecure";
            this.InsecureCheckBox.UseVisualStyleBackColor = true;
            // 
            // DevModeCheckBox
            // 
            this.DevModeCheckBox.AutoSize = true;
            this.DevModeCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DevModeCheckBox.Location = new System.Drawing.Point(196, 179);
            this.DevModeCheckBox.Name = "DevModeCheckBox";
            this.DevModeCheckBox.Size = new System.Drawing.Size(97, 17);
            this.DevModeCheckBox.TabIndex = 18;
            this.DevModeCheckBox.Text = "Dev Messages";
            this.DevModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunServerButton
            // 
            this.RunServerButton.Enabled = false;
            this.RunServerButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RunServerButton.Location = new System.Drawing.Point(300, 175);
            this.RunServerButton.Name = "RunServerButton";
            this.RunServerButton.Size = new System.Drawing.Size(40, 23);
            this.RunServerButton.TabIndex = 19;
            this.RunServerButton.Text = "Run";
            this.RunServerButton.UseVisualStyleBackColor = true;
            // 
            // BotsCheckBox
            // 
            this.BotsCheckBox.AutoSize = true;
            this.BotsCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BotsCheckBox.Location = new System.Drawing.Point(105, 179);
            this.BotsCheckBox.Name = "BotsCheckBox";
            this.BotsCheckBox.Size = new System.Drawing.Size(85, 17);
            this.BotsCheckBox.TabIndex = 17;
            this.BotsCheckBox.Text = "Disable Bots";
            this.BotsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SourceTVCheckBox
            // 
            this.SourceTVCheckBox.AutoSize = true;
            this.SourceTVCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SourceTVCheckBox.Location = new System.Drawing.Point(105, 156);
            this.SourceTVCheckBox.Name = "SourceTVCheckBox";
            this.SourceTVCheckBox.Size = new System.Drawing.Size(74, 17);
            this.SourceTVCheckBox.TabIndex = 14;
            this.SourceTVCheckBox.Text = "SourceTV";
            this.SourceTVCheckBox.UseVisualStyleBackColor = true;
            // 
            // DebugModeCheckBox
            // 
            this.DebugModeCheckBox.AutoSize = true;
            this.DebugModeCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DebugModeCheckBox.Location = new System.Drawing.Point(11, 156);
            this.DebugModeCheckBox.Name = "DebugModeCheckBox";
            this.DebugModeCheckBox.Size = new System.Drawing.Size(88, 17);
            this.DebugModeCheckBox.TabIndex = 13;
            this.DebugModeCheckBox.Text = "Debug Mode";
            this.DebugModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UDPPortTexBox
            // 
            this.UDPPortTexBox.Location = new System.Drawing.Point(79, 128);
            this.UDPPortTexBox.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.UDPPortTexBox.Name = "UDPPortTexBox";
            this.UDPPortTexBox.Size = new System.Drawing.Size(100, 20);
            this.UDPPortTexBox.TabIndex = 10;
            this.UDPPortTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UDPPortTexBox.Value = new decimal(new int[] {
            27015,
            0,
            0,
            0});
            // 
            // RconTextBox
            // 
            this.RconTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.RconTextBox.Location = new System.Drawing.Point(289, 125);
            this.RconTextBox.Name = "RconTextBox";
            this.RconTextBox.PasswordChar = '*';
            this.RconTextBox.Size = new System.Drawing.Size(91, 22);
            this.RconTextBox.TabIndex = 11;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label11.Location = new System.Drawing.Point(249, 130);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(38, 13);
            this.Label11.TabIndex = 15;
            this.Label11.Text = "RCON";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label10.Location = new System.Drawing.Point(6, 130);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(52, 13);
            this.Label10.TabIndex = 12;
            this.Label10.Text = "UDP Port";
            // 
            // NetworkComboBox
            // 
            this.NetworkComboBox.FormattingEnabled = true;
            this.NetworkComboBox.Items.AddRange(new object[] {
            "Internet",
            "LAN"});
            this.NetworkComboBox.Location = new System.Drawing.Point(79, 100);
            this.NetworkComboBox.Name = "NetworkComboBox";
            this.NetworkComboBox.Size = new System.Drawing.Size(128, 21);
            this.NetworkComboBox.TabIndex = 8;
            // 
            // ServerNameTextBox
            // 
            this.ServerNameTextBox.Location = new System.Drawing.Point(79, 47);
            this.ServerNameTextBox.MaxLength = 50;
            this.ServerNameTextBox.Name = "ServerNameTextBox";
            this.ServerNameTextBox.Size = new System.Drawing.Size(199, 20);
            this.ServerNameTextBox.TabIndex = 6;
            this.ServerNameTextBox.Text = "Source Dedicated Server";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label7.Location = new System.Drawing.Point(6, 50);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(69, 13);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Server Name";
            // 
            // MaxPlayersTexBox
            // 
            this.MaxPlayersTexBox.Location = new System.Drawing.Point(333, 101);
            this.MaxPlayersTexBox.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.MaxPlayersTexBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxPlayersTexBox.Name = "MaxPlayersTexBox";
            this.MaxPlayersTexBox.Size = new System.Drawing.Size(46, 20);
            this.MaxPlayersTexBox.TabIndex = 9;
            this.MaxPlayersTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaxPlayersTexBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // CustomModTextBox
            // 
            this.CustomModTextBox.Enabled = false;
            this.CustomModTextBox.Location = new System.Drawing.Point(204, 20);
            this.CustomModTextBox.MaxLength = 15;
            this.CustomModTextBox.Name = "CustomModTextBox";
            this.CustomModTextBox.Size = new System.Drawing.Size(74, 20);
            this.CustomModTextBox.TabIndex = 3;
            // 
            // GameListRunTab
            // 
            this.GameListRunTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameListRunTab.FormattingEnabled = true;
            this.GameListRunTab.Location = new System.Drawing.Point(9, 20);
            this.GameListRunTab.Name = "GameListRunTab";
            this.GameListRunTab.Size = new System.Drawing.Size(189, 21);
            this.GameListRunTab.TabIndex = 2;
            // 
            // CustomModCheckBox
            // 
            this.CustomModCheckBox.AutoSize = true;
            this.CustomModCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomModCheckBox.Location = new System.Drawing.Point(284, 22);
            this.CustomModCheckBox.Name = "CustomModCheckBox";
            this.CustomModCheckBox.Size = new System.Drawing.Size(85, 17);
            this.CustomModCheckBox.TabIndex = 4;
            this.CustomModCheckBox.Text = "Custom Mod";
            this.CustomModCheckBox.UseVisualStyleBackColor = true;
            // 
            // MapList
            // 
            this.MapList.Enabled = false;
            this.MapList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MapList.FormattingEnabled = true;
            this.MapList.ItemHeight = 13;
            this.MapList.Location = new System.Drawing.Point(79, 73);
            this.MapList.Name = "MapList";
            this.MapList.Size = new System.Drawing.Size(199, 21);
            this.MapList.TabIndex = 7;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label6.Location = new System.Drawing.Point(249, 103);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Max Players";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label8.Location = new System.Drawing.Point(6, 103);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(47, 13);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Network";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label5.Location = new System.Drawing.Point(6, 76);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 13);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Map";
            // 
            // RunTab
            // 
            this.RunTab.Controls.Add(this.GroupBox6);
            this.RunTab.Controls.Add(this.GroupBox5);
            this.RunTab.Location = new System.Drawing.Point(4, 22);
            this.RunTab.Name = "RunTab";
            this.RunTab.Padding = new System.Windows.Forms.Padding(3);
            this.RunTab.Size = new System.Drawing.Size(395, 277);
            this.RunTab.TabIndex = 1;
            this.RunTab.Text = "Run";
            this.RunTab.UseVisualStyleBackColor = true;
            // 
            // IPTextbox
            // 
            this.IPTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPTextbox.Enabled = false;
            this.IPTextbox.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.IPTextbox.Location = new System.Drawing.Point(334, 337);
            this.IPTextbox.Name = "IPTextbox";
            this.IPTextbox.ReadOnly = true;
            this.IPTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IPTextbox.Size = new System.Drawing.Size(80, 20);
            this.IPTextbox.TabIndex = 101;
            this.IPTextbox.TabStop = false;
            this.IPTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IPButton
            // 
            this.IPButton.BackColor = System.Drawing.Color.Transparent;
            this.IPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IPButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IPButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IPButton.Location = new System.Drawing.Point(334, 336);
            this.IPButton.Name = "IPButton";
            this.IPButton.Size = new System.Drawing.Size(80, 20);
            this.IPButton.TabIndex = 102;
            this.IPButton.TabStop = false;
            this.IPButton.UseVisualStyleBackColor = false;
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.UpdateTab);
            this.MainTabs.Controls.Add(this.RunTab);
            this.MainTabs.Location = new System.Drawing.Point(11, 29);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(403, 303);
            this.MainTabs.TabIndex = 103;
            // 
            // FileStripMenu
            // 
            this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSettings,
            this.LoadSettings,
            this.ToolStripSeparator3});
            this.FileStripMenu.Name = "FileStripMenu";
            this.FileStripMenu.Size = new System.Drawing.Size(37, 20);
            this.FileStripMenu.Text = "File";
            // 
            // SaveSettings
            // 
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSettings.Size = new System.Drawing.Size(143, 22);
            this.SaveSettings.Text = "Save";
            // 
            // LoadSettings
            // 
            this.LoadSettings.Name = "LoadSettings";
            this.LoadSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.LoadSettings.Size = new System.Drawing.Size(143, 22);
            this.LoadSettings.Text = "Load";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(140, 6);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripMenu,
            this.ToolsStripMenu,
            this.HelpStripMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuStrip.Size = new System.Drawing.Size(414, 24);
            this.MenuStrip.TabIndex = 109;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // ToolsStripMenu
            // 
            this.ToolsStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadSteamCMD,
            this.CheckForUpdates});
            this.ToolsStripMenu.Name = "ToolsStripMenu";
            this.ToolsStripMenu.Size = new System.Drawing.Size(46, 20);
            this.ToolsStripMenu.Text = "Tools";
            // 
            // DownloadSteamCMD
            // 
            this.DownloadSteamCMD.Name = "DownloadSteamCMD";
            this.DownloadSteamCMD.Size = new System.Drawing.Size(191, 22);
            this.DownloadSteamCMD.Text = "Download SteamCMD";
            this.DownloadSteamCMD.Click += new System.EventHandler(this.DownloadSteamCMD_Click);
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.Name = "CheckForUpdates";
            this.CheckForUpdates.Size = new System.Drawing.Size(191, 22);
            this.CheckForUpdates.Text = "Check For Updates";
            this.CheckForUpdates.Click += new System.EventHandler(this.CheckForUpdates_Click);
            // 
            // HelpStripMenu
            // 
            this.HelpStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ValveDeveloperCommunity});
            this.HelpStripMenu.Name = "HelpStripMenu";
            this.HelpStripMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpStripMenu.Text = "Help";
            // 
            // ValveDeveloperCommunity
            // 
            this.ValveDeveloperCommunity.Name = "ValveDeveloperCommunity";
            this.ValveDeveloperCommunity.Size = new System.Drawing.Size(224, 22);
            this.ValveDeveloperCommunity.Text = "Valve Developer Community";
            this.ValveDeveloperCommunity.Click += new System.EventHandler(this.ValveDeveloperCommunity_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.SystemColors.Control;
            this.Status.Enabled = false;
            this.Status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Status.Location = new System.Drawing.Point(11, 337);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(317, 20);
            this.Status.TabIndex = 108;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(40, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(40, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Pass";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 358);
            this.Controls.Add(this.IPTextbox);
            this.Controls.Add(this.IPButton);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.Status);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 397);
            this.MinimumSize = new System.Drawing.Size(430, 397);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamCMD GUI";
            this.UpdateTab.ResumeLayout(false);
            this.SteamCMDConfigGroup.ResumeLayout(false);
            this.SteamCMDConfigGroup.PerformLayout();
            this.ServerConfigGroup.ResumeLayout(false);
            this.ServerConfigGroup.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDPPortTexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPlayersTexBox)).EndInit();
            this.RunTab.ResumeLayout(false);
            this.MainTabs.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.GroupBox SteamCMDConfigGroup;
        private System.Windows.Forms.Button SteamCMDPathBrowse;
        private System.Windows.Forms.TextBox SteamCMDPath;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.GroupBox ServerConfigGroup;
        private System.Windows.Forms.CheckBox ValidateInstall;
        private System.Windows.Forms.Button ServerPathBrowse;
        private System.Windows.Forms.Button UpdateServer;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox ServerPath;
        private System.Windows.Forms.CheckBox SaveLoginDetails;
        private System.Windows.Forms.CheckBox AnonymousLogin;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.ComboBox GameListUpdateTab;
        private System.Windows.Forms.Button SrcdsExeBrowserButton;
        private System.Windows.Forms.TextBox SrcdsExePathTextBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.Button AddLaunchParams;
        private System.Windows.Forms.GroupBox GroupBox6;
        private System.Windows.Forms.CheckBox InsecureCheckBox;
        private System.Windows.Forms.CheckBox DevModeCheckBox;
        private System.Windows.Forms.Button RunServerButton;
        private System.Windows.Forms.CheckBox BotsCheckBox;
        private System.Windows.Forms.CheckBox SourceTVCheckBox;
        private System.Windows.Forms.CheckBox DebugModeCheckBox;
        private System.Windows.Forms.NumericUpDown UDPPortTexBox;
        private System.Windows.Forms.MaskedTextBox RconTextBox;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox NetworkComboBox;
        private System.Windows.Forms.TextBox ServerNameTextBox;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.NumericUpDown MaxPlayersTexBox;
        private System.Windows.Forms.TextBox CustomModTextBox;
        private System.Windows.Forms.ComboBox GameListRunTab;
        private System.Windows.Forms.CheckBox CustomModCheckBox;
        private System.Windows.Forms.ComboBox MapList;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TabPage RunTab;
        private System.Windows.Forms.TextBox IPTextbox;
        private System.Windows.Forms.Button IPButton;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveSettings;
        private System.Windows.Forms.ToolStripMenuItem LoadSettings;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.ToolStripMenuItem ToolsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem DownloadSteamCMD;
        private System.Windows.Forms.ToolStripMenuItem HelpStripMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem ValveDeveloperCommunity;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}


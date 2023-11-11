
namespace SteamCMD_GUI
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
      this.AddSteamCMDLaunchParams = new System.Windows.Forms.Button();
      this.ValidateInstall = new System.Windows.Forms.CheckBox();
      this.ServerPathBrowse = new System.Windows.Forms.Button();
      this.UpdateServer = new System.Windows.Forms.Button();
      this.Label2 = new System.Windows.Forms.Label();
      this.ServerPath = new System.Windows.Forms.TextBox();
      this.SaveLoginDetails = new System.Windows.Forms.CheckBox();
      this.AnonymousLogin = new System.Windows.Forms.CheckBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.PasswordLogin = new System.Windows.Forms.TextBox();
      this.Username = new System.Windows.Forms.TextBox();
      this.GameListUpdateTab = new System.Windows.Forms.ComboBox();
      this.AdditionalSteamCMDCommands = new System.Windows.Forms.TextBox();
      this.SrcdsPathBrowse = new System.Windows.Forms.Button();
      this.SrcdsPath = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.GroupBox5 = new System.Windows.Forms.GroupBox();
      this.AddLaunchParams = new System.Windows.Forms.Button();
      this.GroupBox6 = new System.Windows.Forms.GroupBox();
      this.Rcon = new System.Windows.Forms.TextBox();
      this.Insecure = new System.Windows.Forms.CheckBox();
      this.DevMessages = new System.Windows.Forms.CheckBox();
      this.RunServer = new System.Windows.Forms.Button();
      this.SaveRCON = new System.Windows.Forms.CheckBox();
      this.HideRCON = new System.Windows.Forms.CheckBox();
      this.NoBots = new System.Windows.Forms.CheckBox();
      this.SourceTV = new System.Windows.Forms.CheckBox();
      this.UDPPort = new System.Windows.Forms.NumericUpDown();
      this.Label11 = new System.Windows.Forms.Label();
      this.Label10 = new System.Windows.Forms.Label();
      this.NetworkType = new System.Windows.Forms.ComboBox();
      this.PasswordServer = new System.Windows.Forms.TextBox();
      this.Hostname = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.Label7 = new System.Windows.Forms.Label();
      this.MaxPlayers = new System.Windows.Forms.NumericUpDown();
      this.GameListRunTab = new System.Windows.Forms.ComboBox();
      this.MapList = new System.Windows.Forms.ComboBox();
      this.Label6 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.RunTab = new System.Windows.Forms.TabPage();
      this.AdditionalCommands = new System.Windows.Forms.TextBox();
      this.MainTabs = new System.Windows.Forms.TabControl();
      this.FileStripMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.LoadSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.MenuStrip = new System.Windows.Forms.MenuStrip();
      this.ToolsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.DownloadSteamCMD = new System.Windows.Forms.ToolStripMenuItem();
      this.CheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
      this.HelpStripMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.SrcdsLaunchOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.HidePassword = new System.Windows.Forms.CheckBox();
      this.RefreshGameConfig = new System.Windows.Forms.ToolStripMenuItem();
      this.UpdateTab.SuspendLayout();
      this.SteamCMDConfigGroup.SuspendLayout();
      this.ServerConfigGroup.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UDPPort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxPlayers)).BeginInit();
      this.RunTab.SuspendLayout();
      this.MainTabs.SuspendLayout();
      this.MenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // UpdateTab
      // 
      this.UpdateTab.Controls.Add(this.SteamCMDConfigGroup);
      this.UpdateTab.Controls.Add(this.ServerConfigGroup);
      this.UpdateTab.Controls.Add(this.AdditionalSteamCMDCommands);
      this.UpdateTab.Location = new System.Drawing.Point(4, 22);
      this.UpdateTab.Name = "UpdateTab";
      this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
      this.UpdateTab.Size = new System.Drawing.Size(453, 300);
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
      this.SteamCMDConfigGroup.Size = new System.Drawing.Size(442, 48);
      this.SteamCMDConfigGroup.TabIndex = 0;
      this.SteamCMDConfigGroup.TabStop = false;
      this.SteamCMDConfigGroup.Text = "SteamCMD Configuration";
      // 
      // SteamCMDPathBrowse
      // 
      this.SteamCMDPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.SteamCMDPathBrowse.Location = new System.Drawing.Point(368, 16);
      this.SteamCMDPathBrowse.Name = "SteamCMDPathBrowse";
      this.SteamCMDPathBrowse.Size = new System.Drawing.Size(68, 22);
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
      this.SteamCMDPath.Size = new System.Drawing.Size(272, 20);
      this.SteamCMDPath.TabIndex = 1;
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
      this.ServerConfigGroup.Controls.Add(this.AddSteamCMDLaunchParams);
      this.ServerConfigGroup.Controls.Add(this.ValidateInstall);
      this.ServerConfigGroup.Controls.Add(this.ServerPathBrowse);
      this.ServerConfigGroup.Controls.Add(this.UpdateServer);
      this.ServerConfigGroup.Controls.Add(this.Label2);
      this.ServerConfigGroup.Controls.Add(this.ServerPath);
      this.ServerConfigGroup.Controls.Add(this.HidePassword);
      this.ServerConfigGroup.Controls.Add(this.SaveLoginDetails);
      this.ServerConfigGroup.Controls.Add(this.AnonymousLogin);
      this.ServerConfigGroup.Controls.Add(this.label12);
      this.ServerConfigGroup.Controls.Add(this.label14);
      this.ServerConfigGroup.Controls.Add(this.label9);
      this.ServerConfigGroup.Controls.Add(this.PasswordLogin);
      this.ServerConfigGroup.Controls.Add(this.Username);
      this.ServerConfigGroup.Controls.Add(this.GameListUpdateTab);
      this.ServerConfigGroup.Location = new System.Drawing.Point(4, 57);
      this.ServerConfigGroup.Name = "ServerConfigGroup";
      this.ServerConfigGroup.Size = new System.Drawing.Size(443, 237);
      this.ServerConfigGroup.TabIndex = 1;
      this.ServerConfigGroup.TabStop = false;
      this.ServerConfigGroup.Text = "Server Configuration";
      // 
      // AddSteamCMDLaunchParams
      // 
      this.AddSteamCMDLaunchParams.BackgroundImage = global::SteamCMD_GUI.Properties.Resources.Add;
      this.AddSteamCMDLaunchParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.AddSteamCMDLaunchParams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.AddSteamCMDLaunchParams.Location = new System.Drawing.Point(370, 182);
      this.AddSteamCMDLaunchParams.Name = "AddSteamCMDLaunchParams";
      this.AddSteamCMDLaunchParams.Size = new System.Drawing.Size(23, 23);
      this.AddSteamCMDLaunchParams.TabIndex = 14;
      this.ToolTip.SetToolTip(this.AddSteamCMDLaunchParams, "Add More Command Line Params");
      this.AddSteamCMDLaunchParams.UseVisualStyleBackColor = true;
      this.AddSteamCMDLaunchParams.Click += new System.EventHandler(this.AddLaunchParams_Click);
      // 
      // ValidateInstall
      // 
      this.ValidateInstall.AutoSize = true;
      this.ValidateInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ValidateInstall.Location = new System.Drawing.Point(6, 186);
      this.ValidateInstall.Name = "ValidateInstall";
      this.ValidateInstall.Size = new System.Drawing.Size(88, 17);
      this.ValidateInstall.TabIndex = 4;
      this.ValidateInstall.TabStop = false;
      this.ValidateInstall.Text = "Validate Files";
      this.ValidateInstall.UseVisualStyleBackColor = true;
      // 
      // ServerPathBrowse
      // 
      this.ServerPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ServerPathBrowse.Location = new System.Drawing.Point(370, 156);
      this.ServerPathBrowse.Name = "ServerPathBrowse";
      this.ServerPathBrowse.Size = new System.Drawing.Size(68, 22);
      this.ServerPathBrowse.TabIndex = 3;
      this.ServerPathBrowse.Text = "Browse";
      this.ServerPathBrowse.UseVisualStyleBackColor = true;
      this.ServerPathBrowse.Click += new System.EventHandler(this.ServerPathBrowse_Click);
      // 
      // UpdateServer
      // 
      this.UpdateServer.Enabled = false;
      this.UpdateServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.UpdateServer.Location = new System.Drawing.Point(265, 182);
      this.UpdateServer.Name = "UpdateServer";
      this.UpdateServer.Size = new System.Drawing.Size(99, 23);
      this.UpdateServer.TabIndex = 5;
      this.UpdateServer.Text = "Update/Install";
      this.UpdateServer.UseVisualStyleBackColor = true;
      this.UpdateServer.Click += new System.EventHandler(this.UpdateServerButton_Click);
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label2.Location = new System.Drawing.Point(3, 140);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(63, 13);
      this.Label2.TabIndex = 11;
      this.Label2.Text = "Server Path";
      // 
      // ServerPath
      // 
      this.ServerPath.Location = new System.Drawing.Point(6, 156);
      this.ServerPath.Name = "ServerPath";
      this.ServerPath.ReadOnly = true;
      this.ServerPath.ShortcutsEnabled = false;
      this.ServerPath.Size = new System.Drawing.Size(358, 20);
      this.ServerPath.TabIndex = 0;
      this.ServerPath.TabStop = false;
      this.ServerPath.Click += new System.EventHandler(this.ServerPathBrowse_Click);
      // 
      // SaveLoginDetails
      // 
      this.SaveLoginDetails.AutoSize = true;
      this.SaveLoginDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.SaveLoginDetails.Location = new System.Drawing.Point(230, 106);
      this.SaveLoginDetails.Name = "SaveLoginDetails";
      this.SaveLoginDetails.Size = new System.Drawing.Size(115, 17);
      this.SaveLoginDetails.TabIndex = 6;
      this.SaveLoginDetails.Text = "Save Login Details";
      this.SaveLoginDetails.ThreeState = true;
      this.ToolTip.SetToolTip(this.SaveLoginDetails, "Half check means it will only save your username");
      this.SaveLoginDetails.UseVisualStyleBackColor = true;
      this.SaveLoginDetails.Visible = false;
      // 
      // AnonymousLogin
      // 
      this.AnonymousLogin.AutoSize = true;
      this.AnonymousLogin.Checked = true;
      this.AnonymousLogin.CheckState = System.Windows.Forms.CheckState.Checked;
      this.AnonymousLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.AnonymousLogin.Location = new System.Drawing.Point(230, 81);
      this.AnonymousLogin.Name = "AnonymousLogin";
      this.AnonymousLogin.Size = new System.Drawing.Size(124, 17);
      this.AnonymousLogin.TabIndex = 6;
      this.AnonymousLogin.Text = "Login as Anonymous";
      this.AnonymousLogin.UseVisualStyleBackColor = true;
      this.AnonymousLogin.CheckedChanged += new System.EventHandler(this.AnonymousLogin_CheckedChanged);
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label12.Location = new System.Drawing.Point(89, 107);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(30, 13);
      this.label12.TabIndex = 8;
      this.label12.Text = "Pass";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label14.Location = new System.Drawing.Point(88, 43);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(35, 13);
      this.label14.TabIndex = 8;
      this.label14.Text = "Game";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label9.Location = new System.Drawing.Point(89, 81);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(29, 13);
      this.label9.TabIndex = 8;
      this.label9.Text = "User";
      // 
      // PasswordLogin
      // 
      this.PasswordLogin.Enabled = false;
      this.PasswordLogin.Location = new System.Drawing.Point(124, 103);
      this.PasswordLogin.Name = "PasswordLogin";
      this.PasswordLogin.Size = new System.Drawing.Size(100, 20);
      this.PasswordLogin.TabIndex = 1;
      this.PasswordLogin.UseSystemPasswordChar = true;
      // 
      // Username
      // 
      this.Username.Enabled = false;
      this.Username.Location = new System.Drawing.Point(124, 78);
      this.Username.Name = "Username";
      this.Username.Size = new System.Drawing.Size(100, 20);
      this.Username.TabIndex = 1;
      // 
      // HidePassword
      // 
      this.HidePassword.AutoSize = true;
      this.HidePassword.Checked = true;
      this.HidePassword.CheckState = System.Windows.Forms.CheckState.Checked;
      this.HidePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.HidePassword.Location = new System.Drawing.Point(230, 131);
      this.HidePassword.Name = "HidePassword";
      this.HidePassword.Size = new System.Drawing.Size(97, 17);
      this.HidePassword.TabIndex = 6;
      this.HidePassword.Text = "Hide Password";
      this.HidePassword.UseVisualStyleBackColor = true;
      this.HidePassword.Visible = false;
      this.HidePassword.CheckedChanged += new System.EventHandler(this.HidePassword_CheckedChanged);
      // 
      // GameListUpdateTab
      // 
      this.GameListUpdateTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.GameListUpdateTab.FormattingEnabled = true;
      this.GameListUpdateTab.IntegralHeight = false;
      this.GameListUpdateTab.Location = new System.Drawing.Point(124, 39);
      this.GameListUpdateTab.Name = "GameListUpdateTab";
      this.GameListUpdateTab.Size = new System.Drawing.Size(215, 21);
      this.GameListUpdateTab.TabIndex = 0;
      // 
      // AdditionalSteamCMDCommands
      // 
      this.AdditionalSteamCMDCommands.Location = new System.Drawing.Point(-3, -4);
      this.AdditionalSteamCMDCommands.Multiline = true;
      this.AdditionalSteamCMDCommands.Name = "AdditionalSteamCMDCommands";
      this.AdditionalSteamCMDCommands.Size = new System.Drawing.Size(457, 308);
      this.AdditionalSteamCMDCommands.TabIndex = 1000;
      this.AdditionalSteamCMDCommands.TabStop = false;
      this.AdditionalSteamCMDCommands.Visible = false;
      this.AdditionalSteamCMDCommands.WordWrap = false;
      this.AdditionalSteamCMDCommands.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AdditionalCommands_KeyUp);
      this.AdditionalSteamCMDCommands.Leave += new System.EventHandler(this.AdditionalCommands_Leave);
      // 
      // SrcdsPathBrowse
      // 
      this.SrcdsPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.SrcdsPathBrowse.Location = new System.Drawing.Point(369, 16);
      this.SrcdsPathBrowse.Name = "SrcdsPathBrowse";
      this.SrcdsPathBrowse.Size = new System.Drawing.Size(68, 22);
      this.SrcdsPathBrowse.TabIndex = 0;
      this.SrcdsPathBrowse.Text = "Browse";
      this.SrcdsPathBrowse.UseVisualStyleBackColor = true;
      this.SrcdsPathBrowse.Click += new System.EventHandler(this.SrcdsPathBrowse_Click);
      // 
      // SrcdsPath
      // 
      this.SrcdsPath.Location = new System.Drawing.Point(64, 17);
      this.SrcdsPath.Name = "SrcdsPath";
      this.SrcdsPath.ReadOnly = true;
      this.SrcdsPath.Size = new System.Drawing.Size(299, 20);
      this.SrcdsPath.TabIndex = 1;
      this.SrcdsPath.TabStop = false;
      this.SrcdsPath.Click += new System.EventHandler(this.SrcdsPathBrowse_Click);
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
      this.GroupBox5.Controls.Add(this.SrcdsPathBrowse);
      this.GroupBox5.Controls.Add(this.SrcdsPath);
      this.GroupBox5.Controls.Add(this.Label3);
      this.GroupBox5.Location = new System.Drawing.Point(4, 6);
      this.GroupBox5.Name = "GroupBox5";
      this.GroupBox5.Size = new System.Drawing.Size(443, 48);
      this.GroupBox5.TabIndex = 1;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Srcds Configuration";
      // 
      // AddLaunchParams
      // 
      this.AddLaunchParams.BackgroundImage = global::SteamCMD_GUI.Properties.Resources.Add;
      this.AddLaunchParams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.AddLaunchParams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.AddLaunchParams.Location = new System.Drawing.Point(265, 207);
      this.AddLaunchParams.Name = "AddLaunchParams";
      this.AddLaunchParams.Size = new System.Drawing.Size(23, 23);
      this.AddLaunchParams.TabIndex = 13;
      this.ToolTip.SetToolTip(this.AddLaunchParams, "Add More Command Line Params");
      this.AddLaunchParams.UseVisualStyleBackColor = true;
      this.AddLaunchParams.Click += new System.EventHandler(this.AddLaunchParams_Click);
      // 
      // GroupBox6
      // 
      this.GroupBox6.Controls.Add(this.Rcon);
      this.GroupBox6.Controls.Add(this.AddLaunchParams);
      this.GroupBox6.Controls.Add(this.Insecure);
      this.GroupBox6.Controls.Add(this.DevMessages);
      this.GroupBox6.Controls.Add(this.RunServer);
      this.GroupBox6.Controls.Add(this.SaveRCON);
      this.GroupBox6.Controls.Add(this.HideRCON);
      this.GroupBox6.Controls.Add(this.NoBots);
      this.GroupBox6.Controls.Add(this.SourceTV);
      this.GroupBox6.Controls.Add(this.UDPPort);
      this.GroupBox6.Controls.Add(this.Label11);
      this.GroupBox6.Controls.Add(this.Label10);
      this.GroupBox6.Controls.Add(this.NetworkType);
      this.GroupBox6.Controls.Add(this.PasswordServer);
      this.GroupBox6.Controls.Add(this.Hostname);
      this.GroupBox6.Controls.Add(this.label13);
      this.GroupBox6.Controls.Add(this.label1);
      this.GroupBox6.Controls.Add(this.Label7);
      this.GroupBox6.Controls.Add(this.MaxPlayers);
      this.GroupBox6.Controls.Add(this.GameListRunTab);
      this.GroupBox6.Controls.Add(this.MapList);
      this.GroupBox6.Controls.Add(this.Label6);
      this.GroupBox6.Controls.Add(this.Label8);
      this.GroupBox6.Controls.Add(this.Label5);
      this.GroupBox6.Location = new System.Drawing.Point(4, 60);
      this.GroupBox6.Name = "GroupBox6";
      this.GroupBox6.Size = new System.Drawing.Size(443, 234);
      this.GroupBox6.TabIndex = 2;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Game Configuration";
      // 
      // Rcon
      // 
      this.Rcon.Location = new System.Drawing.Point(332, 132);
      this.Rcon.Name = "Rcon";
      this.Rcon.Size = new System.Drawing.Size(91, 20);
      this.Rcon.TabIndex = 7;
      this.Rcon.UseSystemPasswordChar = true;
      // 
      // Insecure
      // 
      this.Insecure.AutoSize = true;
      this.Insecure.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Insecure.Location = new System.Drawing.Point(10, 211);
      this.Insecure.Name = "Insecure";
      this.Insecure.Size = new System.Drawing.Size(67, 17);
      this.Insecure.TabIndex = 11;
      this.Insecure.Text = "Insecure";
      this.Insecure.UseVisualStyleBackColor = true;
      // 
      // DevMessages
      // 
      this.DevMessages.AutoSize = true;
      this.DevMessages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.DevMessages.Location = new System.Drawing.Point(93, 211);
      this.DevMessages.Name = "DevMessages";
      this.DevMessages.Size = new System.Drawing.Size(97, 17);
      this.DevMessages.TabIndex = 12;
      this.DevMessages.Text = "Dev Messages";
      this.DevMessages.UseVisualStyleBackColor = true;
      // 
      // RunServer
      // 
      this.RunServer.Enabled = false;
      this.RunServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.RunServer.Location = new System.Drawing.Point(219, 207);
      this.RunServer.Name = "RunServer";
      this.RunServer.Size = new System.Drawing.Size(40, 23);
      this.RunServer.TabIndex = 14;
      this.RunServer.Text = "Run";
      this.RunServer.UseVisualStyleBackColor = true;
      this.RunServer.Click += new System.EventHandler(this.RunServerButton_Click);
      // 
      // SaveRCON
      // 
      this.SaveRCON.AutoSize = true;
      this.SaveRCON.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.SaveRCON.Location = new System.Drawing.Point(287, 158);
      this.SaveRCON.Name = "SaveRCON";
      this.SaveRCON.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.SaveRCON.Size = new System.Drawing.Size(85, 17);
      this.SaveRCON.TabIndex = 8;
      this.SaveRCON.Text = "Save RCON";
      this.SaveRCON.UseVisualStyleBackColor = true;
      // 
      // HideRCON
      // 
      this.HideRCON.AutoSize = true;
      this.HideRCON.Checked = true;
      this.HideRCON.CheckState = System.Windows.Forms.CheckState.Checked;
      this.HideRCON.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.HideRCON.Location = new System.Drawing.Point(290, 174);
      this.HideRCON.Name = "HideRCON";
      this.HideRCON.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.HideRCON.Size = new System.Drawing.Size(82, 17);
      this.HideRCON.TabIndex = 9;
      this.HideRCON.Text = "Hide RCON";
      this.HideRCON.UseVisualStyleBackColor = true;
      this.HideRCON.CheckedChanged += new System.EventHandler(this.HideRCON_CheckedChanged);
      // 
      // NoBots
      // 
      this.NoBots.AutoSize = true;
      this.NoBots.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.NoBots.Location = new System.Drawing.Point(93, 186);
      this.NoBots.Name = "NoBots";
      this.NoBots.Size = new System.Drawing.Size(85, 17);
      this.NoBots.TabIndex = 10;
      this.NoBots.Text = "Disable Bots";
      this.NoBots.UseVisualStyleBackColor = true;
      // 
      // SourceTV
      // 
      this.SourceTV.AutoSize = true;
      this.SourceTV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.SourceTV.Location = new System.Drawing.Point(10, 186);
      this.SourceTV.Name = "SourceTV";
      this.SourceTV.Size = new System.Drawing.Size(74, 17);
      this.SourceTV.TabIndex = 9;
      this.SourceTV.Text = "SourceTV";
      this.SourceTV.UseVisualStyleBackColor = true;
      // 
      // UDPPort
      // 
      this.UDPPort.Location = new System.Drawing.Point(79, 155);
      this.UDPPort.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
      this.UDPPort.Name = "UDPPort";
      this.UDPPort.Size = new System.Drawing.Size(100, 20);
      this.UDPPort.TabIndex = 6;
      this.UDPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.UDPPort.Value = new decimal(new int[] {
            27015,
            0,
            0,
            0});
      // 
      // Label11
      // 
      this.Label11.AutoSize = true;
      this.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label11.Location = new System.Drawing.Point(288, 135);
      this.Label11.Name = "Label11";
      this.Label11.Size = new System.Drawing.Size(38, 13);
      this.Label11.TabIndex = 15;
      this.Label11.Text = "RCON";
      // 
      // Label10
      // 
      this.Label10.AutoSize = true;
      this.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label10.Location = new System.Drawing.Point(6, 159);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(52, 13);
      this.Label10.TabIndex = 12;
      this.Label10.Text = "UDP Port";
      // 
      // NetworkType
      // 
      this.NetworkType.FormattingEnabled = true;
      this.NetworkType.Items.AddRange(new object[] {
            "Internet",
            "LAN"});
      this.NetworkType.Location = new System.Drawing.Point(79, 127);
      this.NetworkType.Name = "NetworkType";
      this.NetworkType.Size = new System.Drawing.Size(128, 21);
      this.NetworkType.TabIndex = 3;
      // 
      // PasswordServer
      // 
      this.PasswordServer.Location = new System.Drawing.Point(79, 74);
      this.PasswordServer.MaxLength = 50;
      this.PasswordServer.Name = "PasswordServer";
      this.PasswordServer.Size = new System.Drawing.Size(199, 20);
      this.PasswordServer.TabIndex = 5;
      // 
      // Hostname
      // 
      this.Hostname.Location = new System.Drawing.Point(79, 47);
      this.Hostname.MaxLength = 50;
      this.Hostname.Name = "Hostname";
      this.Hostname.Size = new System.Drawing.Size(199, 20);
      this.Hostname.TabIndex = 1;
      this.Hostname.Text = "Source Dedicated Server";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label13.Location = new System.Drawing.Point(6, 26);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(35, 13);
      this.label13.TabIndex = 9;
      this.label13.Text = "Game";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.label1.Location = new System.Drawing.Point(6, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Password";
      // 
      // Label7
      // 
      this.Label7.AutoSize = true;
      this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label7.Location = new System.Drawing.Point(6, 51);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(55, 13);
      this.Label7.TabIndex = 9;
      this.Label7.Text = "Hostname";
      // 
      // MaxPlayers
      // 
      this.MaxPlayers.Location = new System.Drawing.Point(377, 110);
      this.MaxPlayers.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
      this.MaxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.MaxPlayers.Name = "MaxPlayers";
      this.MaxPlayers.Size = new System.Drawing.Size(46, 20);
      this.MaxPlayers.TabIndex = 6;
      this.MaxPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.MaxPlayers.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
      // 
      // GameListRunTab
      // 
      this.GameListRunTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.GameListRunTab.FormattingEnabled = true;
      this.GameListRunTab.Location = new System.Drawing.Point(79, 20);
      this.GameListRunTab.Name = "GameListRunTab";
      this.GameListRunTab.Size = new System.Drawing.Size(209, 21);
      this.GameListRunTab.TabIndex = 0;
      // 
      // MapList
      // 
      this.MapList.Enabled = false;
      this.MapList.ForeColor = System.Drawing.SystemColors.WindowText;
      this.MapList.FormattingEnabled = true;
      this.MapList.ItemHeight = 13;
      this.MapList.Location = new System.Drawing.Point(79, 100);
      this.MapList.Name = "MapList";
      this.MapList.Size = new System.Drawing.Size(199, 21);
      this.MapList.TabIndex = 2;
      this.MapList.SelectedIndexChanged += new System.EventHandler(this.MapList_SelectedIndexChanged);
      this.MapList.Enter += new System.EventHandler(this.MapList_EnterOrLeave);
      this.MapList.Leave += new System.EventHandler(this.MapList_EnterOrLeave);
      // 
      // Label6
      // 
      this.Label6.AutoSize = true;
      this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label6.Location = new System.Drawing.Point(288, 112);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(64, 13);
      this.Label6.TabIndex = 0;
      this.Label6.Text = "Max Players";
      // 
      // Label8
      // 
      this.Label8.AutoSize = true;
      this.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label8.Location = new System.Drawing.Point(6, 131);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(47, 13);
      this.Label8.TabIndex = 0;
      this.Label8.Text = "Network";
      // 
      // Label5
      // 
      this.Label5.AutoSize = true;
      this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label5.Location = new System.Drawing.Point(6, 104);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(28, 13);
      this.Label5.TabIndex = 0;
      this.Label5.Text = "Map";
      // 
      // RunTab
      // 
      this.RunTab.Controls.Add(this.GroupBox6);
      this.RunTab.Controls.Add(this.GroupBox5);
      this.RunTab.Controls.Add(this.AdditionalCommands);
      this.RunTab.Location = new System.Drawing.Point(4, 22);
      this.RunTab.Name = "RunTab";
      this.RunTab.Padding = new System.Windows.Forms.Padding(3);
      this.RunTab.Size = new System.Drawing.Size(453, 300);
      this.RunTab.TabIndex = 1;
      this.RunTab.Text = "Run";
      this.RunTab.UseVisualStyleBackColor = true;
      // 
      // AdditionalCommands
      // 
      this.AdditionalCommands.Location = new System.Drawing.Point(-3, -4);
      this.AdditionalCommands.Multiline = true;
      this.AdditionalCommands.Name = "AdditionalCommands";
      this.AdditionalCommands.Size = new System.Drawing.Size(457, 308);
      this.AdditionalCommands.TabIndex = 999;
      this.AdditionalCommands.TabStop = false;
      this.AdditionalCommands.Visible = false;
      this.AdditionalCommands.WordWrap = false;
      this.AdditionalCommands.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AdditionalCommands_KeyUp);
      this.AdditionalCommands.Leave += new System.EventHandler(this.AdditionalCommands_Leave);
      // 
      // MainTabs
      // 
      this.MainTabs.Controls.Add(this.UpdateTab);
      this.MainTabs.Controls.Add(this.RunTab);
      this.MainTabs.Location = new System.Drawing.Point(11, 29);
      this.MainTabs.Name = "MainTabs";
      this.MainTabs.SelectedIndex = 0;
      this.MainTabs.Size = new System.Drawing.Size(461, 326);
      this.MainTabs.TabIndex = 0;
      // 
      // FileStripMenu
      // 
      this.FileStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSettings,
            this.LoadSettings});
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
      this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
      // 
      // LoadSettings
      // 
      this.LoadSettings.Name = "LoadSettings";
      this.LoadSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.LoadSettings.Size = new System.Drawing.Size(143, 22);
      this.LoadSettings.Text = "Load";
      this.LoadSettings.Click += new System.EventHandler(this.LoadSettings_Click);
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
      this.MenuStrip.Size = new System.Drawing.Size(481, 24);
      this.MenuStrip.TabIndex = 2;
      this.MenuStrip.Text = "MenuStrip1";
      // 
      // ToolsStripMenu
      // 
      this.ToolsStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshGameConfig,
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
            this.SrcdsLaunchOptions});
      this.HelpStripMenu.Name = "HelpStripMenu";
      this.HelpStripMenu.Size = new System.Drawing.Size(44, 20);
      this.HelpStripMenu.Text = "Help";
      // 
      // SrcdsLaunchOptions
      // 
      this.SrcdsLaunchOptions.Name = "SrcdsLaunchOptions";
      this.SrcdsLaunchOptions.Size = new System.Drawing.Size(189, 22);
      this.SrcdsLaunchOptions.Text = "Srcds Launch Options";
      this.SrcdsLaunchOptions.Click += new System.EventHandler(this.SrcdsLaunchOptions_Click);
      // 
      // ToolTip
      // 
      this.ToolTip.AutoPopDelay = 5000;
      this.ToolTip.InitialDelay = 200;
      this.ToolTip.ReshowDelay = 100;
      this.ToolTip.ShowAlways = true;
      // 
      // RefreshGameConfig
      // 
      this.RefreshGameConfig.Name = "RefreshGameConfig";
      this.RefreshGameConfig.Size = new System.Drawing.Size(191, 22);
      this.RefreshGameConfig.Text = "Refresh GAMES.cfg";
      this.RefreshGameConfig.Click += new System.EventHandler(this.RefreshGameConfig_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 359);
      this.Controls.Add(this.MainTabs);
      this.Controls.Add(this.MenuStrip);
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(497, 398);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SteamCMD GUI";
      this.UpdateTab.ResumeLayout(false);
      this.UpdateTab.PerformLayout();
      this.SteamCMDConfigGroup.ResumeLayout(false);
      this.SteamCMDConfigGroup.PerformLayout();
      this.ServerConfigGroup.ResumeLayout(false);
      this.ServerConfigGroup.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.UDPPort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.MaxPlayers)).EndInit();
      this.RunTab.ResumeLayout(false);
      this.RunTab.PerformLayout();
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
        private System.Windows.Forms.CheckBox AnonymousLogin;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.ComboBox GameListUpdateTab;
        private System.Windows.Forms.Button SrcdsPathBrowse;
        private System.Windows.Forms.TextBox SrcdsPath;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.Button AddLaunchParams;
        private System.Windows.Forms.GroupBox GroupBox6;
        private System.Windows.Forms.CheckBox Insecure;
        private System.Windows.Forms.CheckBox DevMessages;
        private System.Windows.Forms.Button RunServer;
        private System.Windows.Forms.CheckBox NoBots;
        private System.Windows.Forms.CheckBox SourceTV;
        private System.Windows.Forms.ComboBox NetworkType;
        private System.Windows.Forms.TextBox Hostname;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.NumericUpDown MaxPlayers;
        private System.Windows.Forms.ComboBox GameListRunTab;
        private System.Windows.Forms.ComboBox MapList;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TabPage RunTab;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.ToolStripMenuItem FileStripMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveSettings;
        private System.Windows.Forms.ToolStripMenuItem LoadSettings;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem DownloadSteamCMD;
        private System.Windows.Forms.ToolStripMenuItem HelpStripMenu;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdates;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox SaveLoginDetails;
        private System.Windows.Forms.NumericUpDown UDPPort;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Rcon;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.ToolStripMenuItem SrcdsLaunchOptions;
        private System.Windows.Forms.CheckBox SaveRCON;
        private System.Windows.Forms.CheckBox HideRCON;
        private System.Windows.Forms.TextBox PasswordServer;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button AddSteamCMDLaunchParams;
    private System.Windows.Forms.TextBox AdditionalSteamCMDCommands;
    private System.Windows.Forms.TextBox AdditionalCommands;
    private System.Windows.Forms.CheckBox HidePassword;
    private System.Windows.Forms.ToolStripMenuItem RefreshGameConfig;
  }
}


namespace MC_Admin
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            HomeHeader = new Panel();
            label1 = new Label();
            lbl_Name2 = new Label();
            lbl_Application_Name = new Label();
            lbl_DateTime = new Label();
            lbl_UserName = new Label();
            ControlBox_Home = new ReaLTaiizor.Controls.NightControlBox();
            PicBox_Home_Menu = new PictureBox();
            FlowPanel_Home_Menu = new FlowLayoutPanel();
            panel_MenuBlank = new Panel();
            Button_Menu_Home = new Panel();
            Button_Menu_HomeLabel = new Label();
            Button_Menu_Settings = new Panel();
            panel9 = new Panel();
            label9 = new Label();
            Button_Menu_SettingsLabel = new Label();
            Button_Menu_Logout = new Panel();
            panel11 = new Panel();
            label10 = new Label();
            Button_Menu_LogoutLabel = new Label();
            HomePanel = new Panel();
            HomeHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicBox_Home_Menu).BeginInit();
            FlowPanel_Home_Menu.SuspendLayout();
            Button_Menu_Home.SuspendLayout();
            Button_Menu_Settings.SuspendLayout();
            panel9.SuspendLayout();
            Button_Menu_Logout.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // HomeHeader
            // 
            HomeHeader.BackColor = Color.FromArgb(206, 217, 237);
            HomeHeader.Controls.Add(label1);
            HomeHeader.Controls.Add(lbl_Name2);
            HomeHeader.Controls.Add(lbl_Application_Name);
            HomeHeader.Controls.Add(lbl_DateTime);
            HomeHeader.Controls.Add(lbl_UserName);
            HomeHeader.Controls.Add(ControlBox_Home);
            HomeHeader.Controls.Add(PicBox_Home_Menu);
            resources.ApplyResources(HomeHeader, "HomeHeader");
            HomeHeader.Name = "HomeHeader";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Name = "label1";
            // 
            // lbl_Name2
            // 
            resources.ApplyResources(lbl_Name2, "lbl_Name2");
            lbl_Name2.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_Name2.Name = "lbl_Name2";
            // 
            // lbl_Application_Name
            // 
            resources.ApplyResources(lbl_Application_Name, "lbl_Application_Name");
            lbl_Application_Name.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_Application_Name.Name = "lbl_Application_Name";
            // 
            // lbl_DateTime
            // 
            resources.ApplyResources(lbl_DateTime, "lbl_DateTime");
            lbl_DateTime.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_DateTime.Name = "lbl_DateTime";
            // 
            // lbl_UserName
            // 
            resources.ApplyResources(lbl_UserName, "lbl_UserName");
            lbl_UserName.ForeColor = Color.FromArgb(64, 64, 64);
            lbl_UserName.Name = "lbl_UserName";
            // 
            // ControlBox_Home
            // 
            resources.ApplyResources(ControlBox_Home, "ControlBox_Home");
            ControlBox_Home.BackColor = Color.Transparent;
            ControlBox_Home.CloseHoverColor = Color.FromArgb(199, 80, 80);
            ControlBox_Home.CloseHoverForeColor = Color.White;
            ControlBox_Home.DefaultLocation = true;
            ControlBox_Home.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            ControlBox_Home.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            ControlBox_Home.EnableCloseColor = Color.FromArgb(160, 160, 160);
            ControlBox_Home.EnableMaximizeButton = true;
            ControlBox_Home.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            ControlBox_Home.EnableMinimizeButton = true;
            ControlBox_Home.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            ControlBox_Home.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            ControlBox_Home.MaximizeHoverForeColor = Color.White;
            ControlBox_Home.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            ControlBox_Home.MinimizeHoverForeColor = Color.White;
            ControlBox_Home.Name = "ControlBox_Home";
            // 
            // PicBox_Home_Menu
            // 
            PicBox_Home_Menu.Image = TypeSafeFrontend.Properties.Resources.T_Logo;
            resources.ApplyResources(PicBox_Home_Menu, "PicBox_Home_Menu");
            PicBox_Home_Menu.Name = "PicBox_Home_Menu";
            PicBox_Home_Menu.TabStop = false;
            // 
            // FlowPanel_Home_Menu
            // 
            FlowPanel_Home_Menu.BackColor = Color.FromArgb(206, 217, 237);
            resources.ApplyResources(FlowPanel_Home_Menu, "FlowPanel_Home_Menu");
            FlowPanel_Home_Menu.Controls.Add(panel_MenuBlank);
            FlowPanel_Home_Menu.Controls.Add(Button_Menu_Home);
            FlowPanel_Home_Menu.Controls.Add(Button_Menu_Settings);
            FlowPanel_Home_Menu.Controls.Add(Button_Menu_Logout);
            FlowPanel_Home_Menu.Name = "FlowPanel_Home_Menu";
            // 
            // panel_MenuBlank
            // 
            panel_MenuBlank.BackColor = Color.FromArgb(206, 217, 237);
            resources.ApplyResources(panel_MenuBlank, "panel_MenuBlank");
            panel_MenuBlank.Name = "panel_MenuBlank";
            // 
            // Button_Menu_Home
            // 
            Button_Menu_Home.BackColor = Color.FromArgb(206, 217, 237);
            resources.ApplyResources(Button_Menu_Home, "Button_Menu_Home");
            Button_Menu_Home.Controls.Add(Button_Menu_HomeLabel);
            Button_Menu_Home.Name = "Button_Menu_Home";
            Button_Menu_Home.MouseClick += Button_Menu_Home_MouseClick;
            Button_Menu_Home.MouseEnter += Button_Menu_Home_MouseEnter;
            Button_Menu_Home.MouseLeave += Button_Menu_Home_MouseLeave;
            // 
            // Button_Menu_HomeLabel
            // 
            resources.ApplyResources(Button_Menu_HomeLabel, "Button_Menu_HomeLabel");
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_HomeLabel.Name = "Button_Menu_HomeLabel";
            Button_Menu_HomeLabel.Click += Button_Menu_HomeLabel_Click;
            Button_Menu_HomeLabel.MouseEnter += Button_Menu_HomeLabel_MouseEnter;
            Button_Menu_HomeLabel.MouseLeave += Button_Menu_HomeLabel_MouseLeave;
            // 
            // Button_Menu_Settings
            // 
            Button_Menu_Settings.BackColor = Color.FromArgb(206, 217, 237);
            Button_Menu_Settings.Controls.Add(panel9);
            Button_Menu_Settings.Controls.Add(Button_Menu_SettingsLabel);
            resources.ApplyResources(Button_Menu_Settings, "Button_Menu_Settings");
            Button_Menu_Settings.Name = "Button_Menu_Settings";
            Button_Menu_Settings.MouseClick += Button_Menu_Settings_MouseClick;
            Button_Menu_Settings.MouseEnter += Button_Menu_Settings_MouseEnter;
            Button_Menu_Settings.MouseLeave += Button_Menu_Settings_MouseLeave;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(244, 245, 245);
            panel9.Controls.Add(label9);
            resources.ApplyResources(panel9, "panel9");
            panel9.Name = "panel9";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.ForeColor = Color.FromArgb(142, 142, 142);
            label9.Name = "label9";
            // 
            // Button_Menu_SettingsLabel
            // 
            resources.ApplyResources(Button_Menu_SettingsLabel, "Button_Menu_SettingsLabel");
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_SettingsLabel.Name = "Button_Menu_SettingsLabel";
            Button_Menu_SettingsLabel.Click += Button_Menu_SettingsLabel_Click;
            Button_Menu_SettingsLabel.MouseEnter += Button_Menu_SettingsLabel_MouseEnter;
            Button_Menu_SettingsLabel.MouseLeave += Button_Menu_SettingsLabel_MouseLeave;
            // 
            // Button_Menu_Logout
            // 
            Button_Menu_Logout.BackColor = Color.FromArgb(206, 217, 237);
            Button_Menu_Logout.Controls.Add(panel11);
            Button_Menu_Logout.Controls.Add(Button_Menu_LogoutLabel);
            resources.ApplyResources(Button_Menu_Logout, "Button_Menu_Logout");
            Button_Menu_Logout.Name = "Button_Menu_Logout";
            Button_Menu_Logout.MouseClick += Button_Menu_Logout_MouseClick;
            Button_Menu_Logout.MouseEnter += Button_Menu_Logout_MouseEnter;
            Button_Menu_Logout.MouseLeave += Button_Menu_Logout_MouseLeave;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(244, 245, 245);
            panel11.Controls.Add(label10);
            resources.ApplyResources(panel11, "panel11");
            panel11.Name = "panel11";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.ForeColor = Color.FromArgb(142, 142, 142);
            label10.Name = "label10";
            // 
            // Button_Menu_LogoutLabel
            // 
            resources.ApplyResources(Button_Menu_LogoutLabel, "Button_Menu_LogoutLabel");
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_LogoutLabel.Name = "Button_Menu_LogoutLabel";
            Button_Menu_LogoutLabel.Click += Button_Menu_LogoutLabel_Click;
            Button_Menu_LogoutLabel.MouseEnter += Button_Menu_LogoutLabel_MouseEnter;
            Button_Menu_LogoutLabel.MouseLeave += Button_Menu_LogoutLabel_MouseLeave;
            // 
            // HomePanel
            // 
            resources.ApplyResources(HomePanel, "HomePanel");
            HomePanel.BackColor = Color.White;
            HomePanel.Name = "HomePanel";
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = Color.FromArgb(244, 245, 245);
            Controls.Add(HomePanel);
            Controls.Add(FlowPanel_Home_Menu);
            Controls.Add(HomeHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Home";
            WindowState = FormWindowState.Maximized;
            HomeHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicBox_Home_Menu).EndInit();
            FlowPanel_Home_Menu.ResumeLayout(false);
            Button_Menu_Home.ResumeLayout(false);
            Button_Menu_Home.PerformLayout();
            Button_Menu_Settings.ResumeLayout(false);
            Button_Menu_Settings.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            Button_Menu_Logout.ResumeLayout(false);
            Button_Menu_Logout.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HomeHeader;
        private ReaLTaiizor.Controls.NightControlBox ControlBox_Home;
        private FlowLayoutPanel FlowPanel_Home_Menu;
        private PictureBox PicBox_Home_Menu;
        private Button btn_Home_Menu1;
        private ReaLTaiizor.Controls.Button btn_Menu_;
        private Panel panel_MenuBlank;
        private Panel HomePanel;
        private Label lbl_DateTime;
        private Label lbl_UserName;
        private Panel Button_Menu_Home;
        private Label Button_Menu_HomeLabel;
        private Panel Button_Menu_Settings;
        private Panel panel9;
        private Label label9;
        private Label Button_Menu_SettingsLabel;
        private Panel Button_Menu_Logout;
        private Panel panel11;
        private Label label10;
        private Label Button_Menu_LogoutLabel;
        private Label lbl_Application_Name;
        private Label lbl_Name2;
        private Label label1;
    }
}
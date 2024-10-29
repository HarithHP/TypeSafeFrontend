using MC_Admin.Manager;
using MC_Admin.Views;

namespace MC_Admin
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadFrames();
            lbl_UserName.Text = ApiManager.UserName.ToString();


            UpdateLabelDateTime();

            // Set up a timer to update the label every second (you can adjust the interval as needed)
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            #region Set Dashboard

            FR_Dashboard.Visible = true;
            FR_Settings.Visible = false;

            #endregion


        }

        public static Settings FR_Settings;
        public static DashBoard FR_Dashboard;

        #region Load All Screens
        void LoadFrames()
        {
            FR_Settings = new Settings();
            //FR_Settings.MdiParent = this;
            FR_Settings.TopLevel = false;
            FR_Settings.FormBorderStyle = FormBorderStyle.None;
            FR_Settings.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(FR_Settings);

            FR_Dashboard = new DashBoard();
            //FR_Dashboard.MdiParent = this;
            FR_Dashboard.TopLevel = false;
            FR_Dashboard.FormBorderStyle = FormBorderStyle.None;
            FR_Dashboard.Dock = DockStyle.Fill;
            HomePanel.Controls.Add(FR_Dashboard);

        }

        #endregion

        #region Live Time
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Call the method to update the label's text with the current date and time
            UpdateLabelDateTime();
        }

        private void UpdateLabelDateTime()
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Update the label's text
            lbl_DateTime.Text = currentDateTime.ToString();
        }

        #endregion

        #region Main Menu Buttons Hovers

        private void Button_Menu_Home_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Home.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_HomeLabel_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Home.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_Home_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Home.BackColor = Color.FromArgb(206, 217, 237);
        }

        private void Button_Menu_HomeLabel_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Home.BackColor = Color.FromArgb(206, 217, 237);
        }

        private void Button_Menu_Settings_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Settings.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_Settings_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Settings.BackColor = Color.FromArgb(206, 217, 237);
        }

        private void Button_Menu_SettingsLabel_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Settings.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_Logout_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Logout.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_Logout_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Logout.BackColor = Color.FromArgb(206, 217, 237);
        }

        private void Button_Menu_LogoutLabel_MouseEnter(object sender, EventArgs e)
        {
            Button_Menu_Logout.BackColor = Color.FromArgb(127, 161, 195);
        }

        private void Button_Menu_SettingsLabel_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Settings.BackColor = Color.FromArgb(206, 217, 237);
        }

        private void Button_Menu_LogoutLabel_MouseLeave(object sender, EventArgs e)
        {
            Button_Menu_Logout.BackColor = Color.FromArgb(206, 217, 237);
        }
        #endregion

        #region Menu Buttons 

        private void Button_Menu_HomeLabel_Click(object sender, EventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(100, 130, 173);  
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(127, 161, 195);
            Button_Menu_Settings.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Logout.BackColor = Color.FromArgb(244, 245, 245);

            FR_Dashboard.Visible = true;
            FR_Settings.Visible = false;
        }

        private void Button_Menu_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(100, 130, 173);
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(127, 161, 195);
            Button_Menu_Settings.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Logout.BackColor = Color.FromArgb(244, 245, 245);

            FR_Dashboard.Visible = true;
            FR_Settings.Visible = false;
        }


        private void Button_Menu_SettingsLabel_Click(object sender, EventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(100, 130, 173);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Settings.BackColor = Color.FromArgb(127, 161, 195);
            Button_Menu_Logout.BackColor = Color.FromArgb(244, 245, 245);

            FR_Dashboard.Visible = false;
            //FR_Settings.GetUserAccountDetails(1, 1000, "", false);
            FR_Settings.Visible = true;

        }

        private void Button_Menu_Settings_MouseClick(object sender, MouseEventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(100, 130, 173);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Settings.BackColor = Color.FromArgb(127, 161, 195);
            Button_Menu_Logout.BackColor = Color.FromArgb(244, 245, 245);

            FR_Dashboard.Visible = false;
            //FR_Settings.GetUserAccountDetails(1, 1000, "", false);
            FR_Settings.Visible = true;
        }

        private void Button_Menu_LogoutLabel_Click(object sender, EventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Settings.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Logout.BackColor = Color.FromArgb(127, 161, 195);

            ApiManager.Instance.SetUserData(0, "", "", "", "", "", "");
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void Button_Menu_Logout_MouseClick(object sender, MouseEventArgs e)
        {
            Button_Menu_HomeLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_SettingsLabel.ForeColor = Color.FromArgb(142, 142, 142);
            Button_Menu_LogoutLabel.ForeColor = Color.FromArgb(142, 142, 142);

            Button_Menu_Home.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Settings.BackColor = Color.FromArgb(244, 245, 245);
            Button_Menu_Logout.BackColor = Color.FromArgb(127, 161, 195);

            ApiManager.Instance.SetUserData(0, "", "", "", "", "", "");
            Login login = new Login();
            this.Close();
            login.Show();
        }

        #endregion

    }
}
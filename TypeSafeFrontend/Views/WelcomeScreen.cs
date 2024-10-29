using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Admin.Views
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
           
            LoadForm2AfterDelay();

        }

        #region Load Login Delay
        private void LoadForm2AfterDelay()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000; // 3 seconds

            // Set up an anonymous method as the event handler for the Tick event
            timer.Tick += (timerSender, timerEventArgs) =>
            {
                // Stop the timer to prevent it from ticking again
                timer.Stop();

                // Open Form2
                Login loginScreen = new Login();
                loginScreen.Show();

                // Close WelcomeScreen if needed
                this.Close();
            };

            // Start the timer
            timer.Start();
        }

        #endregion

    }
}

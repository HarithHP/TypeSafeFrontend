using MC_Admin.Manager;
using MC_Admin.Models;
using MC_Admin.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeSafeFrontend.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MC_Admin.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_Login_Email.Enabled = false;
            txt_Login_password.Enabled = false;
            lbl_Login_forgotPasswordClick.Enabled = false;
            btn_Login_Login.Enabled = false;
            BaseUrl();

        }
        #region Action Events
        private void txt_Login_Uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Login_Uname_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Login_Email.Text.Length != 0)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    txt_Login_password.Focus();
                }
            }
        }

        private void txt_Login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txt_Login_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (String.IsNullOrWhiteSpace(txt_Login_Email.Text))
                {
                    txt_Login_Email.Focus();
                    MessageBox.Show("Please enter the email.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrWhiteSpace(txt_Login_password.Text))
                {
                    txt_Login_password.Focus();
                    MessageBox.Show("Please enter the password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string Email = txt_Login_Email.Text;
                    string Password = txt_Login_password.Text;
                    loginManage(Email, Password);
                }
            }
        }

        private void lbl_Login_forgotPasswordClick_Click(object sender, EventArgs e)
        {
            SignUp m = new SignUp();
            m.Visible = true;
            this.Visible = false;
        }

        private void btn_Login_Login1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Login_Email.Text))
            {
                txt_Login_Email.Focus();
                MessageBox.Show("Please enter the email.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_Login_password.Text))
            {
                txt_Login_password.Focus();
                MessageBox.Show("Please enter the password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Email = txt_Login_Email.Text;
                string Password = txt_Login_password.Text;
                loginManage(Email, Password);
            }
        }

        #endregion

        #region Login Manage
        private async void loginManage(string Email, string Password)
        {
            ModelEmployee modelEmployee = new ModelEmployee();
            modelEmployee.Email = Email;
            modelEmployee.Password = Password;
            AuthService authServices = new AuthService();
            int signInResult = await authServices.ManageSignIn(modelEmployee);
            if (signInResult == 1)
            {
                Home m = new Home();
                m.Visible = true;
                this.Visible = false;
            }
            else if (signInResult == 2)
            {

            }
            else if (signInResult == 3)
            {
                MessageBox.Show("Error! Username or Password Incorrect", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 4)
            {
                MessageBox.Show("Error! You do not have permission to access this Application ", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 5)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 6)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Base URL Check
        void BaseUrl()
        {
            string folderPath = @"C:\APP360\MCAdmin";
            string configFilePath = @"C:\APP360\MCAdmin\config.json";

            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to create folder: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            // Check if config file exists
            if (!File.Exists(configFilePath))
            {
                try
                {
                    // Create JSON object with base_url="" and environment=""
                    JObject config = new JObject();
                    config["base_url"] = "";
                    config["environment"] = "";

                    // Write JSON to file
                    File.WriteAllText(configFilePath, config.ToString());
                    MessageBox.Show("Config file created. Please update the config file and re-start the application.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please contact support Team | Error creating config file: {ex.Message} ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                return;
            }

            try
            {
                // Read JSON file
                string jsonText = File.ReadAllText(configFilePath);

                // Parse JSON
                JObject config = JObject.Parse(jsonText);

                // Check if "base_url" exists and is not empty
                if (config.TryGetValue("base_url", out JToken baseUrlToken) && baseUrlToken.Type == JTokenType.String)
                {
                    string baseUrl = baseUrlToken.ToString();

                    // Check if "environment" exists and is not empty
                    if (config.TryGetValue("environment", out JToken environmentToken) && environmentToken.Type == JTokenType.String)
                    {
                        string environment = environmentToken.ToString();

                        if (!string.IsNullOrEmpty(baseUrl) && !string.IsNullOrEmpty(environment))
                        {
                            //MessageBox.Show("base_url and environment are not empty.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (environment == "Live" || environment == "Development" || environment == "UAT")
                            {
                                ApiManager.Instance.SetEnvironmentAndBaseUrl(environment, baseUrl);
                                txt_Login_Email.Enabled = true;
                                txt_Login_password.Enabled = true;
                                lbl_Login_forgotPasswordClick.Enabled = true;
                                btn_Login_Login.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Application Environment. Please update your config file.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Base url or environment is empty. Please update your config file.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Environment does not exist or is not a string. Please contact support Team", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    MessageBox.Show("Base url does not exist or is not a string. Please contact support Team", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please contact support Team | Error reading config file: {ex.Message}", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        #endregion

        private void btn_Login2_Click(object sender, EventArgs e)
        {
            string Email = "hphadaragama@gmail.com";
            string Password = "aaa";
            loginManage(Email, Password);
        }
    }
}

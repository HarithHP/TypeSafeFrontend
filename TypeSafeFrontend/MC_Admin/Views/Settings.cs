using MC_Admin.Manager;
using MC_Admin.Models;
using MC_Admin.Models.Responses;
using MC_Admin.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Admin.Views
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadAccessToken();
            LoadUserInfo();
            //GetUserAccountDetails(1, 1000, "", false);
        }

        #region Update Employee
        async Task UpdateEmployee()
        {
            ModelEmployee modelEmployee = new ModelEmployee();
            modelEmployee.FirstName = txt_Settings_FirstName.Text;
            modelEmployee.LastName = txt_Settings_LastName.Text;
            modelEmployee.Email = ApiManager.Email;
            modelEmployee.Id = ApiManager.UserId;

            AuthService authServices = new AuthService();
            int signInResult = await authServices.UpdateAccount(modelEmployee);
            if (signInResult == 1)
            {
                MessageBox.Show("Your Account Details Updated Successfully", "Successful! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                modelEmployee.FirstName = txt_Settings_FirstName.Text;
                modelEmployee.LastName = txt_Settings_LastName.Text;

            }
            else if (signInResult == 2)
            {
                MessageBox.Show("Error! Current Id Is Not Match With Your Email Incorrect", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 3)
            {
                MessageBox.Show("Error! You do not have permission to access this Application ", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 4)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 5)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion


        #region Clear Form

        private async void ClearSettingsPasswordUpdate()
        {
            txt_Settings_ConfirmPwd.Text = string.Empty;
            txt_Settings_CurrentPwd.Text = string.Empty;
            txt_Settings_NewPwd.Text = string.Empty;
        }

        private async void ClearSettingsAccountUodate()
        {
            txt_Settings_FirstName.Text = string.Empty;
            txt_Settings_LastName.Text = string.Empty;
        }

        private void btn_figmaToken_Clear_Click(object sender, EventArgs e)
        {
            txt_figmaToken.Text = string.Empty;
        }

        #endregion

        #region Manage Change Password
        private async void ManageChangePassword(ModelChangePassword modelChangePassword)
        {

            AuthService authServices = new AuthService();
            int signInResult = await authServices.ChangePassword(modelChangePassword);
            if (signInResult == 1)
            {
                MessageBox.Show( "Your Password Updated Successfully","Successful! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_Settings_CurrentPwd.Text = string.Empty;
                txt_Settings_NewPwd.Text = string.Empty;
                txt_Settings_ConfirmPwd.Text = string.Empty;

            }
            else if (signInResult == 2)
            {
                MessageBox.Show("Error! Current Password Is Not Match With Your Email Incorrect", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 3)
            {
                MessageBox.Show("Error! You do not have permission to access this Application ", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 4)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signInResult == 5)
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error! Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Action Events

        private void btn_figmaToken_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_figmaToken.Text))
            {
                txt_figmaToken.Focus();
                MessageBox.Show("Please enter the figma token.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadAccessToken();
            }
            else
            {
                checkCreateFigmaJson(txt_figmaToken.Text.ToString());
            }

        }
        private void hopeRichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void hopeRichTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void hopeRichTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void hopeRichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Settings_CurrentPwd.Text.Length != 0)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    txt_Settings_NewPwd.Focus();
                }
            }
        }

        private void txt_Settings_NewPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_Settings_NewPwd.Text.Length != 0)
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    txt_Settings_ConfirmPwd.Focus();
                }
            }
        }

        private void txt_Settings_ConfirmPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (String.IsNullOrWhiteSpace(txt_Settings_CurrentPwd.Text) || txt_Settings_CurrentPwd.Text.Length < 3)
                {
                    txt_Settings_CurrentPwd.Focus();
                    MessageBox.Show("Please enter the valid current password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrWhiteSpace(txt_Settings_NewPwd.Text) || txt_Settings_NewPwd.Text.Length < 3)
                {
                    txt_Settings_NewPwd.Focus();
                    MessageBox.Show("Please enter a valid new password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (String.IsNullOrWhiteSpace(txt_Settings_ConfirmPwd.Text) || txt_Settings_ConfirmPwd.Text.Length < 3)
                {
                    txt_Settings_ConfirmPwd.Focus();
                    MessageBox.Show("Please confirm the new password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Settings_NewPwd.Text != txt_Settings_ConfirmPwd.Text)
                {
                    MessageBox.Show("New password confirmation failed,Please re-check your inputs.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ModelChangePassword modelChangePassword = new ModelChangePassword();
                    modelChangePassword.NewPassword = txt_Settings_NewPwd.Text;
                    modelChangePassword.OldPassword = txt_Settings_CurrentPwd.Text;
                    modelChangePassword.UserEmail = ApiManager.Email;

                    ManageChangePassword(modelChangePassword);
                }
            }
        }

        private void btn_Settings_Submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Settings_CurrentPwd.Text) || txt_Settings_CurrentPwd.Text.Length < 3)
            {
                txt_Settings_CurrentPwd.Focus();
                MessageBox.Show("Please enter the valid current password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_Settings_NewPwd.Text) || txt_Settings_NewPwd.Text.Length < 3)
            {
                txt_Settings_NewPwd.Focus();
                MessageBox.Show("Please enter a valid new password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_Settings_ConfirmPwd.Text) || txt_Settings_ConfirmPwd.Text.Length < 3)
            {
                txt_Settings_ConfirmPwd.Focus();
                MessageBox.Show("Please confirm the new password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Settings_NewPwd.Text != txt_Settings_ConfirmPwd.Text)
            {
                MessageBox.Show("New password confirmation failed,Please re-check your inputs.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModelChangePassword modelChangePassword = new ModelChangePassword();
                modelChangePassword.NewPassword = txt_Settings_NewPwd.Text;
                modelChangePassword.OldPassword = txt_Settings_CurrentPwd.Text;
                modelChangePassword.UserEmail = ApiManager.Email;

                ManageChangePassword(modelChangePassword);
            }
        }

        private void btn_Settings_Clear_Click(object sender, EventArgs e)
        {
            ClearSettingsAccountUodate();
        }

        private void btn_Settings_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ApiManager.UserId.ToString()))
            {
                MessageBox.Show("Something went wrong | User Id Missing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Settings_FirstName.Text) || (txt_Settings_FirstName.Text).Length < 3)
            {
                MessageBox.Show("Error! Please enter a valid first Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txt_Settings_LastName.Text) || (txt_Settings_FirstName.Text).Length < 3)
            {
                MessageBox.Show("Error! Please enter a valid last Name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateEmployee();
            }
        }

        private void btn_Settings_Clear1_Click(object sender, EventArgs e)
        {
            ClearSettingsPasswordUpdate();
        }

        #endregion

        #region Load Access Token from Figma
        private void LoadAccessToken()
        {
            string folderPath = @"C:\TypeSafe";
            string jsonFilePath = Path.Combine(folderPath, "FigmaToken.json");

            // Ensure the folder and file exist
            if (Directory.Exists(folderPath) && File.Exists(jsonFilePath))
            {
                try
                {
                    JObject jsonObject = JObject.Parse(File.ReadAllText(jsonFilePath));

                    // Check if accessToken exists in the JSON
                    JToken accessTokenToken = jsonObject["accessToken"];
                    if (accessTokenToken != null)
                    {
                        string accessToken = accessTokenToken.ToString();
                        txt_figmaToken.Text = accessToken.ToString();
                    }
                    else
                    {
                        txt_figmaToken.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Error reading accessToken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Error reading accessToken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Write Access Token for Figma
        static void CreateJsonFile(string jsonFilePath)
        {
            // Create an empty JSON object with accessToken set to null
            JObject jsonObject = new JObject
            {
                ["accessToken"] = null
            };
            File.WriteAllText(jsonFilePath, jsonObject.ToString());
        }

        public void checkCreateFigmaJson(string accessToken)
        {
            string folderPath = @"C:\TypeSafe";
            string jsonFilePath = Path.Combine(folderPath, "FigmaToken.json");

            // Check if the folder exists
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Check if the JSON file exists
            if (!File.Exists(jsonFilePath))
            {
                CreateJsonFile(jsonFilePath);
            }

            // Check if the JSON file contains the accessToken field
            JObject jsonObject = JObject.Parse(File.ReadAllText(jsonFilePath));
            if (jsonObject["accessToken"] == null)
            {
                jsonObject["accessToken"] = accessToken;
                File.WriteAllText(jsonFilePath, jsonObject.ToString());
            }
            else
            {
                jsonObject["accessToken"] = accessToken;
                File.WriteAllText(jsonFilePath, jsonObject.ToString());
            }

            LoadAccessToken();

        }

        #endregion

        #region Load User Info
        private void LoadUserInfo()
        {
            txt_Settings_FirstName.Text  = ApiManager.UserName;
            txt_Settings_LastName.Text = ApiManager.Lastname;

        }

        #endregion




    }
}

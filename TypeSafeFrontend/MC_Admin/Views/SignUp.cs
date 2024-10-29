using MC_Admin.Models;
using MC_Admin.Services;
using MC_Admin;
using MC_Admin.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeSafeFrontend.Models;

namespace TypeSafeFrontend.Views
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            txt_FirstName.Focus();
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Visible = true;
            this.Visible = false;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txt_FirstName.Text))
            {
                txt_FirstName.Focus();
                MessageBox.Show("Please enter the first name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_LastName.Text))
            {
                txt_LastName.Focus();
                MessageBox.Show("Please enter the last name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_ContactNumber.Text))
            {
                txt_ContactNumber.Focus();
                MessageBox.Show("Please enter the contact number.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_Email.Text))
            {
                txt_Email.Focus();
                MessageBox.Show("Please enter the email.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txt_Password.Text))
            {
                txt_Password.Focus();
                MessageBox.Show("Please enter the password.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModelUser modelUser = new ModelUser();
                modelUser.FirstName = txt_FirstName.Text;
                modelUser.LastName = txt_LastName.Text;
                modelUser.ContactNumber = txt_ContactNumber.Text;
                modelUser.Email = txt_Email.Text;
                modelUser.Password = txt_Password.Text;
                modelUser.UserStatus = "Active";
                SignUpProcess(modelUser);
            }
        }

        #region  Sign Up
        private async void SignUpProcess (ModelUser model)
        {
            AuthService authServices = new AuthService();
            int signInResult = await authServices.ManageSignUp(model);
            if (signInResult == 1)
            {
                MessageBox.Show("Success! Your account created successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login m = new Login();
                m.Visible = true;
                this.Visible = false;
            }
            else if (signInResult == 3)
            {
                MessageBox.Show("Error! Please re-check your inputs", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

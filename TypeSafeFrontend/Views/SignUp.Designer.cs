namespace TypeSafeFrontend.Views
{
    partial class SignUp
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
            pictureBox3 = new PictureBox();
            label_DescriptionTitle = new Label();
            lbl_LastName = new Label();
            lbl_FirstName = new Label();
            btn_SignUp = new ReaLTaiizor.Controls.Button();
            lbl_Login = new Label();
            pictureBox_sub_logo = new PictureBox();
            txt_FirstName = new ReaLTaiizor.Controls.HopeTextBox();
            txt_LastName = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_already = new Label();
            lbl_Login_welcomeDescription = new Label();
            lbl_ContactNumber = new Label();
            lbl_Email = new Label();
            txt_Email = new ReaLTaiizor.Controls.HopeTextBox();
            txt_ContactNumber = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_Password = new Label();
            txt_Password = new ReaLTaiizor.Controls.HopeTextBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_Login_welcomeDescription2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sub_logo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.Signup;
            pictureBox3.Location = new Point(-4, -7);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(639, 720);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label_DescriptionTitle
            // 
            label_DescriptionTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_DescriptionTitle.AutoSize = true;
            label_DescriptionTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_DescriptionTitle.ForeColor = Color.FromArgb(52, 58, 64);
            label_DescriptionTitle.Location = new Point(775, 113);
            label_DescriptionTitle.Name = "label_DescriptionTitle";
            label_DescriptionTitle.Size = new Size(91, 30);
            label_DescriptionTitle.TabIndex = 32;
            label_DescriptionTitle.Text = "Sign Up";
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Cursor = Cursors.Hand;
            lbl_LastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_LastName.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_LastName.Location = new Point(771, 293);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(63, 15);
            lbl_LastName.TabIndex = 31;
            lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Cursor = Cursors.Hand;
            lbl_FirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_FirstName.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_FirstName.Location = new Point(770, 236);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(64, 15);
            lbl_FirstName.TabIndex = 30;
            lbl_FirstName.Text = "First Name";
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.Transparent;
            btn_SignUp.BorderColor = Color.FromArgb(32, 34, 37);
            btn_SignUp.EnteredBorderColor = Color.FromArgb(100, 130, 173);
            btn_SignUp.EnteredColor = Color.FromArgb(51, 52, 55);
            btn_SignUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SignUp.Image = null;
            btn_SignUp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SignUp.InactiveColor = Color.FromArgb(51, 52, 55);
            btn_SignUp.Location = new Point(771, 587);
            btn_SignUp.Margin = new Padding(3, 2, 3, 2);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.PressedBorderColor = Color.FromArgb(100, 130, 173);
            btn_SignUp.PressedColor = Color.FromArgb(100, 130, 173);
            btn_SignUp.Size = new Size(365, 38);
            btn_SignUp.TabIndex = 29;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.TextAlignment = StringAlignment.Center;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Cursor = Cursors.Hand;
            lbl_Login.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_Login.Location = new Point(904, 553);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(38, 13);
            lbl_Login.TabIndex = 28;
            lbl_Login.Text = "Log in";
            lbl_Login.Click += lbl_Login_Click;
            // 
            // pictureBox_sub_logo
            // 
            pictureBox_sub_logo.BackColor = Color.Transparent;
            pictureBox_sub_logo.Image = Properties.Resources.TypeSafe_Logo;
            pictureBox_sub_logo.Location = new Point(650, 11);
            pictureBox_sub_logo.Margin = new Padding(3, 2, 3, 2);
            pictureBox_sub_logo.Name = "pictureBox_sub_logo";
            pictureBox_sub_logo.Size = new Size(98, 85);
            pictureBox_sub_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_sub_logo.TabIndex = 27;
            pictureBox_sub_logo.TabStop = false;
            // 
            // txt_FirstName
            // 
            txt_FirstName.BackColor = Color.FromArgb(238, 238, 238);
            txt_FirstName.BaseColor = Color.FromArgb(238, 238, 238);
            txt_FirstName.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_FirstName.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_FirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_FirstName.ForeColor = Color.FromArgb(142, 142, 142);
            txt_FirstName.Hint = "";
            txt_FirstName.Location = new Point(771, 256);
            txt_FirstName.Margin = new Padding(3, 2, 3, 2);
            txt_FirstName.MaxLength = 32767;
            txt_FirstName.Multiline = false;
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.PasswordChar = '\0';
            txt_FirstName.ScrollBars = ScrollBars.None;
            txt_FirstName.SelectedText = "";
            txt_FirstName.SelectionLength = 0;
            txt_FirstName.SelectionStart = 0;
            txt_FirstName.Size = new Size(364, 32);
            txt_FirstName.TabIndex = 26;
            txt_FirstName.TabStop = false;
            txt_FirstName.UseSystemPasswordChar = false;
            // 
            // txt_LastName
            // 
            txt_LastName.BackColor = Color.FromArgb(238, 238, 238);
            txt_LastName.BaseColor = Color.FromArgb(238, 238, 238);
            txt_LastName.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_LastName.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_LastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_LastName.ForeColor = Color.FromArgb(142, 142, 142);
            txt_LastName.Hint = "";
            txt_LastName.Location = new Point(771, 310);
            txt_LastName.Margin = new Padding(3, 2, 3, 2);
            txt_LastName.MaxLength = 32767;
            txt_LastName.Multiline = false;
            txt_LastName.Name = "txt_LastName";
            txt_LastName.PasswordChar = '\0';
            txt_LastName.ScrollBars = ScrollBars.None;
            txt_LastName.SelectedText = "";
            txt_LastName.SelectionLength = 0;
            txt_LastName.SelectionStart = 0;
            txt_LastName.Size = new Size(364, 32);
            txt_LastName.TabIndex = 25;
            txt_LastName.TabStop = false;
            txt_LastName.UseSystemPasswordChar = false;
            // 
            // lbl_already
            // 
            lbl_already.AutoSize = true;
            lbl_already.Cursor = Cursors.Hand;
            lbl_already.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_already.ForeColor = Color.FromArgb(52, 58, 64);
            lbl_already.Location = new Point(769, 553);
            lbl_already.Name = "lbl_already";
            lbl_already.Size = new Size(133, 13);
            lbl_already.TabIndex = 23;
            lbl_already.Text = "Already have an account?";
            // 
            // lbl_Login_welcomeDescription
            // 
            lbl_Login_welcomeDescription.AutoSize = true;
            lbl_Login_welcomeDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Login_welcomeDescription.ForeColor = Color.FromArgb(52, 58, 64);
            lbl_Login_welcomeDescription.Location = new Point(769, 167);
            lbl_Login_welcomeDescription.Name = "lbl_Login_welcomeDescription";
            lbl_Login_welcomeDescription.Size = new Size(393, 19);
            lbl_Login_welcomeDescription.TabIndex = 24;
            lbl_Login_welcomeDescription.Text = "Let's get started.Are you ready to be a part of something new?";
            // 
            // lbl_ContactNumber
            // 
            lbl_ContactNumber.AutoSize = true;
            lbl_ContactNumber.Cursor = Cursors.Hand;
            lbl_ContactNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ContactNumber.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_ContactNumber.Location = new Point(771, 413);
            lbl_ContactNumber.Name = "lbl_ContactNumber";
            lbl_ContactNumber.Size = new Size(95, 15);
            lbl_ContactNumber.TabIndex = 36;
            lbl_ContactNumber.Text = "Contact Number";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Cursor = Cursors.Hand;
            lbl_Email.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Email.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_Email.Location = new Point(770, 353);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(81, 15);
            lbl_Email.TabIndex = 35;
            lbl_Email.Text = "Email Address";
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.FromArgb(238, 238, 238);
            txt_Email.BaseColor = Color.FromArgb(238, 238, 238);
            txt_Email.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_Email.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_Email.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Email.ForeColor = Color.FromArgb(142, 142, 142);
            txt_Email.Hint = "";
            txt_Email.Location = new Point(771, 373);
            txt_Email.Margin = new Padding(3, 2, 3, 2);
            txt_Email.MaxLength = 32767;
            txt_Email.Multiline = false;
            txt_Email.Name = "txt_Email";
            txt_Email.PasswordChar = '\0';
            txt_Email.ScrollBars = ScrollBars.None;
            txt_Email.SelectedText = "";
            txt_Email.SelectionLength = 0;
            txt_Email.SelectionStart = 0;
            txt_Email.Size = new Size(364, 32);
            txt_Email.TabIndex = 34;
            txt_Email.TabStop = false;
            txt_Email.UseSystemPasswordChar = false;
            // 
            // txt_ContactNumber
            // 
            txt_ContactNumber.BackColor = Color.FromArgb(238, 238, 238);
            txt_ContactNumber.BaseColor = Color.FromArgb(238, 238, 238);
            txt_ContactNumber.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_ContactNumber.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_ContactNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ContactNumber.ForeColor = Color.FromArgb(142, 142, 142);
            txt_ContactNumber.Hint = "";
            txt_ContactNumber.Location = new Point(771, 430);
            txt_ContactNumber.Margin = new Padding(3, 2, 3, 2);
            txt_ContactNumber.MaxLength = 32767;
            txt_ContactNumber.Multiline = false;
            txt_ContactNumber.Name = "txt_ContactNumber";
            txt_ContactNumber.PasswordChar = '\0';
            txt_ContactNumber.ScrollBars = ScrollBars.None;
            txt_ContactNumber.SelectedText = "";
            txt_ContactNumber.SelectionLength = 0;
            txt_ContactNumber.SelectionStart = 0;
            txt_ContactNumber.Size = new Size(364, 32);
            txt_ContactNumber.TabIndex = 33;
            txt_ContactNumber.TabStop = false;
            txt_ContactNumber.UseSystemPasswordChar = false;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Cursor = Cursors.Hand;
            lbl_Password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Password.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_Password.Location = new Point(772, 472);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 38;
            lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.FromArgb(238, 238, 238);
            txt_Password.BaseColor = Color.FromArgb(238, 238, 238);
            txt_Password.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_Password.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_Password.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.FromArgb(142, 142, 142);
            txt_Password.Hint = "";
            txt_Password.Location = new Point(772, 489);
            txt_Password.Margin = new Padding(3, 2, 3, 2);
            txt_Password.MaxLength = 32767;
            txt_Password.Multiline = false;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.ScrollBars = ScrollBars.None;
            txt_Password.SelectedText = "";
            txt_Password.SelectionLength = 0;
            txt_Password.SelectionStart = 0;
            txt_Password.Size = new Size(364, 32);
            txt_Password.TabIndex = 37;
            txt_Password.TabStop = false;
            txt_Password.UseSystemPasswordChar = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = SystemColors.Window;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1123, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 39;
            // 
            // lbl_Login_welcomeDescription2
            // 
            lbl_Login_welcomeDescription2.AutoSize = true;
            lbl_Login_welcomeDescription2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Login_welcomeDescription2.ForeColor = Color.FromArgb(52, 58, 64);
            lbl_Login_welcomeDescription2.Location = new Point(769, 186);
            lbl_Login_welcomeDescription2.Name = "lbl_Login_welcomeDescription2";
            lbl_Login_welcomeDescription2.Size = new Size(217, 19);
            lbl_Login_welcomeDescription2.TabIndex = 40;
            lbl_Login_welcomeDescription2.Text = "Then boldy move forward with us.";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(lbl_Login_welcomeDescription2);
            Controls.Add(nightControlBox1);
            Controls.Add(lbl_Password);
            Controls.Add(txt_Password);
            Controls.Add(lbl_ContactNumber);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Email);
            Controls.Add(txt_ContactNumber);
            Controls.Add(label_DescriptionTitle);
            Controls.Add(lbl_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(btn_SignUp);
            Controls.Add(lbl_Login);
            Controls.Add(pictureBox_sub_logo);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_LastName);
            Controls.Add(lbl_already);
            Controls.Add(lbl_Login_welcomeDescription);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1680, 765);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sub_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Label label_DescriptionTitle;
        private Label lbl_LastName;
        private Label lbl_FirstName;
        private ReaLTaiizor.Controls.Button btn_SignUp;
        private Label lbl_Login;
        private PictureBox pictureBox_sub_logo;
        private ReaLTaiizor.Controls.HopeTextBox txt_FirstName;
        private ReaLTaiizor.Controls.HopeTextBox txt_LastName;
        private Label lbl_already;
        private Label lbl_Login_welcomeDescription;
        private Label lbl_ContactNumber;
        private Label lbl_Email;
        private ReaLTaiizor.Controls.HopeTextBox txt_Email;
        private ReaLTaiizor.Controls.HopeTextBox txt_ContactNumber;
        private Label lbl_Password;
        private ReaLTaiizor.Controls.HopeTextBox txt_Password;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label lbl_Login_welcomeDescription2;
    }
}
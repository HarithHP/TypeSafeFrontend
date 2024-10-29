namespace MC_Admin.Views
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            pictureBox_sub_logo = new PictureBox();
            PicBox_Home_Logo2 = new PictureBox();
            label_welcomeTitle1 = new Label();
            label_welcomeTitle2 = new Label();
            label_welcomeDescription = new Label();
            label_version = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_sub_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicBox_Home_Logo2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_sub_logo
            // 
            pictureBox_sub_logo.BackColor = Color.White;
            pictureBox_sub_logo.Image = TypeSafeFrontend.Properties.Resources.T_Logo;
            pictureBox_sub_logo.Location = new Point(34, 11);
            pictureBox_sub_logo.Margin = new Padding(3, 2, 3, 2);
            pictureBox_sub_logo.Name = "pictureBox_sub_logo";
            pictureBox_sub_logo.Size = new Size(63, 66);
            pictureBox_sub_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_sub_logo.TabIndex = 5;
            pictureBox_sub_logo.TabStop = false;
            // 
            // PicBox_Home_Logo2
            // 
            PicBox_Home_Logo2.Dock = DockStyle.Fill;
            PicBox_Home_Logo2.Image = (Image)resources.GetObject("PicBox_Home_Logo2.Image");
            PicBox_Home_Logo2.Location = new Point(0, 0);
            PicBox_Home_Logo2.Margin = new Padding(3, 2, 3, 2);
            PicBox_Home_Logo2.Name = "PicBox_Home_Logo2";
            PicBox_Home_Logo2.Size = new Size(1280, 720);
            PicBox_Home_Logo2.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_Home_Logo2.TabIndex = 3;
            PicBox_Home_Logo2.TabStop = false;
            // 
            // label_welcomeTitle1
            // 
            label_welcomeTitle1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_welcomeTitle1.AutoSize = true;
            label_welcomeTitle1.BackColor = Color.White;
            label_welcomeTitle1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcomeTitle1.Location = new Point(18, 61);
            label_welcomeTitle1.Name = "label_welcomeTitle1";
            label_welcomeTitle1.Size = new Size(416, 86);
            label_welcomeTitle1.TabIndex = 7;
            label_welcomeTitle1.Text = "Welcome to ";
            // 
            // label_welcomeTitle2
            // 
            label_welcomeTitle2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_welcomeTitle2.AutoSize = true;
            label_welcomeTitle2.BackColor = Color.Transparent;
            label_welcomeTitle2.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_welcomeTitle2.Location = new Point(24, 139);
            label_welcomeTitle2.Name = "label_welcomeTitle2";
            label_welcomeTitle2.Size = new Size(177, 51);
            label_welcomeTitle2.TabIndex = 8;
            label_welcomeTitle2.Text = "TypeSafe";
            // 
            // label_welcomeDescription
            // 
            label_welcomeDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_welcomeDescription.AutoSize = true;
            label_welcomeDescription.BackColor = Color.Transparent;
            label_welcomeDescription.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_welcomeDescription.Location = new Point(34, 199);
            label_welcomeDescription.Name = "label_welcomeDescription";
            label_welcomeDescription.Size = new Size(206, 21);
            label_welcomeDescription.TabIndex = 9;
            label_welcomeDescription.Text = "Login to access your account";
            // 
            // label_version
            // 
            label_version.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_version.AutoSize = true;
            label_version.BackColor = Color.Transparent;
            label_version.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_version.Location = new Point(18, 696);
            label_version.Name = "label_version";
            label_version.Size = new Size(74, 19);
            label_version.TabIndex = 10;
            label_version.Text = "Version  0.1";
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(label_version);
            Controls.Add(label_welcomeDescription);
            Controls.Add(label_welcomeTitle2);
            Controls.Add(label_welcomeTitle1);
            Controls.Add(pictureBox_sub_logo);
            Controls.Add(PicBox_Home_Logo2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeScreen";
            Load += WelcomeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_sub_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicBox_Home_Logo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_sub_logo;
        private PictureBox PicBox_Home_Logo2;
        private Label label_welcomeTitle1;
        private Label label_welcomeTitle2;
        private Label label_welcomeDescription;
        private Label label_version;
    }
}
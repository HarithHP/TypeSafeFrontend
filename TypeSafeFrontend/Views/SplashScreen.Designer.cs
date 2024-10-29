namespace MC_Admin.Views
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            splashTimer = new System.Windows.Forms.Timer(components);
            aloneProgressBar = new ReaLTaiizor.Controls.AloneProgressBar();
            pictureBox_MainLogo = new PictureBox();
            MainPanel = new Panel();
            label_Description = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_MainLogo).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splashTimer
            // 
            splashTimer.Tick += splashTimer_Tick;
            // 
            // aloneProgressBar
            // 
            aloneProgressBar.BackColor = SystemColors.Control;
            aloneProgressBar.BackgroundColor = Color.FromArgb(100, 130, 173);
            aloneProgressBar.BorderColor = SystemColors.Control;
            aloneProgressBar.Location = new Point(150, 254);
            aloneProgressBar.Margin = new Padding(3, 2, 3, 2);
            aloneProgressBar.Maximum = 100;
            aloneProgressBar.Minimum = 0;
            aloneProgressBar.Name = "aloneProgressBar";
            aloneProgressBar.Size = new Size(416, 22);
            aloneProgressBar.Stripes = Color.FromArgb(100, 130, 173);
            aloneProgressBar.TabIndex = 1;
            aloneProgressBar.Text = "aloneProgressBar";
            aloneProgressBar.Value = 70;
            // 
            // pictureBox_MainLogo
            // 
            pictureBox_MainLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_MainLogo.Image = (Image)resources.GetObject("pictureBox_MainLogo.Image");
            pictureBox_MainLogo.Location = new Point(226, 33);
            pictureBox_MainLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBox_MainLogo.Name = "pictureBox_MainLogo";
            pictureBox_MainLogo.Size = new Size(268, 217);
            pictureBox_MainLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_MainLogo.TabIndex = 2;
            pictureBox_MainLogo.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(label_Description);
            MainPanel.Controls.Add(pictureBox_MainLogo);
            MainPanel.Controls.Add(aloneProgressBar);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(700, 338);
            MainPanel.TabIndex = 3;
            // 
            // label_Description
            // 
            label_Description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_Description.AutoSize = true;
            label_Description.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_Description.ForeColor = Color.FromArgb(142, 142, 142);
            label_Description.Location = new Point(148, 217);
            label_Description.Name = "label_Description";
            label_Description.Size = new Size(416, 19);
            label_Description.TabIndex = 5;
            label_Description.Text = "Empowering designers with insights to create fear-free experiences";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 245, 245);
            ClientSize = new Size(700, 338);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_MainLogo).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer splashTimer;
        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar;
        private PictureBox pictureBox_MainLogo;
        private Panel MainPanel;
        private Label label_Description;
    }
}
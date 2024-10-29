namespace MC_Admin.Views
{
    partial class DashBoard
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
            panel_Main = new Panel();
            btn_Refresh = new Button();
            panel = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Tiltle = new Label();
            pictureBox_SettingsIcon = new PictureBox();
            btn_AddDesign = new Button();
            btn_SearchDesign = new Button();
            txt_SearchDesignName = new ReaLTaiizor.Controls.HopeRichTextBox();
            lbl_WelcomeDescription = new Label();
            pictureBox_logo = new PictureBox();
            panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SettingsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // panel_Main
            // 
            panel_Main.Controls.Add(btn_Refresh);
            panel_Main.Controls.Add(panel);
            panel_Main.Controls.Add(pictureBox2);
            panel_Main.Controls.Add(pictureBox1);
            panel_Main.Controls.Add(lbl_Tiltle);
            panel_Main.Controls.Add(pictureBox_SettingsIcon);
            panel_Main.Controls.Add(btn_AddDesign);
            panel_Main.Controls.Add(btn_SearchDesign);
            panel_Main.Controls.Add(txt_SearchDesignName);
            panel_Main.Controls.Add(lbl_WelcomeDescription);
            panel_Main.Controls.Add(pictureBox_logo);
            panel_Main.Dock = DockStyle.Fill;
            panel_Main.Location = new Point(0, 0);
            panel_Main.Margin = new Padding(3, 2, 3, 2);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1641, 987);
            panel_Main.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = Color.Transparent;
            btn_Refresh.BackgroundImage = TypeSafeFrontend.Properties.Resources.icons8_refresh_50;
            btn_Refresh.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Refresh.Location = new Point(699, 119);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(38, 38);
            btn_Refresh.TabIndex = 46;
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(244, 246, 255);
            panel.Location = new Point(142, 179);
            panel.Name = "panel";
            panel.Size = new Size(1368, 808);
            panel.TabIndex = 42;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = TypeSafeFrontend.Properties.Resources.Frame_23;
            pictureBox2.ImeMode = ImeMode.NoControl;
            pictureBox2.Location = new Point(1482, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = TypeSafeFrontend.Properties.Resources.Frame_25;
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(0, 805);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // lbl_Tiltle
            // 
            lbl_Tiltle.AutoSize = true;
            lbl_Tiltle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tiltle.ForeColor = Color.FromArgb(51, 52, 55);
            lbl_Tiltle.Location = new Point(51, 17);
            lbl_Tiltle.Name = "lbl_Tiltle";
            lbl_Tiltle.Size = new Size(98, 21);
            lbl_Tiltle.TabIndex = 39;
            lbl_Tiltle.Text = "My Designs";
            // 
            // pictureBox_SettingsIcon
            // 
            pictureBox_SettingsIcon.Image = TypeSafeFrontend.Properties.Resources.DesignArt;
            pictureBox_SettingsIcon.Location = new Point(10, 9);
            pictureBox_SettingsIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBox_SettingsIcon.Name = "pictureBox_SettingsIcon";
            pictureBox_SettingsIcon.Size = new Size(37, 32);
            pictureBox_SettingsIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SettingsIcon.TabIndex = 38;
            pictureBox_SettingsIcon.TabStop = false;
            // 
            // btn_AddDesign
            // 
            btn_AddDesign.BackColor = Color.Transparent;
            btn_AddDesign.BackgroundImage = TypeSafeFrontend.Properties.Resources.addIcons;
            btn_AddDesign.BackgroundImageLayout = ImageLayout.Stretch;
            btn_AddDesign.Location = new Point(743, 119);
            btn_AddDesign.Name = "btn_AddDesign";
            btn_AddDesign.Size = new Size(38, 38);
            btn_AddDesign.TabIndex = 37;
            btn_AddDesign.UseVisualStyleBackColor = false;
            btn_AddDesign.Click += btn_AddDesign_Click;
            // 
            // btn_SearchDesign
            // 
            btn_SearchDesign.BackColor = Color.Transparent;
            btn_SearchDesign.BackgroundImage = TypeSafeFrontend.Properties.Resources.searchIcons;
            btn_SearchDesign.BackgroundImageLayout = ImageLayout.Stretch;
            btn_SearchDesign.Location = new Point(655, 118);
            btn_SearchDesign.Name = "btn_SearchDesign";
            btn_SearchDesign.Size = new Size(38, 38);
            btn_SearchDesign.TabIndex = 36;
            btn_SearchDesign.UseVisualStyleBackColor = false;
            btn_SearchDesign.Click += btn_SearchDesign_Click;
            // 
            // txt_SearchDesignName
            // 
            txt_SearchDesignName.BorderColor = Color.FromArgb(142, 142, 142);
            txt_SearchDesignName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_SearchDesignName.ForeColor = Color.FromArgb(142, 142, 142);
            txt_SearchDesignName.Hint = "Search Designs by Name";
            txt_SearchDesignName.HoverBorderColor = Color.FromArgb(100, 130, 173);
            txt_SearchDesignName.Location = new Point(142, 119);
            txt_SearchDesignName.Margin = new Padding(3, 2, 3, 2);
            txt_SearchDesignName.MaxLength = 32767;
            txt_SearchDesignName.Multiline = true;
            txt_SearchDesignName.Name = "txt_SearchDesignName";
            txt_SearchDesignName.PasswordChar = '\0';
            txt_SearchDesignName.ScrollBars = ScrollBars.None;
            txt_SearchDesignName.SelectedText = "";
            txt_SearchDesignName.SelectionLength = 0;
            txt_SearchDesignName.SelectionStart = 0;
            txt_SearchDesignName.Size = new Size(507, 37);
            txt_SearchDesignName.TabIndex = 29;
            txt_SearchDesignName.TabStop = false;
            txt_SearchDesignName.Text = "Search Designs by Name";
            txt_SearchDesignName.UseSystemPasswordChar = false;
            txt_SearchDesignName.Click += txt_SearchDesignName_Click;
            txt_SearchDesignName.MouseClick += txt_SearchDesignName_MouseClick;
            // 
            // lbl_WelcomeDescription
            // 
            lbl_WelcomeDescription.AutoSize = true;
            lbl_WelcomeDescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_WelcomeDescription.ForeColor = Color.FromArgb(52, 58, 64);
            lbl_WelcomeDescription.Location = new Point(142, 74);
            lbl_WelcomeDescription.Name = "lbl_WelcomeDescription";
            lbl_WelcomeDescription.Size = new Size(257, 32);
            lbl_WelcomeDescription.TabIndex = 19;
            lbl_WelcomeDescription.Text = "Welcome to Typesafe";
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.BackColor = Color.Transparent;
            pictureBox_logo.Location = new Point(66, 9);
            pictureBox_logo.Margin = new Padding(3, 2, 3, 2);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(190, 35);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_logo.TabIndex = 18;
            pictureBox_logo.TabStop = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1641, 987);
            Controls.Add(panel_Main);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashBoard";
            Text = "DashBoard";
            panel_Main.ResumeLayout(false);
            panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SettingsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Main;
        private PictureBox pictureBox_logo;
        private Label lbl_WelcomeDescription;
        private ReaLTaiizor.Controls.HopeRichTextBox txt_SearchDesignName;
        private Button btn_SearchDesign;
        private Button btn_AddDesign;
        private Label lbl_Tiltle;
        private PictureBox pictureBox_SettingsIcon;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel;
        private Button btn_Refresh;
    }
}
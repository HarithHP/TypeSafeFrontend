namespace TypeSafeFrontend.Views
{
    partial class DesignHomeCard2
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
            pictureBox = new PictureBox();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Image = Properties.Resources.Login_Screen2;
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(230, 282);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // labelName
            // 
            labelName.AccessibleRole = AccessibleRole.None;
            labelName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(0, 297);
            labelName.Name = "labelName";
            labelName.Size = new Size(254, 21);
            labelName.TabIndex = 3;
            labelName.Text = "Design Name";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            labelName.Click += label_Click;
            // 
            // DesignHomeCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(254, 321);
            Controls.Add(labelName);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "DesignHomeCard";
            SizeGripStyle = SizeGripStyle.Hide;
            Load += DesignHomeCard2_Load;
            MouseClick += DesignHomeCard2_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox;
        private Label labelName;
        private ReaLTaiizor.Controls.Panel panel1;
    }
}
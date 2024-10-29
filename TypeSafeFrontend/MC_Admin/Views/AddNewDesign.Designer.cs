namespace TypeSafeFrontend.Views
{
    partial class AddNewDesign
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            MainPanel = new Panel();
            pictureBox_Loading = new PictureBox();
            btn_FigmaUpload = new ReaLTaiizor.Controls.Button();
            DataGridView_ImagesList = new ReaLTaiizor.Controls.PoisonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewImageColumn();
            lbl_close = new Label();
            btn_Clear = new ReaLTaiizor.Controls.Button();
            btn_Save_Designs = new ReaLTaiizor.Controls.Button();
            lbl_imagesList = new Label();
            lbl_Upload = new Label();
            label1 = new Label();
            txt_figmaLink = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox2 = new PictureBox();
            lbl_DesignName = new Label();
            txt_DesignName = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox = new PictureBox();
            lbl_Tiltle = new Label();
            pictureBox_SettingsIcon = new PictureBox();
            pictureBox_Bottom = new PictureBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_ImagesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SettingsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bottom).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(pictureBox_Loading);
            MainPanel.Controls.Add(btn_FigmaUpload);
            MainPanel.Controls.Add(DataGridView_ImagesList);
            MainPanel.Controls.Add(lbl_close);
            MainPanel.Controls.Add(btn_Clear);
            MainPanel.Controls.Add(btn_Save_Designs);
            MainPanel.Controls.Add(lbl_imagesList);
            MainPanel.Controls.Add(lbl_Upload);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(txt_figmaLink);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(lbl_DesignName);
            MainPanel.Controls.Add(txt_DesignName);
            MainPanel.Controls.Add(pictureBox);
            MainPanel.Controls.Add(lbl_Tiltle);
            MainPanel.Controls.Add(pictureBox_SettingsIcon);
            MainPanel.Controls.Add(pictureBox_Bottom);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(764, 917);
            MainPanel.TabIndex = 0;
            // 
            // pictureBox_Loading
            // 
            pictureBox_Loading.BackColor = Color.Transparent;
            pictureBox_Loading.Image = Properties.Resources.icons8_loading1;
            pictureBox_Loading.Location = new Point(345, 452);
            pictureBox_Loading.Name = "pictureBox_Loading";
            pictureBox_Loading.Size = new Size(62, 57);
            pictureBox_Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Loading.TabIndex = 83;
            pictureBox_Loading.TabStop = false;
            pictureBox_Loading.Visible = false;
            // 
            // btn_FigmaUpload
            // 
            btn_FigmaUpload.BackColor = Color.Transparent;
            btn_FigmaUpload.BorderColor = Color.FromArgb(32, 34, 37);
            btn_FigmaUpload.EnteredBorderColor = Color.FromArgb(127, 161, 195);
            btn_FigmaUpload.EnteredColor = Color.FromArgb(51, 52, 55);
            btn_FigmaUpload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_FigmaUpload.Image = null;
            btn_FigmaUpload.ImageAlign = ContentAlignment.MiddleLeft;
            btn_FigmaUpload.InactiveColor = Color.FromArgb(51, 52, 55);
            btn_FigmaUpload.Location = new Point(554, 101);
            btn_FigmaUpload.Margin = new Padding(3, 2, 3, 2);
            btn_FigmaUpload.Name = "btn_FigmaUpload";
            btn_FigmaUpload.PressedBorderColor = Color.FromArgb(127, 161, 195);
            btn_FigmaUpload.PressedColor = Color.FromArgb(127, 161, 195);
            btn_FigmaUpload.Size = new Size(48, 32);
            btn_FigmaUpload.TabIndex = 81;
            btn_FigmaUpload.Text = "Add";
            btn_FigmaUpload.TextAlignment = StringAlignment.Center;
            btn_FigmaUpload.Click += btn_FigmaUpload_Click;
            // 
            // DataGridView_ImagesList
            // 
            DataGridView_ImagesList.AllowUserToResizeRows = false;
            DataGridView_ImagesList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_ImagesList.BackgroundColor = Color.FromArgb(244, 245, 245);
            DataGridView_ImagesList.BorderStyle = BorderStyle.None;
            DataGridView_ImagesList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridView_ImagesList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 130, 173);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView_ImagesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_ImagesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_ImagesList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView_ImagesList.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_ImagesList.EnableHeadersVisualStyles = false;
            DataGridView_ImagesList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataGridView_ImagesList.GridColor = Color.FromArgb(255, 255, 255);
            DataGridView_ImagesList.Location = new Point(111, 623);
            DataGridView_ImagesList.Margin = new Padding(3, 2, 3, 2);
            DataGridView_ImagesList.Name = "DataGridView_ImagesList";
            DataGridView_ImagesList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 130, 173);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridView_ImagesList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_ImagesList.RowHeadersWidth = 51;
            DataGridView_ImagesList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridView_ImagesList.RowTemplate.Height = 29;
            DataGridView_ImagesList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_ImagesList.Size = new Size(532, 209);
            DataGridView_ImagesList.TabIndex = 80;
            DataGridView_ImagesList.CellContentClick += DataGridView_ImagesList_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 30;
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 250;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Image = Properties.Resources.delete_24;
            Column3.Name = "Column3";
            Column3.Width = 30;
            // 
            // lbl_close
            // 
            lbl_close.AccessibleRole = AccessibleRole.Cell;
            lbl_close.AutoSize = true;
            lbl_close.Cursor = Cursors.Hand;
            lbl_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_close.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_close.Location = new Point(731, 7);
            lbl_close.Name = "lbl_close";
            lbl_close.Size = new Size(23, 25);
            lbl_close.TabIndex = 53;
            lbl_close.Text = "X";
            lbl_close.Click += lbl_close_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.BackColor = Color.Transparent;
            btn_Clear.BorderColor = Color.FromArgb(32, 34, 37);
            btn_Clear.EnteredBorderColor = Color.FromArgb(127, 161, 195);
            btn_Clear.EnteredColor = Color.FromArgb(51, 52, 55);
            btn_Clear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Clear.Image = null;
            btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clear.InactiveColor = Color.FromArgb(51, 52, 55);
            btn_Clear.Location = new Point(466, 538);
            btn_Clear.Margin = new Padding(3, 2, 3, 2);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.PressedBorderColor = Color.FromArgb(127, 161, 195);
            btn_Clear.PressedColor = Color.FromArgb(127, 161, 195);
            btn_Clear.Size = new Size(142, 30);
            btn_Clear.TabIndex = 52;
            btn_Clear.Text = "Clear";
            btn_Clear.TextAlignment = StringAlignment.Center;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Save_Designs
            // 
            btn_Save_Designs.BackColor = Color.Transparent;
            btn_Save_Designs.BorderColor = Color.FromArgb(32, 34, 37);
            btn_Save_Designs.EnteredBorderColor = Color.FromArgb(127, 161, 195);
            btn_Save_Designs.EnteredColor = Color.FromArgb(51, 52, 55);
            btn_Save_Designs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save_Designs.Image = null;
            btn_Save_Designs.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save_Designs.InactiveColor = Color.FromArgb(51, 52, 55);
            btn_Save_Designs.Location = new Point(315, 538);
            btn_Save_Designs.Margin = new Padding(3, 2, 3, 2);
            btn_Save_Designs.Name = "btn_Save_Designs";
            btn_Save_Designs.PressedBorderColor = Color.FromArgb(127, 161, 195);
            btn_Save_Designs.PressedColor = Color.FromArgb(127, 161, 195);
            btn_Save_Designs.Size = new Size(142, 30);
            btn_Save_Designs.TabIndex = 51;
            btn_Save_Designs.Text = "Submit";
            btn_Save_Designs.TextAlignment = StringAlignment.Center;
            btn_Save_Designs.Click += btn_Save_Designs_Click_1;
            // 
            // lbl_imagesList
            // 
            lbl_imagesList.AutoSize = true;
            lbl_imagesList.BackColor = Color.White;
            lbl_imagesList.Cursor = Cursors.Hand;
            lbl_imagesList.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_imagesList.ForeColor = Color.FromArgb(100, 130, 173);
            lbl_imagesList.Location = new Point(111, 594);
            lbl_imagesList.Name = "lbl_imagesList";
            lbl_imagesList.Size = new Size(76, 17);
            lbl_imagesList.TabIndex = 50;
            lbl_imagesList.Text = "Images List";
            // 
            // lbl_Upload
            // 
            lbl_Upload.AutoSize = true;
            lbl_Upload.BackColor = Color.White;
            lbl_Upload.Cursor = Cursors.Hand;
            lbl_Upload.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Upload.ForeColor = Color.FromArgb(100, 130, 173);
            lbl_Upload.Location = new Point(275, 369);
            lbl_Upload.Name = "lbl_Upload";
            lbl_Upload.Size = new Size(216, 30);
            lbl_Upload.TabIndex = 49;
            lbl_Upload.Text = "Click Here to Browse";
            lbl_Upload.Click += lbl_Upload_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(142, 142, 142);
            label1.Location = new Point(144, 118);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 48;
            label1.Text = "Figma URL      :";
            // 
            // txt_figmaLink
            // 
            txt_figmaLink.BackColor = Color.FromArgb(238, 238, 238);
            txt_figmaLink.BaseColor = Color.FromArgb(238, 238, 238);
            txt_figmaLink.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_figmaLink.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_figmaLink.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_figmaLink.ForeColor = Color.FromArgb(142, 142, 142);
            txt_figmaLink.Hint = "";
            txt_figmaLink.Location = new Point(238, 101);
            txt_figmaLink.Margin = new Padding(3, 2, 3, 2);
            txt_figmaLink.MaxLength = 32767;
            txt_figmaLink.Multiline = false;
            txt_figmaLink.Name = "txt_figmaLink";
            txt_figmaLink.PasswordChar = '\0';
            txt_figmaLink.ScrollBars = ScrollBars.None;
            txt_figmaLink.SelectedText = "";
            txt_figmaLink.SelectionLength = 0;
            txt_figmaLink.SelectionStart = 0;
            txt_figmaLink.Size = new Size(310, 32);
            txt_figmaLink.TabIndex = 47;
            txt_figmaLink.TabStop = false;
            txt_figmaLink.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.exceptions;
            pictureBox2.Location = new Point(10, 9);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_DesignName
            // 
            lbl_DesignName.AutoSize = true;
            lbl_DesignName.Cursor = Cursors.Hand;
            lbl_DesignName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DesignName.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_DesignName.Location = new Point(144, 75);
            lbl_DesignName.Name = "lbl_DesignName";
            lbl_DesignName.Size = new Size(85, 15);
            lbl_DesignName.TabIndex = 45;
            lbl_DesignName.Text = "Design Name :";
            // 
            // txt_DesignName
            // 
            txt_DesignName.BackColor = Color.FromArgb(238, 238, 238);
            txt_DesignName.BaseColor = Color.FromArgb(238, 238, 238);
            txt_DesignName.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_DesignName.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_DesignName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DesignName.ForeColor = Color.FromArgb(142, 142, 142);
            txt_DesignName.Hint = "";
            txt_DesignName.Location = new Point(238, 58);
            txt_DesignName.Margin = new Padding(3, 2, 3, 2);
            txt_DesignName.MaxLength = 32767;
            txt_DesignName.Multiline = false;
            txt_DesignName.Name = "txt_DesignName";
            txt_DesignName.PasswordChar = '\0';
            txt_DesignName.ScrollBars = ScrollBars.None;
            txt_DesignName.SelectedText = "";
            txt_DesignName.SelectionLength = 0;
            txt_DesignName.SelectionStart = 0;
            txt_DesignName.Size = new Size(364, 32);
            txt_DesignName.TabIndex = 44;
            txt_DesignName.TabStop = false;
            txt_DesignName.UseSystemPasswordChar = false;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Image = Properties.Resources.Frame_22;
            pictureBox.Location = new Point(111, 135);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(532, 423);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 43;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Upload_Click;
            // 
            // lbl_Tiltle
            // 
            lbl_Tiltle.AutoSize = true;
            lbl_Tiltle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tiltle.ForeColor = Color.FromArgb(51, 52, 55);
            lbl_Tiltle.Location = new Point(52, 14);
            lbl_Tiltle.Name = "lbl_Tiltle";
            lbl_Tiltle.Size = new Size(162, 21);
            lbl_Tiltle.TabIndex = 42;
            lbl_Tiltle.Text = "Upload Your Design";
            // 
            // pictureBox_SettingsIcon
            // 
            pictureBox_SettingsIcon.Image = Properties.Resources.exceptions;
            pictureBox_SettingsIcon.Location = new Point(177, 201);
            pictureBox_SettingsIcon.Margin = new Padding(3, 2, 3, 2);
            pictureBox_SettingsIcon.Name = "pictureBox_SettingsIcon";
            pictureBox_SettingsIcon.Size = new Size(37, 32);
            pictureBox_SettingsIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SettingsIcon.TabIndex = 41;
            pictureBox_SettingsIcon.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            pictureBox_Bottom.BackColor = Color.FromArgb(127, 161, 195);
            pictureBox_Bottom.Image = Properties.Resources.Frame_71;
            pictureBox_Bottom.Location = new Point(-1, 893);
            pictureBox_Bottom.Name = "pictureBox_Bottom";
            pictureBox_Bottom.Size = new Size(764, 23);
            pictureBox_Bottom.TabIndex = 82;
            pictureBox_Bottom.TabStop = false;
            // 
            // AddNewDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(764, 917);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "AddNewDesign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewDesign";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_ImagesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SettingsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bottom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label lbl_Tiltle;
        private PictureBox pictureBox_SettingsIcon;
        private PictureBox pictureBox;
        private Label lbl_DesignName;
        private ReaLTaiizor.Controls.HopeTextBox txt_DesignName;
        private Label lbl_Upload;
        private Label label1;
        private ReaLTaiizor.Controls.HopeTextBox txt_figmaLink;
        private PictureBox pictureBox2;
        private Label lbl_imagesList;
        private ReaLTaiizor.Controls.Button btn_Clear;
        private ReaLTaiizor.Controls.Button btn_Save_Designs;
        private Button btn_Close;
        private Label lbl_close;
        private ReaLTaiizor.Controls.PoisonDataGridView DataGridView_ImagesList;
        private ReaLTaiizor.Controls.Button btn_FigmaUpload;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
        private PictureBox pictureBox_Bottom;
        private PictureBox pictureBox_Loading;
    }
}
namespace TypeSafeFrontend.Views
{
    partial class SummaryDesign
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
            mainPanel = new Panel();
            btn_AddDesign = new Button();
            DataGridView_DesignList = new ReaLTaiizor.Controls.PoisonDataGridView();
            lbl_DesignHistory = new Label();
            panel_Main_Info = new Panel();
            pictureBox = new PictureBox();
            lbl_Trigger_Precentage = new Label();
            txt_TriggerPrecentage = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_UI_Trigger_Area = new Label();
            txt_TriggerArea = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_UI_area = new Label();
            txt_TotalArea = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_Design_Date = new Label();
            txt_CreatedDate = new ReaLTaiizor.Controls.HopeTextBox();
            lbl_DesignName = new Label();
            txt_DesignName = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox_Bottom = new PictureBox();
            lbl_close = new Label();
            pictureBox_Logo = new PictureBox();
            lbl_Tiltle = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewImageColumn();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_DesignList).BeginInit();
            panel_Main_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(244, 246, 255);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(btn_AddDesign);
            mainPanel.Controls.Add(DataGridView_DesignList);
            mainPanel.Controls.Add(lbl_DesignHistory);
            mainPanel.Controls.Add(panel_Main_Info);
            mainPanel.Controls.Add(pictureBox_Bottom);
            mainPanel.Controls.Add(lbl_close);
            mainPanel.Controls.Add(pictureBox_Logo);
            mainPanel.Controls.Add(lbl_Tiltle);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(928, 594);
            mainPanel.TabIndex = 0;
            // 
            // btn_AddDesign
            // 
            btn_AddDesign.BackColor = Color.Transparent;
            btn_AddDesign.BackgroundImage = Properties.Resources.addIcons;
            btn_AddDesign.BackgroundImageLayout = ImageLayout.Stretch;
            btn_AddDesign.Location = new Point(839, 22);
            btn_AddDesign.Name = "btn_AddDesign";
            btn_AddDesign.Size = new Size(38, 38);
            btn_AddDesign.TabIndex = 87;
            btn_AddDesign.UseVisualStyleBackColor = false;
            btn_AddDesign.Click += btn_AddDesign_Click;
            // 
            // DataGridView_DesignList
            // 
            DataGridView_DesignList.AllowUserToResizeRows = false;
            DataGridView_DesignList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_DesignList.BackgroundColor = Color.FromArgb(244, 245, 245);
            DataGridView_DesignList.BorderStyle = BorderStyle.None;
            DataGridView_DesignList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridView_DesignList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(100, 130, 173);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridView_DesignList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_DesignList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_DesignList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5, Column6, Column7, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataGridView_DesignList.DefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_DesignList.EnableHeadersVisualStyles = false;
            DataGridView_DesignList.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            DataGridView_DesignList.GridColor = Color.FromArgb(255, 255, 255);
            DataGridView_DesignList.Location = new Point(51, 306);
            DataGridView_DesignList.Margin = new Padding(3, 2, 3, 2);
            DataGridView_DesignList.Name = "DataGridView_DesignList";
            DataGridView_DesignList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(100, 130, 173);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(127, 161, 195);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridView_DesignList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_DesignList.RowHeadersWidth = 51;
            DataGridView_DesignList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridView_DesignList.RowTemplate.Height = 29;
            DataGridView_DesignList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView_DesignList.Size = new Size(829, 247);
            DataGridView_DesignList.TabIndex = 86;
            DataGridView_DesignList.CellContentClick += DataGridView_DesignList_CellContentClick;
            DataGridView_DesignList.KeyUp += DataGridView_DesignList_KeyUp;
            DataGridView_DesignList.MouseClick += DataGridView_DesignList_MouseClick;
            // 
            // lbl_DesignHistory
            // 
            lbl_DesignHistory.AutoSize = true;
            lbl_DesignHistory.BackColor = Color.White;
            lbl_DesignHistory.Cursor = Cursors.Hand;
            lbl_DesignHistory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DesignHistory.ForeColor = Color.FromArgb(100, 130, 173);
            lbl_DesignHistory.Location = new Point(51, 278);
            lbl_DesignHistory.Name = "lbl_DesignHistory";
            lbl_DesignHistory.Size = new Size(98, 17);
            lbl_DesignHistory.TabIndex = 85;
            lbl_DesignHistory.Text = "Design History";
            lbl_DesignHistory.Click += lbl_DesignHistory_Click;
            // 
            // panel_Main_Info
            // 
            panel_Main_Info.BackgroundImage = Properties.Resources.Rectangle;
            panel_Main_Info.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Main_Info.Controls.Add(pictureBox);
            panel_Main_Info.Controls.Add(lbl_Trigger_Precentage);
            panel_Main_Info.Controls.Add(txt_TriggerPrecentage);
            panel_Main_Info.Controls.Add(lbl_UI_Trigger_Area);
            panel_Main_Info.Controls.Add(txt_TriggerArea);
            panel_Main_Info.Controls.Add(lbl_UI_area);
            panel_Main_Info.Controls.Add(txt_TotalArea);
            panel_Main_Info.Controls.Add(lbl_Design_Date);
            panel_Main_Info.Controls.Add(txt_CreatedDate);
            panel_Main_Info.Controls.Add(lbl_DesignName);
            panel_Main_Info.Controls.Add(txt_DesignName);
            panel_Main_Info.Location = new Point(51, 66);
            panel_Main_Info.Name = "panel_Main_Info";
            panel_Main_Info.Size = new Size(831, 173);
            panel_Main_Info.TabIndex = 84;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Image = Properties.Resources.log__2_;
            pictureBox.Location = new Point(37, 23);
            pictureBox.Margin = new Padding(3, 2, 3, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(92, 123);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 87;
            pictureBox.TabStop = false;
            // 
            // lbl_Trigger_Precentage
            // 
            lbl_Trigger_Precentage.AutoSize = true;
            lbl_Trigger_Precentage.BackColor = Color.White;
            lbl_Trigger_Precentage.Cursor = Cursors.Hand;
            lbl_Trigger_Precentage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Trigger_Precentage.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_Trigger_Precentage.Location = new Point(547, 123);
            lbl_Trigger_Precentage.Name = "lbl_Trigger_Precentage";
            lbl_Trigger_Precentage.Size = new Size(112, 15);
            lbl_Trigger_Precentage.TabIndex = 58;
            lbl_Trigger_Precentage.Text = "Trigger Precentage :";
            // 
            // txt_TriggerPrecentage
            // 
            txt_TriggerPrecentage.BackColor = Color.FromArgb(238, 238, 238);
            txt_TriggerPrecentage.BaseColor = Color.FromArgb(238, 238, 238);
            txt_TriggerPrecentage.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_TriggerPrecentage.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_TriggerPrecentage.Enabled = false;
            txt_TriggerPrecentage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TriggerPrecentage.ForeColor = Color.FromArgb(51, 52, 55);
            txt_TriggerPrecentage.Hint = "";
            txt_TriggerPrecentage.Location = new Point(668, 114);
            txt_TriggerPrecentage.Margin = new Padding(3, 2, 3, 2);
            txt_TriggerPrecentage.MaxLength = 32767;
            txt_TriggerPrecentage.Multiline = false;
            txt_TriggerPrecentage.Name = "txt_TriggerPrecentage";
            txt_TriggerPrecentage.PasswordChar = '\0';
            txt_TriggerPrecentage.ScrollBars = ScrollBars.None;
            txt_TriggerPrecentage.SelectedText = "";
            txt_TriggerPrecentage.SelectionLength = 0;
            txt_TriggerPrecentage.SelectionStart = 0;
            txt_TriggerPrecentage.Size = new Size(124, 32);
            txt_TriggerPrecentage.TabIndex = 57;
            txt_TriggerPrecentage.TabStop = false;
            txt_TriggerPrecentage.UseSystemPasswordChar = false;
            // 
            // lbl_UI_Trigger_Area
            // 
            lbl_UI_Trigger_Area.AutoSize = true;
            lbl_UI_Trigger_Area.BackColor = Color.White;
            lbl_UI_Trigger_Area.Cursor = Cursors.Hand;
            lbl_UI_Trigger_Area.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_UI_Trigger_Area.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_UI_Trigger_Area.Location = new Point(547, 78);
            lbl_UI_Trigger_Area.Name = "lbl_UI_Trigger_Area";
            lbl_UI_Trigger_Area.Size = new Size(112, 15);
            lbl_UI_Trigger_Area.TabIndex = 56;
            lbl_UI_Trigger_Area.Text = "Trigger UIs Area      :";
            // 
            // txt_TriggerArea
            // 
            txt_TriggerArea.BackColor = Color.FromArgb(238, 238, 238);
            txt_TriggerArea.BaseColor = Color.FromArgb(238, 238, 238);
            txt_TriggerArea.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_TriggerArea.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_TriggerArea.Enabled = false;
            txt_TriggerArea.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TriggerArea.ForeColor = Color.FromArgb(51, 52, 55);
            txt_TriggerArea.Hint = "";
            txt_TriggerArea.Location = new Point(668, 68);
            txt_TriggerArea.Margin = new Padding(3, 2, 3, 2);
            txt_TriggerArea.MaxLength = 32767;
            txt_TriggerArea.Multiline = false;
            txt_TriggerArea.Name = "txt_TriggerArea";
            txt_TriggerArea.PasswordChar = '\0';
            txt_TriggerArea.ScrollBars = ScrollBars.None;
            txt_TriggerArea.SelectedText = "";
            txt_TriggerArea.SelectionLength = 0;
            txt_TriggerArea.SelectionStart = 0;
            txt_TriggerArea.Size = new Size(125, 32);
            txt_TriggerArea.TabIndex = 55;
            txt_TriggerArea.TabStop = false;
            txt_TriggerArea.UseSystemPasswordChar = false;
            // 
            // lbl_UI_area
            // 
            lbl_UI_area.AutoSize = true;
            lbl_UI_area.BackColor = Color.White;
            lbl_UI_area.Cursor = Cursors.Hand;
            lbl_UI_area.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_UI_area.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_UI_area.Location = new Point(549, 35);
            lbl_UI_area.Name = "lbl_UI_area";
            lbl_UI_area.Size = new Size(113, 15);
            lbl_UI_area.TabIndex = 54;
            lbl_UI_area.Text = "Total UIs Area         : ";
            // 
            // txt_TotalArea
            // 
            txt_TotalArea.BackColor = Color.FromArgb(238, 238, 238);
            txt_TotalArea.BaseColor = Color.FromArgb(238, 238, 238);
            txt_TotalArea.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_TotalArea.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_TotalArea.Enabled = false;
            txt_TotalArea.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_TotalArea.ForeColor = Color.FromArgb(51, 52, 55);
            txt_TotalArea.Hint = "";
            txt_TotalArea.Location = new Point(668, 23);
            txt_TotalArea.Margin = new Padding(3, 2, 3, 2);
            txt_TotalArea.MaxLength = 32767;
            txt_TotalArea.Multiline = false;
            txt_TotalArea.Name = "txt_TotalArea";
            txt_TotalArea.PasswordChar = '\0';
            txt_TotalArea.ScrollBars = ScrollBars.None;
            txt_TotalArea.SelectedText = "";
            txt_TotalArea.SelectionLength = 0;
            txt_TotalArea.SelectionStart = 0;
            txt_TotalArea.Size = new Size(125, 32);
            txt_TotalArea.TabIndex = 53;
            txt_TotalArea.TabStop = false;
            txt_TotalArea.UseSystemPasswordChar = false;
            // 
            // lbl_Design_Date
            // 
            lbl_Design_Date.AutoSize = true;
            lbl_Design_Date.BackColor = Color.White;
            lbl_Design_Date.Cursor = Cursors.Hand;
            lbl_Design_Date.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Design_Date.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_Design_Date.Location = new Point(173, 118);
            lbl_Design_Date.Name = "lbl_Design_Date";
            lbl_Design_Date.Size = new Size(90, 15);
            lbl_Design_Date.TabIndex = 52;
            lbl_Design_Date.Text = "Created Date    :";
            // 
            // txt_CreatedDate
            // 
            txt_CreatedDate.BackColor = Color.FromArgb(238, 238, 238);
            txt_CreatedDate.BaseColor = Color.FromArgb(238, 238, 238);
            txt_CreatedDate.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_CreatedDate.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_CreatedDate.Enabled = false;
            txt_CreatedDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_CreatedDate.ForeColor = Color.FromArgb(51, 52, 55);
            txt_CreatedDate.Hint = "";
            txt_CreatedDate.Location = new Point(264, 108);
            txt_CreatedDate.Margin = new Padding(3, 2, 3, 2);
            txt_CreatedDate.MaxLength = 32767;
            txt_CreatedDate.Multiline = false;
            txt_CreatedDate.Name = "txt_CreatedDate";
            txt_CreatedDate.PasswordChar = '\0';
            txt_CreatedDate.ScrollBars = ScrollBars.None;
            txt_CreatedDate.SelectedText = "";
            txt_CreatedDate.SelectionLength = 0;
            txt_CreatedDate.SelectionStart = 0;
            txt_CreatedDate.Size = new Size(200, 32);
            txt_CreatedDate.TabIndex = 51;
            txt_CreatedDate.TabStop = false;
            txt_CreatedDate.UseSystemPasswordChar = false;
            // 
            // lbl_DesignName
            // 
            lbl_DesignName.AutoSize = true;
            lbl_DesignName.BackColor = Color.White;
            lbl_DesignName.Cursor = Cursors.Hand;
            lbl_DesignName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DesignName.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_DesignName.Location = new Point(173, 41);
            lbl_DesignName.Name = "lbl_DesignName";
            lbl_DesignName.Size = new Size(85, 15);
            lbl_DesignName.TabIndex = 50;
            lbl_DesignName.Text = "Design Name :";
            // 
            // txt_DesignName
            // 
            txt_DesignName.BackColor = Color.FromArgb(238, 238, 238);
            txt_DesignName.BaseColor = Color.FromArgb(238, 238, 238);
            txt_DesignName.BorderColorA = Color.FromArgb(238, 238, 238);
            txt_DesignName.BorderColorB = Color.FromArgb(238, 238, 238);
            txt_DesignName.Enabled = false;
            txt_DesignName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_DesignName.ForeColor = Color.FromArgb(51, 52, 55);
            txt_DesignName.Hint = "";
            txt_DesignName.Location = new Point(264, 35);
            txt_DesignName.Margin = new Padding(3, 2, 3, 2);
            txt_DesignName.MaxLength = 32767;
            txt_DesignName.Multiline = false;
            txt_DesignName.Name = "txt_DesignName";
            txt_DesignName.PasswordChar = '\0';
            txt_DesignName.ScrollBars = ScrollBars.None;
            txt_DesignName.SelectedText = "";
            txt_DesignName.SelectionLength = 0;
            txt_DesignName.SelectionStart = 0;
            txt_DesignName.Size = new Size(200, 32);
            txt_DesignName.TabIndex = 49;
            txt_DesignName.TabStop = false;
            txt_DesignName.UseSystemPasswordChar = false;
            // 
            // pictureBox_Bottom
            // 
            pictureBox_Bottom.BackColor = Color.FromArgb(127, 161, 195);
            pictureBox_Bottom.Dock = DockStyle.Bottom;
            pictureBox_Bottom.Image = Properties.Resources.Frame_71;
            pictureBox_Bottom.Location = new Point(0, 569);
            pictureBox_Bottom.Name = "pictureBox_Bottom";
            pictureBox_Bottom.Size = new Size(926, 23);
            pictureBox_Bottom.TabIndex = 83;
            pictureBox_Bottom.TabStop = false;
            // 
            // lbl_close
            // 
            lbl_close.AccessibleRole = AccessibleRole.Cell;
            lbl_close.AutoSize = true;
            lbl_close.Cursor = Cursors.Hand;
            lbl_close.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_close.ForeColor = Color.FromArgb(142, 142, 142);
            lbl_close.Location = new Point(897, 4);
            lbl_close.Name = "lbl_close";
            lbl_close.Size = new Size(23, 25);
            lbl_close.TabIndex = 56;
            lbl_close.Text = "X";
            lbl_close.Click += lbl_close_Click;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.Image = Properties.Resources.log__2_;
            pictureBox_Logo.Location = new Point(9, 8);
            pictureBox_Logo.Margin = new Padding(3, 2, 3, 2);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new Size(37, 32);
            pictureBox_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Logo.TabIndex = 55;
            pictureBox_Logo.TabStop = false;
            // 
            // lbl_Tiltle
            // 
            lbl_Tiltle.AutoSize = true;
            lbl_Tiltle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tiltle.ForeColor = Color.FromArgb(51, 52, 55);
            lbl_Tiltle.Location = new Point(51, 13);
            lbl_Tiltle.Name = "lbl_Tiltle";
            lbl_Tiltle.Size = new Size(141, 21);
            lbl_Tiltle.TabIndex = 54;
            lbl_Tiltle.Text = "Design Summary";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 30;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 250;
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Created Date";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Design Area";
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Trigger Area";
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trigger Precentage";
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Image = Properties.Resources.back2;
            Column3.Name = "Column3";
            Column3.Width = 30;
            // 
            // SummaryDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 594);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "SummaryDesign";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SummaryDesign";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_DesignList).EndInit();
            panel_Main_Info.ResumeLayout(false);
            panel_Main_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label lbl_close;
        private PictureBox pictureBox_Logo;
        private Label lbl_Tiltle;
        private PictureBox pictureBox_Bottom;
        private Panel panel_Main_Info;
        private Label lbl_Trigger_Precentage;
        private ReaLTaiizor.Controls.HopeTextBox txt_TriggerPrecentage;
        private Label lbl_UI_Trigger_Area;
        private ReaLTaiizor.Controls.HopeTextBox txt_TriggerArea;
        private Label lbl_UI_area;
        private ReaLTaiizor.Controls.HopeTextBox txt_TotalArea;
        private Label lbl_Design_Date;
        private ReaLTaiizor.Controls.HopeTextBox txt_CreatedDate;
        private Label lbl_DesignName;
        private ReaLTaiizor.Controls.HopeTextBox txt_DesignName;
        private ReaLTaiizor.Controls.PoisonDataGridView DataGridView_DesignList;
        private Label lbl_DesignHistory;
        private PictureBox pictureBox;
        private Button btn_AddDesign;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Column3;
    }
}
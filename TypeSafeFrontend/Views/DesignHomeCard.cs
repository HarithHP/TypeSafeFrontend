using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TypeSafeFrontend.Views
{
    public partial class DesignHomeCard : Form
    {
        int DesignID;
        string Name;
        float TriggerPercentage;
        string CreatedDate;
        float DesignArea;
        float TriggerDesignArea;
        byte[] ImageData;
        public DesignHomeCard(int DesignID, string Name, float TriggerPercentage, string CreatedDate, float DesignArea, float TriggerDesignArea, byte[] ImageData)
        {
            InitializeComponent();
            // Add event handlers for mouse events on the form
            this.MouseEnter += DesignHomeCard_MouseEnter;
            this.MouseLeave += DesignHomeCard_MouseLeave;
            this.MouseDown += DesignHomeCard_MouseDown;
            this.MouseUp += DesignHomeCard_MouseUp;

            // Add event handlers for the label and pictureBox
            labelName.MouseEnter += Label_MouseEnter;
            labelName.MouseLeave += Label_MouseLeave;
            labelName.MouseDown += Label_MouseDown;
            labelName.MouseUp += Label_MouseUp;

            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseUp += PictureBox_MouseUp;

            if (ImageData != null && ImageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            labelName.Text = Name;

            this.DesignID = DesignID;
            this.Name = Name;
            this.TriggerPercentage = TriggerPercentage;
            this.CreatedDate = CreatedDate;
            this.DesignArea = DesignArea;
            this.TriggerDesignArea = TriggerDesignArea;
            this.ImageData = ImageData;
        }

        #region Click Events
        // Form events
        private void DesignHomeCard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(206, 217, 237); // Custom hover color (Light Blue)
        }

        private void DesignHomeCard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color
        }

        private void DesignHomeCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Custom click color (Dark Blue)
            }
        }

        private void DesignHomeCard_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(206, 217, 237); // Revert to hover color (Light Blue)
            }
        }

        // Label events
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(206, 217, 237); // Custom hover color for DesignHomeCard
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color for DesignHomeCard
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Custom click color for DesignHomeCard
            }
        }

        private void Label_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(206, 217, 237); // Revert to hover color for DesignHomeCard
            }
        }

        // PictureBox events
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(206, 217, 237); // Custom hover color for DesignHomeCard
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color for DesignHomeCard
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Custom click color for DesignHomeCard
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(206, 217, 237); // Revert to hover color for DesignHomeCard
            }
        }

        #endregion

        #region Action Events
        private void label_Click(object sender, EventArgs e)
        {
            SummaryDesign summaryDesign = new SummaryDesign(DesignID, Name, TriggerPercentage, CreatedDate, DesignArea, TriggerDesignArea, ImageData);
            summaryDesign.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            SummaryDesign summaryDesign = new SummaryDesign(DesignID, Name, TriggerPercentage, CreatedDate, DesignArea, TriggerDesignArea, ImageData);
            summaryDesign.ShowDialog();
        }

        private void DesignHomeCard_Load(object sender, EventArgs e)
        {

        }

        private void DesignHomeCard_MouseClick(object sender, MouseEventArgs e)
        {
            SummaryDesign summaryDesign = new SummaryDesign(DesignID, Name, TriggerPercentage, CreatedDate, DesignArea, TriggerDesignArea, ImageData);
            summaryDesign.ShowDialog();
        }

        #endregion
    }
}

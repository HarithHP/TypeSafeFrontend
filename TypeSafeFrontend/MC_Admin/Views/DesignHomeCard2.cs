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
    public partial class DesignHomeCard2 : Form
    {
        int DesignId;
        int Id;
        string FileName;
        byte[] ImageData;
        byte[] TriggerImageData;
        float ImageArea;
        float TriggerImageArea;
        float TriggerImagePresentage;
        float TriggerImagePossibilty;
        bool IsTriggerImagePossibilty;
        public DesignHomeCard2(int Id, int DesignID, string FileName, byte[] ImageData, byte[] TriggerImageData, float ImageArea, float TriggerImageArea, float TriggerImagePresentage, float TriggerImagePossibilty, bool IsTriggerImagePossibilty)
        {
            InitializeComponent();
            // Add event handlers for mouse events on the form
            this.MouseEnter += DesignHomeCard2_MouseEnter;
            this.MouseLeave += DesignHomeCard2_MouseLeave;
            this.MouseDown += DesignHomeCard2_MouseDown;
            this.MouseUp += DesignHomeCard2_MouseUp;

            // Add event handlers for the label and pictureBox
            labelName.MouseEnter += Label_MouseEnter;
            labelName.MouseLeave += Label_MouseLeave;
            labelName.MouseDown += Label_MouseDown;
            labelName.MouseUp += Label_MouseUp;

            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseUp += PictureBox_MouseUp;

            if (TriggerImageData != null && TriggerImageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(TriggerImageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            labelName.Text = FileName + "  T-Percentage : " + $"{TriggerImagePresentage:F2} %";

            this.Id = Id;
            this.DesignId = DesignID;
            this.FileName = FileName;
            this.ImageData = ImageData;
            this.TriggerImageData = TriggerImageData;
            this.ImageArea = ImageArea;
            this.TriggerImageArea = TriggerImageArea;
            this.TriggerImagePresentage = TriggerImagePresentage;
            this.TriggerImagePossibilty = TriggerImagePossibilty;
            this.IsTriggerImagePossibilty = IsTriggerImagePossibilty;

        }
        #region Click Events 
        // Form events
        private void DesignHomeCard2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(206, 217, 237); // Hover color
        }

        private void DesignHomeCard2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color
        }

        private void DesignHomeCard2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Click color
            }
        }

        private void DesignHomeCard2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(206, 217, 237); // Revert to hover color
            }
        }

        // Label events
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(206, 217, 237); // Hover color for DesignHomeCard
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color for DesignHomeCard
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Click color for DesignHomeCard
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
            this.BackColor = Color.FromArgb(206, 217, 237); // Hover color for DesignHomeCard
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Default color for DesignHomeCard
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.FromArgb(100, 130, 173); // Click color for DesignHomeCard
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
            ViewUIDesign viewUIDesign = new ViewUIDesign(Id, DesignId, FileName, ImageData, TriggerImageData, ImageArea, TriggerImageArea, TriggerImagePresentage, TriggerImagePossibilty, IsTriggerImagePossibilty);
            viewUIDesign.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ViewUIDesign viewUIDesign = new ViewUIDesign(Id, DesignId, FileName, ImageData, TriggerImageData, ImageArea, TriggerImageArea, TriggerImagePresentage, TriggerImagePossibilty, IsTriggerImagePossibilty);
            viewUIDesign.Show();    
        }

        private void DesignHomeCard2_Load(object sender, EventArgs e)
        {

        }

        private void DesignHomeCard2_MouseClick(object sender, MouseEventArgs e)
        {
            ViewUIDesign viewUIDesign = new ViewUIDesign(Id, DesignId, FileName, ImageData, TriggerImageData, ImageArea, TriggerImageArea, TriggerImagePresentage, TriggerImagePossibilty, IsTriggerImagePossibilty);
            viewUIDesign.Show();
        }

        #endregion
    }
}

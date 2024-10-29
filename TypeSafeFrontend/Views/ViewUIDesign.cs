using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSafeFrontend.Views
{
    public partial class ViewUIDesign : Form
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
        public ViewUIDesign(int Id, int DesignID, string FileName, byte[] ImageData, byte[] TriggerImageData, float ImageArea, float TriggerImageArea, float TriggerImagePresentage, float TriggerImagePossibilty, bool IsTriggerImagePossibilty)
        {
            InitializeComponent();
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

            lbl_FileName.Text = FileName;
            if (IsTriggerImagePossibilty == true)
            {
                lbl_Triggered.Text = "Triggered";
                lbl_Triggered.ForeColor = Color.Red;

            }
            else
            {
                lbl_Triggered.Text = "Trypophobia Free";
                lbl_Triggered.ForeColor = Color.Green;
            }
            if (ImageData != null && ImageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Auto-resize while keeping the aspect ratio
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            txt_ImageArea.Text = $"{ImageArea} Pixels";
            txt_TriggerImageArea.Text = $"{TriggerImageArea} Pixels";
            txt_TriggerImagePossibilty.Text = $"{TriggerImagePossibilty:F2} %";
            txt_TriggerImagePresentage.Text = $"{TriggerImagePresentage:F2} %";
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewUIDesign_Load(object sender, EventArgs e)
        {

        }
    }
}

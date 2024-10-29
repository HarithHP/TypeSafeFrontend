using MC_Admin.Manager;
using MC_Admin.Models.Responses;
using MC_Admin.Services;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeSafeFrontend.Models.Responses;
using TypeSafeFrontend.Models;

namespace TypeSafeFrontend.Views
{
    public partial class DesignsUI : Form
    {
        int DesignID;
        string DesignName;
        float TriggerPercentage;
        string CreatedDate;
        float DesignArea;
        float TriggerDesignArea;
        byte[] ImageData;

        int DesignId2;
        int Id;
        string FileName;
        byte[] ImageData2;
        byte[] TriggerImageData;
        float ImageArea;
        float TriggerImageArea;
        float TriggerImagePresentage;
        float TriggerImagePossibilty;
        bool IsTriggerImagePossibilty;


        public DesignsUI(int DesignID, string Name, float TriggerPercentage, string CreatedDate, float DesignArea, float TriggerDesignArea, byte[] ImageData)
        {
            InitializeComponent();
            panel.AutoScroll = true; // Enable scrolling
            this.DesignID = DesignID;
            this.DesignName = Name;
            this.TriggerPercentage = TriggerPercentage;
            this.CreatedDate = CreatedDate;
            this.DesignArea = DesignArea;
            this.TriggerDesignArea = TriggerDesignArea;
            this.ImageData = ImageData;
            txt_DesignName.Text = Name;
            if (DateTimeOffset.TryParse(CreatedDate, out DateTimeOffset parsedDate))
            {
                txt_CreatedDate.Text = parsedDate.ToString("MMMM dd, yyyy, h:mm tt");
            }
            else
            {
                txt_CreatedDate.Text = CreatedDate; // Fallback if parsing fails
            }
            txt_TotalArea.Text = $"{DesignArea} Pixels";
            txt_TriggerArea.Text = $"{TriggerDesignArea} Pixels";
            txt_TriggerPrecentage.Text = $"{TriggerPercentage:F2} %";
            GetSubDesigns(DesignID);
        }

        #region Add Design Card
        private void AddImageCard(int Id,int DesignID, string FileName, byte[] ImageData, byte[] TriggerImageData, float ImageArea, float TriggerImageArea, float TriggerImagePresentage, float TriggerImagePossibilty, bool IsTriggerImagePossibilty)
        {
            // Create a new instance of Form1
            DesignHomeCard2 newForm = new DesignHomeCard2( Id,  DesignID,  FileName,  ImageData,  TriggerImageData,  ImageArea,  TriggerImageArea,  TriggerImagePresentage,  TriggerImagePossibilty,  IsTriggerImagePossibilty);

            // Set the size of Form1
            newForm.Size = new Size(300, 400);

            // Set the Form1's TopLevel property to false so it can be added to the Panel
            newForm.TopLevel = false;

            // Add the Form1 instance to the Panel
            panel.Controls.Add(newForm);

            // Set the maximum number of forms in a row
            int formsInRow = 4; // Maximum number of forms in a row
            int gap = 30; // Gap between forms

            // Determine the current count of forms in the panel
            int currentCount = panel.Controls.Count - 1; // Subtract 1 because we just added a new form

            // Calculate the row and column for the new form
            int currentRow = currentCount / formsInRow; // Determine the current row
            int currentColumn = currentCount % formsInRow; // Determine the current column in the row

            // Calculate the yOffset based on the row
            int yOffset = gap + (currentRow * (newForm.Height + gap)); // 10 pixels gap between rows

            // Calculate the xOffset based on the column
            int xOffset = gap + (currentColumn * (newForm.Width + gap)); // 10 pixels gap between forms

            // Set the new form's location
            newForm.Location = new Point(xOffset, yOffset);

            // Show the Form1 instance
            newForm.Show();
        }
        #endregion

        #region Search Designs
        async Task GetSubDesigns(int DesignID)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };
            try
            {
                APIConnectionsService Service = new();
                r = await Service.GetSubDesigns(DesignID);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Message == "success")
                {

                    var response = r.Content as ModelResponseSubDesigns;

                    if (response?.Content != null)
                    {
                        foreach (var subDesign in response.Content)
                        {
                            AddImageCard(subDesign.Id ?? 0,
                                         subDesign.DesignId ?? 0,
                                         subDesign.FileName,
                                         subDesign.ImageData,
                                         subDesign.TriggerImageData,
                                         subDesign.ImageArea ?? 0f,
                                         subDesign.TriggerImageArea ?? 0f,
                                         subDesign.TriggerImagePresentage ?? 0f,
                                         subDesign.TriggerImagePossibilty ?? 0f,
                                         subDesign.IsTriggerImagePossibilty ?? false); // Default to false if null
                        }
                    }
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Message == "NoContent")
                {
                    MessageBox.Show("Warning! Designs Not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    MessageBox.Show("Error! You do not have permission to access this Application | Please Contact the Support Team", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    MessageBox.Show("Error! Get Sub Designs Process Failed - Bad Request |  Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error! Get Sub Designs Process Failed - Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Action Events
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion
    }
}

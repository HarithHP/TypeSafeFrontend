using MC_Admin.Manager;
using MC_Admin.Models.Responses;
using MC_Admin.Models;
using MC_Admin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeSafeFrontend.Views;
using TypeSafeFrontend.Models.Responses;
using TypeSafeFrontend.Models;
using System.Reflection.Metadata;

namespace MC_Admin.Views
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            panel.AutoScroll = true; // Enable scrolling
            DeleteCards();
            SearchDesigns("");
        }

        #region Action Events
        private void btn_AddDesign_Click(object sender, EventArgs e)
        {
            AddNewDesign addNewDesign = new AddNewDesign("None", 0);
            addNewDesign.ShowDialog();
            txt_SearchDesignName.Text = "";
            SearchDesigns(txt_SearchDesignName.Text.ToString());
        }

        private void btn_SearchDesign_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_SearchDesignName.Text))
            {
                SearchDesigns("");

            }
            else
            {
                SearchDesigns(txt_SearchDesignName.Text.ToString());
            }


        }

        private void txt_SearchDesignName_Click(object sender, EventArgs e)
        {
            txt_SearchDesignName.Text = "";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_SearchDesignName.Text = "";
            SearchDesigns(txt_SearchDesignName.Text.ToString());
        }

        private void txt_SearchDesignName_MouseClick(object sender, MouseEventArgs e)
        {
            txt_SearchDesignName.Text = "";
        }

        #endregion

        #region Search Designs
        async Task SearchDesigns(string searchstring)
        {
            DeleteCards();
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
                r = await Service.SearchDesigns(searchstring);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Message == "success")
                {
                    
                    ModelResponseSearchDesigns Response = new ModelResponseSearchDesigns();
                    Response = r.Content as ModelResponseSearchDesigns;
                    if (Response.Content != null)
                    {
                        bool isImageProcessed = false;
                        for (int i = 0; i < Response.Content.Count; i++)
                        {
                            byte[] ImageData = null; // Initialize ImageData to null or an empty array
                            ModelDesignUpload obj = new ModelDesignUpload();
                            obj = Response.Content[i];
                            if (obj.Image != null && obj.Image.Count > 0 && isImageProcessed == false) // Ensure there's at least one image
                            {
                                ModelDesignUploadImage modelDesignUploadImage = new ModelDesignUploadImage();
                                modelDesignUploadImage = obj.Image[0]; // Access the first image
                                ImageData = modelDesignUploadImage.ImageData;
                                isImageProcessed = false;
                            }

                            // Handle nullable float (TriggerPresentage) by providing a default value if null
                            float triggerPercentage = obj.TriggerPresentage ?? 0.0f;
                            float DesignArea = obj.DesignArea ?? 0.0f;
                            float TriggerDesignArea = obj.TriggerDesignArea ?? 0.0f;

                            AddImageCard(Convert.ToInt32(obj.Id), obj.Name, triggerPercentage, obj.CreatedDate, DesignArea, TriggerDesignArea, ImageData);
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
                    MessageBox.Show("Error! Get Search Designs Process Failed - Bad Request |  Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error! Get Search Designs Process Failed - Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Add Design Card
        private void AddImageCard(int DesignID, string Name, float TriggerPercentage, string CreatedDate, float DesignArea, float TriggerDesignArea, byte[] ImageData)
        {
            // Create a new instance of Form1
            DesignHomeCard newForm = new DesignHomeCard(DesignID, Name, TriggerPercentage, CreatedDate, DesignArea, TriggerDesignArea, ImageData);

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

        #region Remove Cards
        private void DeleteCards()
        {
            for (int i = panel.Controls.Count - 1; i >= 0; i--)
            {
                // Check if the control is of type DesignHomeCard
                if (panel.Controls[i] is DesignHomeCard)
                {
                    // Remove the DesignHomeCard control from the panel
                    panel.Controls.RemoveAt(i);
                }
            }
        }
        #endregion
    }
}

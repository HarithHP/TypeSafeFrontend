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
using TypeSafeFrontend.Models.Responses;
using TypeSafeFrontend.Models;
using System.Diagnostics.Metrics;

namespace TypeSafeFrontend.Views
{
    public partial class SummaryDesign : Form
    {
        int DesignID;
        int DesignID2;
        string DesignName;
        float TriggerPercentage;
        string CreatedDate;
        float DesignArea;
        float TriggerDesignArea;
        byte[] ImageData;
        public SummaryDesign(int DesignID, string Name, float TriggerPercentage, string CreatedDate, float DesignArea, float TriggerDesignArea, byte[] ImageData)
        {
            InitializeComponent();
            this.DesignID = DesignID;
            this.DesignName = Name;
            this.TriggerPercentage = TriggerPercentage; 
            this.CreatedDate = CreatedDate;
            this.DesignArea = DesignArea;
            this.TriggerDesignArea = TriggerDesignArea;
            this.ImageData = ImageData;
            if (ImageData != null && ImageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
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
            GetDesignSummary(DesignID);
        }

        #region Get Summary Details
        async Task GetDesignSummary(int DesignID)
        {
            DataGridView_DesignList.Rows.Clear();

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
                r = await Service.GetDesignSummary(DesignID);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Message == "success")
                {
                    ModelResponseSearchDesigns Response = new ModelResponseSearchDesigns();
                    Response = r.Content as ModelResponseSearchDesigns;
                    if (Response.Content != null)
                    {
                        DataGridView_DesignList.Rows.Clear();
                        for (int i = 0; i < Response.Content.Count; i++)
                        {
                            ModelDesignUpload obj = new ModelDesignUpload();
                            obj = Response.Content[i];
                            DataGridView_DesignList.Rows.Add(obj.Id, obj.Name, obj.CreatedDate, $"{obj.DesignArea} Pixels", $"{obj.TriggerDesignArea} Pixels", $"{obj.TriggerPresentage:F2} %");
                        }
                    }
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Message == "NoContent")
                {
                    //MessageBox.Show("Waring! Data Not available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    MessageBox.Show("Error! You do not have permission to access this Application | Please Contact the Support Team", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    MessageBox.Show("Error! Get Design Summary Process Failed - Bad Request |  Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error! Get Design Summary Process Failed - Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Get Design Summary Process Failed - Something went wrong | Please Contact the Support Team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Action Events
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DataGridView_DesignList_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataGridView_DesignList.Rows.Count > 0)
            {

                int selectedrowindex = DataGridView_DesignList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DataGridView_DesignList.Rows[selectedrowindex];
                DesignID2 = Convert.ToInt32(selectedRow.Cells[0].Value);
                txt_DesignName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                if (DateTimeOffset.TryParse(Convert.ToString(selectedRow.Cells[2].Value), out DateTimeOffset parsedDate))
                {
                    txt_CreatedDate.Text = parsedDate.ToString("MMMM dd, yyyy, h:mm tt");
                }
                else
                {
                    txt_CreatedDate.Text = Convert.ToString(selectedRow.Cells[2].Value); // Fallback if parsing fails
                }
                txt_TotalArea.Text = $"{Convert.ToString(selectedRow.Cells[3].Value)} ";
                txt_TriggerArea.Text = $"{Convert.ToString(selectedRow.Cells[4].Value)} ";
                txt_TriggerPrecentage.Text = $"{Convert.ToString(selectedRow.Cells[5].Value)}";
            }
        }

        private void DataGridView_DesignList_KeyUp(object sender, KeyEventArgs e)
        {
            int selectedrowindex = DataGridView_DesignList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DataGridView_DesignList.Rows[selectedrowindex];
            DesignID2 = Convert.ToInt32(selectedRow.Cells[0].Value);
            txt_DesignName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            if (DateTimeOffset.TryParse(Convert.ToString(selectedRow.Cells[2].Value), out DateTimeOffset parsedDate))
            {
                txt_CreatedDate.Text = parsedDate.ToString("MMMM dd, yyyy, h:mm tt");
            }
            else
            {
                txt_CreatedDate.Text = Convert.ToString(selectedRow.Cells[2].Value); // Fallback if parsing fails
            }
            txt_TotalArea.Text = $"{Convert.ToString(selectedRow.Cells[3].Value)} ";
            txt_TriggerArea.Text = $"{Convert.ToString(selectedRow.Cells[4].Value)} ";
            txt_TriggerPrecentage.Text = $"{Convert.ToString(selectedRow.Cells[5].Value)}";
        }

        private void DataGridView_DesignList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = DataGridView_DesignList.Rows[selectedRowIndex];

                int designId = Convert.ToInt32(selectedRow.Cells[0].Value); // Design ID
                string name = Convert.ToString(selectedRow.Cells[1].Value); // Name
                string createdDate = Convert.ToString(selectedRow.Cells[2].Value); // Created Date

                // Remove "Pixels" from the string and parse the numeric part
                string designAreaStr = Convert.ToString(selectedRow.Cells[3].Value).Replace(" Pixels", "").Trim();
                float designArea;
                float.TryParse(designAreaStr, out designArea); // Design Area

                string triggerDesignAreaStr = Convert.ToString(selectedRow.Cells[4].Value).Replace(" Pixels", "").Trim();
                float triggerDesignArea;
                float.TryParse(triggerDesignAreaStr, out triggerDesignArea); // Trigger Design Area

                string triggerPercentageStr = Convert.ToString(selectedRow.Cells[5].Value).Replace(" %", "").Trim();
                float triggerPercentage;
                float.TryParse(triggerPercentageStr, out triggerPercentage); // Trigger Design Area

                // Initialize the form with appropriate data
                DesignsUI designUIsView = new DesignsUI(designId, name, triggerPercentage, createdDate, designArea, triggerDesignArea, ImageData);
                designUIsView.ShowDialog();
            }
        }

        private void btn_AddDesign_Click(object sender, EventArgs e)
        {
            AddNewDesign addNewDesign = new AddNewDesign(DesignName, DesignID);
            addNewDesign.ShowDialog();
        }

        private void lbl_DesignHistory_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}

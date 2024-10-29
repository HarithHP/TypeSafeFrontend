using MC_Admin.Manager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeSafeFrontend.Models;
using TypeSafeFrontend.Services;

namespace TypeSafeFrontend.Views
{
    public partial class AddNewDesign : Form
    {
        private readonly List<ModelDesignUploadImage> selectedImages = new();
        private int count = 1;
        private static readonly HttpClient client = new HttpClient();
        private readonly string DesignName = null;
        private readonly int DesignID = 0;

        public AddNewDesign(string DesignName, int DesignID)
        {
            InitializeComponent();
            this.DesignName = DesignName;
            this.DesignID = DesignID;
            if (DesignName != "None" &&  DesignID != 0) 
            { 
                txt_DesignName.Text = DesignName;
                txt_DesignName.Enabled = false;
            }
        }

        #region Action Events

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DataGridView_ImagesList.Rows.Clear();
            selectedImages.Clear();
            txt_figmaLink.Clear();
            txt_DesignName.Clear();
            count = 1;
        }
        private void lbl_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void lbl_Upload_Click(object sender, EventArgs e)
        {
            uploadDesign();
        }
        private void DataGridView_ImagesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this image?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedRowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = DataGridView_ImagesList.Rows[selectedRowIndex];
                    int iamgeId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    selectedImages.RemoveAll(img => img.Id == iamgeId);
                    DataGridView_ImagesList.Rows.RemoveAt(selectedRowIndex);
                }
            }
        }
        private async void btn_Save_Designs_Click_1(object sender, EventArgs e)
        {
            DisableUI();
            pictureBox_Loading.Visible = true;
            if (String.IsNullOrWhiteSpace(txt_DesignName.Text))
            {
                txt_DesignName.Focus();
                MessageBox.Show("Please enter the figma design name.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedImages.Count == 0)
            {
                MessageBox.Show("No images have been uploaded.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModelDesignUpload modelDesignUpload = new ModelDesignUpload();
                List<ModelDesignUploadImage> uploadedImages = new List<ModelDesignUploadImage>();
                modelDesignUpload.Name = txt_DesignName.Text;
                if(DesignID != 0)
                {
                    modelDesignUpload.Ref_Design_Id = DesignID;
                }
                modelDesignUpload.UserId = ApiManager.UserId;
                modelDesignUpload.DesignArea = 1000.00f;// HardCode
                modelDesignUpload.TriggerDesignArea = 100.00f;// HardCode
                modelDesignUpload.TriggerPresentage = 10f;// HardCode

                foreach (var image in selectedImages)
                {
                    ModelDesignUploadImage modelDesignUploadImage = new ModelDesignUploadImage
                    {
                        Id = image.Id,
                        FileName = image.FileName,
                        ImageData = image.ImageData,
                        TriggerImageData = image.ImageData,
                        ImageArea = 200.00f,
                        TriggerImageArea = 20.00f,
                        TriggerImagePresentage = 10.00f,
                        TriggerImagePossibilty = 99.00f,
                        IsTriggerImagePossibilty = true
                    };
                    uploadedImages.Add(modelDesignUploadImage);
                }
                modelDesignUpload.Image = uploadedImages;
                DesignService designService = new DesignService();
                designService.ManageInsertDesign(modelDesignUpload);
            }
            DataGridView_ImagesList.Rows.Clear();
            selectedImages.Clear();
            txt_figmaLink.Clear();
            txt_DesignName.Clear();
            count = 1;
            EnableUI();
            pictureBox_Loading.Visible = false;
        }
        private void pictureBox_Upload_Click(object sender, EventArgs e)
        {
            uploadDesign();
        }

        #endregion

        #region Upload Images to List

        private void uploadDesign()
        {
            using OpenFileDialog openFileDialog = new()
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
                Title = "Select Design Images",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            selectedImages.Clear();

            foreach (string filePath in openFileDialog.FileNames)
            {
                selectedImages.Add(new ModelDesignUploadImage
                {
                    Id = count++,
                    FileName = Path.GetFileName(filePath),
                    ImageData = File.ReadAllBytes(filePath)
                });
            }

            foreach (var image in selectedImages)
            {
                DataGridView_ImagesList.Rows.Add(image.Id, image.FileName);
            }
        }

        #endregion

        #region Load Access Token from Figma
        private string LoadAccessToken()
        {
            string folderPath = @"C:\TypeSafe";
            string jsonFilePath = Path.Combine(folderPath, "FigmaToken.json");
            string accessToken = null;

            // Ensure the folder and file exist
            if (Directory.Exists(folderPath) && File.Exists(jsonFilePath))
            {
                try
                {
                    JObject jsonObject = JObject.Parse(File.ReadAllText(jsonFilePath));

                    // Check if accessToken exists in the JSON
                    JToken accessTokenToken = jsonObject["accessToken"];
                    if (accessTokenToken != null)
                    {
                        accessToken = accessTokenToken.ToString();
                    }
                    else
                    {
                        accessToken = null;
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show("Error reading accessToken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Error reading accessToken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return accessToken;
        }

        #endregion

        #region Get Images From Figma

        private async void btn_FigmaUpload_Click(object sender, EventArgs e)
        {


            // Always reload the access token before making a new request
            string accessToken = LoadAccessToken();

            if (accessToken != null)
            {
                // Disable UI elements to prevent user interaction
                DisableUI();

                // Show loading animation
                pictureBox_Loading.Visible = true;
                try
                {
                    client.DefaultRequestHeaders.Remove("X-Figma-Token"); // Ensure old token is removed
                    client.DefaultRequestHeaders.Add("X-Figma-Token", accessToken);

                    string figmaUrl = txt_figmaLink.Text;
                    string fileKey = GetFigmaFileKey(figmaUrl);

                    if (fileKey != null)
                    {
                        var response = await client.GetStringAsync($"https://api.figma.com/v1/files/{fileKey}");
                        var json = JObject.Parse(response);

                        // Create a new folder for the download path
                        string folderName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                        string downloadPath = Path.Combine(@"C:\TypeSafe", folderName);

                        if (!Directory.Exists(downloadPath))
                        {
                            Directory.CreateDirectory(downloadPath);
                        }

                        // Download frames and save them, also add them to selectedImages
                        var frames = json["document"]["children"];
                        await DownloadFrames(frames, downloadPath, fileKey);

                        MessageBox.Show($"Images successfully downloaded to {downloadPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Figma URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Network error: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException uaEx)
                {
                    MessageBox.Show($"Access error: {uaEx.Message}. Please ensure you have permissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show($"File error: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Re-enable UI and hide the loading animation
                    pictureBox_Loading.Visible = false;
                    EnableUI();
                }
            }
            else
            {
                MessageBox.Show("Error reading accessToken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox_Loading.Visible = false; // Ensure it's hidden if there's an error
                EnableUI();
            }
        }

        private void DisableUI()
        {
            // Disable all UI controls
            btn_FigmaUpload.Enabled = false;
            txt_figmaLink.Enabled = false;
            btn_Save_Designs.Enabled = false;
            DataGridView_ImagesList.Enabled = false;
        }

        private void EnableUI()
        {
            // Re-enable all UI controls
            btn_FigmaUpload.Enabled = true;
            txt_figmaLink.Enabled = true;
            btn_Save_Designs.Enabled = true;
            DataGridView_ImagesList.Enabled = true;
        }


        private async Task DownloadFrames(JToken frames, string downloadPath, string fileKey)
        {
            try
            {
                foreach (var frame in frames)
                {
                    if (frame["type"].ToString() == "FRAME")
                    {
                        string frameName = frame["name"].ToString();
                        string imageUrl = $"https://api.figma.com/v1/images/{fileKey}?ids={frame["id"]}&scale=1";

                        // Add a small delay between downloads to avoid rate limiting
                        await Task.Delay(500); // 500 milliseconds delay

                        var imageResponse = await client.GetStringAsync(imageUrl);
                        var imageJson = JObject.Parse(imageResponse);
                        var imgUrl = imageJson["images"][frame["id"].ToString()].ToString();

                        var imageBytes = await client.GetByteArrayAsync(imgUrl);
                        string imagePath = Path.Combine(downloadPath, $"{frameName}.png");

                        // Save the image file
                        await File.WriteAllBytesAsync(imagePath, imageBytes);

                        // Add image to the selectedImages list
                        var newImage = new ModelDesignUploadImage
                        {
                            Id = count++,  // Increment the image count
                            FileName = frameName,
                            ImageData = imageBytes
                        };

                        selectedImages.Add(newImage);

                        // Add image details to the DataGridView
                        DataGridView_ImagesList.Rows.Add(newImage.Id, newImage.FileName);
                    }

                    // Recursively check for nested frames
                    if (frame["children"] != null)
                    {
                        await DownloadFrames(frame["children"], downloadPath, fileKey);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Network error while downloading frames: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"File write error: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error while downloading frames: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        static string GetFigmaFileKey(string figmaUrl)
        {
            try
            {
                // Regular expression to match the file key part in both /file/ and /design/ Figma URLs
                string pattern = @"https:\/\/www\.figma\.com\/(file|design)\/([a-zA-Z0-9]+)";
                Match match = Regex.Match(figmaUrl, pattern);

                // If a match is found, return the file key
                if (match.Success && match.Groups.Count > 2)
                {
                    return match.Groups[2].Value;
                }

                // Return null if no match is found
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error extracting Figma file key: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




        #endregion


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

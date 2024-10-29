using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_Admin.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            checkCreateFigmaJson();

        }

        #region Timer

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Start();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            if (aloneProgressBar.Value < 100)
            {
                aloneProgressBar.Value += 1;
            }
            else
            {
                splashTimer.Stop();
                this.Hide();
                Login wScreen = new Login();
                wScreen.ShowDialog();
            }
        }
        #endregion

        #region Figma Token with File Structure
        static void CreateJsonFile(string jsonFilePath)
        {
            // Create an empty JSON object with accessToken set to null
            JObject jsonObject = new JObject
            {
                ["accessToken"] = null
            };
            File.WriteAllText(jsonFilePath, jsonObject.ToString());
        }

        public void checkCreateFigmaJson()
        {
            string folderPath = @"C:\TypeSafe";
            string jsonFilePath = Path.Combine(folderPath, "FigmaToken.json");

            // Check if the folder exists
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine("Folder does not exist. Creating folder...");
                Directory.CreateDirectory(folderPath);
            }

            // Check if the JSON file exists
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("JSON file does not exist. Creating JSON file...");
                CreateJsonFile(jsonFilePath);
            }

            // Check if the JSON file contains the accessToken field
            JObject jsonObject = JObject.Parse(File.ReadAllText(jsonFilePath));
            if (jsonObject["accessToken"] == null)
            {
                Console.WriteLine("accessToken not found. Adding accessToken with null value...");
                jsonObject["accessToken"] = null;
                File.WriteAllText(jsonFilePath, jsonObject.ToString());
            }
            else
            {
                Console.WriteLine("accessToken already exists.");
            }
        }
        #endregion


    }
}

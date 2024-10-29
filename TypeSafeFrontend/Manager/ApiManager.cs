using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using System.Management;

namespace MC_Admin.Manager
{
    public sealed class ApiManager
    {
        private string Environment = MCEnvironment.Development.ToString();
        private string BaseUrl = "";
        public static int UserId;
        public static string UserName;
        public static string Lastname;
        public static string AccessToken;
        public static string Email;
        public static string AccessType;
        public static string DeviceToken;

        /* ############# !!!!! IMPORTANT !!!!! ############
        * 
        * when adding to UAT note ##########
        * 
        * 
        */

        /* ############# !!!!! IMPORTANT !!!!! ############
         * 
         * when adding to LIVE note ##########
         * 
         *
         */

        private ApiManager() { }
        private static ApiManager instance = null;
        public static ApiManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApiManager();
                }
                return instance;
            }
        }

        #region SetEnvironmentAndBaseUrl
        public void SetEnvironmentAndBaseUrl(string environment, string baseUrl)
        {
            if (!string.IsNullOrEmpty(environment))
            {
                this.Environment = environment;
            }
            if (!string.IsNullOrEmpty(baseUrl))
            {
                this.BaseUrl = baseUrl;
            }
        }
        #endregion

        #region GetAPIBaseURL
        internal string GetAPIBaseURL()
        {
            if (this.Environment == MCEnvironment.Live.ToString())
            {

                return @"https://localhost:7218/api/";
            }
            else if (this.Environment == MCEnvironment.UAT.ToString())
            {
                return "";// not set
            }
            else if (this.Environment == MCEnvironment.Development.ToString())
            {

 
                return @"https://localhost:7218/api/";
            }
            else
            {
                return "";// not set
            }
        }
        #endregion

        #region GetCustomToken
        public string GetCustomToken()
        {
            if (this.Environment == MCEnvironment.Live.ToString())
            {
                return "EyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ";
            }
            else if (this.Environment == MCEnvironment.UAT.ToString())
            {
                return "";// not set
            }
            else if (this.Environment == MCEnvironment.Development.ToString())
            {
                return "EyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ";
            }
            else
            {
                return "";// not set
            }
        }
        #endregion

        #region GetExceptionToken
        public string GetExceptionToken()
        {
            if (this.Environment == MCEnvironment.Live.ToString())
            {
                return "3r3dNHOZJnp0kWC5D2nt2sVPkjd2L9sLUEnjDogpymJMMeL5YcJoTtBMsVXLytIr8j8c2aoRDjJMdPIQa6NaEffRP8TLOIm2qjLJA9AorqpMir4n9aEpLQljKhL9HghklA7QzQflEbif6DO3DRNt3Uz0Eoxn55QCQPtxPGKC86bPTiNxsdO5ElMrA6gcCnQSbe5rbfiX";
            }
            else if (this.Environment == MCEnvironment.UAT.ToString())
            {
                return "";// not set
            }
            else if (this.Environment == MCEnvironment.Development.ToString())
            {
                return "3r3dNHOZJnp0kWC5D2nt2sVPkjd2L9sLUEnjDogpymJMMeL5YcJoTtBMsVXLytIr8j8c2aoRDjJMdPIQa6NaEffRP8TLOIm2qjLJA9AorqpMir4n9aEpLQljKhL9HghklA7QzQflEbif6DO3DRNt3Uz0Eoxn55QCQPtxPGKC86bPTiNxsdO5ElMrA6gcCnQSbe5rbfiX";
            }
            else
            {
                return "";// not set
            }
        }
        #endregion

        #region GetActivityLogToken
        public string GetActivityLogToken()
        {
            if (this.Environment == MCEnvironment.Live.ToString())
            {
                return "9OniYnpXysaUABIlmbZ6Q8Kyq5FZmHy1eyYkJQ46G7aaA43s9Nlp9Tub6DDgGAvLKD0RTpaqfr6tcRxcORTKNlNFiseGDT8u8ZeI00wLMs1fee4RCUPf6TmQTHpFkUOpRhpTEtnpNudJUbXgazXu3QAwLuDKdbFArwn1cJTXuib014i7FAO7V6y6fJn4PLLeBZfpf97B";
            }
            else if (this.Environment == MCEnvironment.UAT.ToString())
            {
                return "";// not set
            }
            else if (this.Environment == MCEnvironment.Development.ToString())
            {
                return "9OniYnpXysaUABIlmbZ6Q8Kyq5FZmHy1eyYkJQ46G7aaA43s9Nlp9Tub6DDgGAvLKD0RTpaqfr6tcRxcORTKNlNFiseGDT8u8ZeI00wLMs1fee4RCUPf6TmQTHpFkUOpRhpTEtnpNudJUbXgazXu3QAwLuDKdbFArwn1cJTXuib014i7FAO7V6y6fJn4PLLeBZfpf97B";
            }
            else
            {
                return "";// not set
            }
        }
        #endregion

        #region GetDeviceToken
        internal string GetDeviceToken()
        {
            try
            {
                using (ManagementObjectSearcher boardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard"))
                using (ManagementObjectCollection boardCollection = boardSearcher.Get())
                using (ManagementObjectSearcher userSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem"))
                using (ManagementObjectCollection userCollection = userSearcher.Get())
                {
                    string motherboardCode = "";
                    foreach (ManagementObject boardObj in boardCollection)
                    {
                        // Use a property from Win32_BaseBoard to get motherboard information
                        motherboardCode = boardObj["SerialNumber"].ToString();
                        break;  // Assuming there's only one motherboard
                    }

                    string userCountName = "";
                    foreach (ManagementObject userObj in userCollection)
                    {
                        // Use a property from Win32_ComputerSystem to get user count information
                        userCountName = userObj["UserName"].ToString();
                        break;  // Assuming there's only one user
                    }

                    if (!string.IsNullOrEmpty(motherboardCode) && !string.IsNullOrEmpty(userCountName))
                    {
                        // Combine motherboard code and user count name to form the device token
                        string guid = motherboardCode.ToUpper();
                        string key = $"{{{guid}}}/*~*/{userCountName}";
                        return key;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting device token: " + ex.Message);
                // Handle the exception as needed (rethrow, log, etc.)
            }

            return "UnknownDeviceToken";
        }
        #endregion

        #region SetLoginInfo
        internal void SetUserData(int userId, string userName, string lastName, string accessToken, string email, string accessType, string deviceToken)
        {
            UserId = userId;
            UserName = userName;
            Lastname = lastName;
            AccessToken = accessToken;
            AccessType = accessType;
            Email = email;
            DeviceToken = deviceToken;

        }
        #endregion

        #region Get DateTime Now
        internal string GetDateTime()
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            return formattedDateTime;
        }
        #endregion

        internal enum APIResponse
        {
            Success,
            Fail
        }

        internal enum MCEnvironment
        {
            Live,
            UAT,
            Development,
        }

    }
}

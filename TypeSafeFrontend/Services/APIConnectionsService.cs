using MC_Admin.Models.Responses;
using MC_Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MC_Admin.Manager;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using MC_Admin.Views;
using TypeSafeFrontend.Models;
using TypeSafeFrontend.Models.Responses;

namespace MC_Admin.Services
{
    internal class APIConnectionsService
    {
        private readonly string serviceName = "APIConnectionsService --> ";
        private readonly string BaseUrl;
        private readonly string CustomToken;
        private readonly string DeviceToken;
        private readonly string ActivityLogToken;
        private readonly string AccessToken;
        private readonly string AuthToken;
        private readonly string Email;


        public APIConnectionsService()
        {
            BaseUrl = ApiManager.Instance.GetAPIBaseURL();
            CustomToken = ApiManager.Instance.GetCustomToken();
            ActivityLogToken = ApiManager.Instance.GetActivityLogToken();
            DeviceToken =  ApiManager.Instance.GetDeviceToken();
            AccessToken = ApiManager.AccessToken;
        }

        #region Authentication

        #region Handle SignIn 
        internal async Task<ResponseResult> SignIn(ModelEmployee model)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("AuthToken", CustomToken);
                    string apiUrl = string.Concat(BaseUrl, "User/Login?email="+model.Email+"&password="+model.Password);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var Userresponce = await response.Content.ReadAsStringAsync();
                        ResponseSignIn user = JsonConvert.DeserializeObject<ResponseSignIn>(Userresponce);
                        if (user.Status == "Success" && user.Message== "success")
                        {

                            ApiManager.Instance.SetUserData(Convert.ToInt16(user.Content.Id), user.Content.FirstName, user.Content.LastName, user.Content.AuthToken, user.Content.Email, "Default","Default");
                            r.Status = ApiManager.APIResponse.Success.ToString();
                            r.Content = "success";
                            r.Message = "success";
                        }
                        else
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "failed";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource
                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = "fail";
                }
            }

            return r;
        }

        #endregion

        #region Handle Sign Up
        internal async Task<ResponseResult> SignUp(ModelUser employee)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("AuthToken", CustomToken);
                    string apiUrl = string.Concat(BaseUrl, "User/Insert");
                    string jsonContent = JsonSerializer.Serialize(employee);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var Userresponce = await response.Content.ReadAsStringAsync();
                        ResponseResult respond = JsonConvert.DeserializeObject<ResponseResult>(Userresponce);

                        if (respond.Status == "Success" && respond.Message == "success")
                        {
                            r.Status = ApiManager.APIResponse.Success.ToString();
                            r.Content = null;
                            r.Message = "success";
                        }
                        else
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = "fail";
                            r.Message = respond.Message.ToString();
                        }
                    }

                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource
              

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = ex.Message.ToString();
                }
            }

            return r;
        }
        #endregion

        #region Handle Account Update
        internal async Task<ResponseResult> UpdateAccount(ModelEmployee modelEmployee)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    string apiUrl = string.Concat(BaseUrl, "User/UserUpdate");
                    string jsonContent = JsonSerializer.Serialize(modelEmployee);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var Userresponce = await response.Content.ReadAsStringAsync();
                        ResponseResult user = JsonConvert.DeserializeObject<ResponseResult>(Userresponce);
                        if (user.Status == "Success" && user.Message == "Success")
                        {
                            r.Status = ApiManager.APIResponse.Success.ToString();
                            r.Content = "success";
                            r.Message = "success";
                        }
                        else
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "failed";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource
 

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = ex.Message.ToString();
                }
            }

            return r;
        }

        #endregion

        #region Handle Change Password 
        internal async Task<ResponseResult> ChangePassword(ModelChangePassword modelChangePassword)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    string apiUrl = string.Concat(BaseUrl, "User/ResetPassword?currentPassword="+ modelChangePassword.OldPassword+"&newPassword="+ modelChangePassword.NewPassword);
                    HttpResponseMessage response = await client.PutAsync(apiUrl, null);

                    if (response.IsSuccessStatusCode)
                    {
                        var Userresponce = await response.Content.ReadAsStringAsync();
                        ResponseResult user = JsonConvert.DeserializeObject<ResponseResult>(Userresponce);
                        if (user.Status == "Success" && user.Message == "Success")
                        {
                            r.Status = ApiManager.APIResponse.Success.ToString();
                            r.Content = "success";
                            r.Message = "success";
                        }
                        else
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "failed";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = "fail";
                }
            }

            return r;
        }

        #endregion

        #endregion

        #region Design

        #region Handle Insert Design
        internal async Task<ResponseResult> InsertDesign (ModelDesignUpload modelDesignUpload)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    string apiUrl = string.Concat(BaseUrl, "Design/Insert/Design");
                    string jsonContent = JsonSerializer.Serialize(modelDesignUpload);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var Userresponce = await response.Content.ReadAsStringAsync();
                        ResponseResult respond = JsonConvert.DeserializeObject<ResponseResult>(Userresponce);

                        if (respond.Status == "Success" && respond.Message == "success")
                        {
                            r.Status = ApiManager.APIResponse.Success.ToString();
                            r.Content = null;
                            r.Message = "success";
                        }
                        else
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = "fail";
                            r.Message = respond.Message.ToString();
                        }
                    }

                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = ex.Message;
                }
            }

            return r;
        }
        #endregion

        #region Search Designs
        internal async Task<ResponseResult> SearchDesigns(string date)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = string.Concat(BaseUrl, "Design/Search?UserId="+ ApiManager.UserId + "&searchString=" + date);
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        ModelResponseSearchDesigns List_Obj = JsonConvert.DeserializeObject<ModelResponseSearchDesigns>(ResponseContent);

                        if (List_Obj.Status == "Success" && List_Obj.Message == "success")
                        {
                            if (List_Obj.Content != null)
                            {
                                if (List_Obj.Content.Count > 0)
                                {
                                    r.Status = ApiManager.APIResponse.Success.ToString();
                                    r.Content = List_Obj;
                                    r.Message = "success";
                                }
                            }
                           
                        }
                        else if (List_Obj.Status == "Success")
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "NoContent";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = "fail";
                }
            }

            return r;
        }
        #endregion

        #region Get Design Summary
        internal async Task<ResponseResult> GetDesignSummary(int id)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = string.Concat(BaseUrl, "Design/Get/MainSubDesigns?DesignID=" + id);
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        ModelResponseSearchDesigns List_Obj = JsonConvert.DeserializeObject<ModelResponseSearchDesigns>(ResponseContent);

                        if (List_Obj.Status == "Success" && List_Obj.Message == "success")
                        {
                            if (List_Obj.Content != null)
                            {
                                if (List_Obj.Content.Count > 0)
                                {
                                    r.Status = ApiManager.APIResponse.Success.ToString();
                                    r.Content = List_Obj;
                                    r.Message = "success";
                                }
                            }

                        }
                        else if (List_Obj.Status == "Success")
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "NoContent";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = "fail";
                }
            }

            return r;
        }
        #endregion

        #region Get Sub Design Summary
        internal async Task<ResponseResult> GetSubDesigns(int id)
        {
            ResponseResult r = new ResponseResult();
            r = new()
            {
                Status = ApiManager.APIResponse.Fail.ToString(),
                Content = null,
                Message = "Error! Something Went Wrong"
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = string.Concat(BaseUrl, "Design/Get/SubDesignsUIs?DesignID=" + id);
                    client.DefaultRequestHeaders.Add("AuthToken", ApiManager.AccessToken.ToString());
                    client.DefaultRequestHeaders.Add("Email", ApiManager.Email.ToString());
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var ResponseContent = await response.Content.ReadAsStringAsync();
                        ModelResponseSubDesigns List_Obj = JsonConvert.DeserializeObject<ModelResponseSubDesigns>(ResponseContent);

                        if (List_Obj.Status == "Success" && List_Obj.Message == "success")
                        {
                            if (List_Obj.Content != null)
                            {
                                if (List_Obj.Content.Count > 0)
                                {
                                    r.Status = ApiManager.APIResponse.Success.ToString();
                                    r.Content = List_Obj;
                                    r.Message = "success";
                                }
                            }

                        }
                        else if (List_Obj.Status == "Success")
                        {
                            r.Status = ApiManager.APIResponse.Fail.ToString();
                            r.Content = null;
                            r.Message = "NoContent";
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Unauthorized";
                        r.Message = "Unauthorized"; // Unauthorized: You do not have permission to access this Resource

                    }
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = "Bad Request";
                        r.Message = "Bad Request"; //Bad Request: The request is invalid or missing required Data
                    }
                    else
                    {
                        r.Status = ApiManager.APIResponse.Fail.ToString();
                        r.Content = response.StatusCode;
                        r.Message = "fail";
                    }
                }
                catch (Exception ex)
                {
                    r.Status = ApiManager.APIResponse.Fail.ToString();
                    r.Content = null;
                    r.Message = "fail";
                }
            }

            return r;
        }
        #endregion

        #endregion

    }
}

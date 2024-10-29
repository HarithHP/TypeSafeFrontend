using MC_Admin.Manager;
using MC_Admin.Models;
using MC_Admin.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeSafeFrontend.Models;

namespace MC_Admin.Services
{
    internal class AuthService
    {
        private readonly string serviceName = "AuthService --> ";

        #region Manage Sign In Process
        internal async Task<int> ManageSignIn(ModelEmployee model)
        {
            int n = 0;
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
                r = await Service.SignIn(model);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Content == "success" && r.Message == "success")
                {
                    n = 1;
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == null && r.Message == "failed")
                {
                    n = 3; // Password or UserName Incorrect
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    n = 4; // User do not have permission to access this Resource
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    n = 5; //The request is invalid or missing required Data
                }
                else
                {
                    n = 6;//Unknown Error
                }

            }
            catch (Exception ex)
            {
                n = 6;//Unknown Error
            }
            return n;
        }
        #endregion

        #region Manage Sign Up Process
        internal async Task<int> ManageSignUp(ModelUser model)
        {
            int n = 0;
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
                r = await Service.SignUp(model);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Content == null && r.Message == "success")
                {
                    n = 1;
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == null && r.Message == "failed")
                {
                    n = 3; // Data Error
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    n = 4; // User do not have permission to access this Resource
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    n = 5; //The request is invalid or missing required Data
                }
                else
                {
                    n = 6;//Unknown Error
                }

            }
            catch (Exception ex)
            {
                n = 6;//Unknown Error
            }
            return n;
        }
        #endregion

        #region Manage Update Account
        internal async Task<int> UpdateAccount(ModelEmployee modelEmployee)
        {
            int n = 0;
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
                r = await Service.UpdateAccount(modelEmployee);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Content == "success" && r.Message == "success")
                {
                    n = 1;// Password Updated Successfully
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == null && r.Message == "failed")
                {
                    n = 2; // Success process but Invalid Password.
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    n = 3; // User do not have permission to access this Resource
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    n = 4; //The request is invalid or missing required Data
                }
                else
                {
                    n = 5;//Unknown Error
                }

            }
            catch (Exception ex)
            {

            }
            return n;
        }
        #endregion

        #region Manage Change Password
        internal async Task<int> ChangePassword(ModelChangePassword modelChangePassword)
        {
            int n = 0;
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
                r = await Service.ChangePassword(modelChangePassword);
                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Content == "success" && r.Message == "success")
                {
                    n = 1;// Password Updated Successfully
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == null && r.Message == "failed")
                {
                    n = 2; // Success process but Invalid Password.
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    n = 3; // User do not have permission to access this Resource
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    n = 4; //The request is invalid or missing required Data
                }
                else
                {
                    n = 5;//Unknown Error
                }

            }
            catch (Exception ex)
            {
            }
            return n;
        }
        #endregion
    }
}

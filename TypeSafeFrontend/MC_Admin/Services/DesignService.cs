using MC_Admin.Manager;
using MC_Admin.Models.Responses;
using MC_Admin.Models;
using MC_Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeSafeFrontend.Models;

namespace TypeSafeFrontend.Services
{
    internal class DesignService
    {
        #region Manage Design Insert
        internal async Task<int> ManageInsertDesign(ModelDesignUpload modelDesignUpload)
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
                APIConnectionsService exceptionService = new();
                r = await exceptionService.InsertDesign(modelDesignUpload);

                if (r.Status == ApiManager.APIResponse.Success.ToString() && r.Message == "success")
                {
                    MessageBox.Show("Successful! Design Added Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "fail")
                {
                    MessageBox.Show("Error! " + r.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Unauthorized" && r.Message == "Unauthorized")
                {
                    MessageBox.Show("Unknown Error! Please Contact System Support Team - Unauthorized ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.Status == ApiManager.APIResponse.Fail.ToString() && r.Content == "Bad Request" && r.Message == "Bad Request")
                {
                    MessageBox.Show("Unknown Error! Please Contact System Support Team - Bad Request ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Unknown Error! Please Contact System Support Team." + r.Content, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error! " + r.Message, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return n;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models.Responses
{
    internal class ModelResponseRoleUpdateLog
    {
        public string? Status { get; set; }//Success or Fail
        public string? Message { get; set; }//Msg of response
        public List<ModelRoleUpdateLog>? Content { get; set; } = new List<ModelRoleUpdateLog>();
    }
}

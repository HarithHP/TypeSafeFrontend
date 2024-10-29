using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models.Responses
{
    internal class ResponseEmployeeList
    {
        public string? Status { get; set; }//Success or Fail
        public string? Message { get; set; }//Msg of response
        public List<ModelEmployee>? Content { get; set; } = new List<ModelEmployee>();
    }
}

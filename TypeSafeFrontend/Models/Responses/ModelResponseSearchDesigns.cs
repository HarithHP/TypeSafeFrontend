using MC_Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeFrontend.Models.Responses
{
    internal class ModelResponseSearchDesigns
    {
        public string? Status { get; set; }//Success or Fail
        public string? Message { get; set; }//Msg of response
        public List<ModelDesignUpload>? Content { get; set; } = new List<ModelDesignUpload>();
    }
}

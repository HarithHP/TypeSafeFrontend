using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeFrontend.Models.Responses
{
    internal class ModelResponseSubDesigns
    {
        public string? Status { get; set; }//Success or Fail
        public string? Message { get; set; }//Msg of response
        public List<ModelDesignUploadImage>? Content { get; set; } = new List<ModelDesignUploadImage>();
    }
}

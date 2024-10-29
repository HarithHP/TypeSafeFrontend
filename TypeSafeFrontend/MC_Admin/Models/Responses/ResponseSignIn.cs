using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models.Responses
{
    internal class ResponseSignIn
    {
        public string? Status { get; set; }//Success or Fail
        public string? Message { get; set; }//Msg of response
        public ModelUserSignInResult? Content { get; set; }//Result 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models
{
    internal class ModelUserSignInResult
    {
        public string? AccessToken { get; set; }
        public int? Id { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public string? AuthToken { get; set; }
        public ModelEmployee? EmployeeDetails { get; set; } = new ModelEmployee();
    }
}

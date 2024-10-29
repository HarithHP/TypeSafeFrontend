using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models
{
    internal class ModelRoleUpdateLog
    {
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? BeforeAccessType { get; set; }
        public string? AfterAccessType { get; set; }
        public int? CreatedById { get; set; }
        public string? CreatedByName { get; set; }
        public string? CreatedDate { get; set; }
    }
}

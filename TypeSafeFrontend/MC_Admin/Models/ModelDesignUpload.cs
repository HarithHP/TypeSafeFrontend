using MC_Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeFrontend.Models
{
    internal class ModelDesignUpload
    {
        public int? Id { get; set; }
        public int? Ref_Design_Id { get; set; }
        public string? Name { get; set; }
        public string? CreatedDate { get; set; }
        public int? UserId { get; set; }
        public float? DesignArea { get; set; }
        public float? TriggerDesignArea { get; set; }
        public float? TriggerPresentage { get; set; }
        public List<ModelDesignUploadImage>? Image { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeSafeFrontend.Models
{
    internal class ModelDesignUploadImage
    {
        public int? DesignId { get; set; }
        public int? Id { get; set; }
        public string FileName { get; set; }
        public byte[]? ImageData { get; set; }
        public byte[]? TriggerImageData { get; set; }
        public float? ImageArea { get; set; }
        public float? TriggerImageArea { get; set; }
        public float? TriggerImagePresentage { get; set; }
        public float? TriggerImagePossibilty { get; set; }
        public bool? IsTriggerImagePossibilty{ get; set; }



    }
}

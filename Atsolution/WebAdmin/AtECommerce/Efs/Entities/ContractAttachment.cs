using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class ContractAttachment
    {
        public string AttachmentId { get; set; }
        public string ContractId { get; set; }
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string FileExtension { get; set; }
        public string FileMimetype { get; set; }
        public string Description { get; set; }
        public string FileLink { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}

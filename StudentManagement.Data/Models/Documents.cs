using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class Documents : BaseModel
    {
        [Key]
        public long DocumentId { get; set; }


        public long DocumentTypeId { get; set; }
        [ForeignKey("DocumentTypeId")]
        public virtual DocumentTypeMaster DocumentTypeMaster { get; set; }

        public string UploadPath { get; set; }
    }
}

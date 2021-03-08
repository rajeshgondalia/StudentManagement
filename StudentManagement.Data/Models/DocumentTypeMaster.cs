using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class DocumentTypeMaster:BaseModel
    {

        [Key]
        public long DocumentTypeMasterId { get; set; }

        public string DocumentTypeName { get; set; }
    }
}

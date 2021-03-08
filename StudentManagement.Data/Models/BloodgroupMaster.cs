using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class BloodgroupMaster:BaseModel
    {
        [Key]
        public long BloodgroupId { get; set; }
        public string Bloodgroup { get; set; }


    }
}

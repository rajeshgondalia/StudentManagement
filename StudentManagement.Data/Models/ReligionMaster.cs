using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class ReligionMaster:BaseModel
    {
        [Key]
        public long ReligionId { get; set; }
        public string Religion { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class CollegeMaster:BaseModel
    {
        [Key]
        public long PK_CollegeMaster { get; set; }
        public string Name { get; set; }
    }
}

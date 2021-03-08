using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class GenderMaster:BaseModel
    {
        [Key]
        public long GenId { get; set; }
        public string Name { get; set; }
    }
}

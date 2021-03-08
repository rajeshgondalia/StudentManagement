using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class CampusMaster:BaseModel
    {
        [Key]
        public long CampusId { get; set; }
        public string Name { get; set; }
    }
}

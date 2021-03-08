using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class LGRelationMaster:BaseModel
    {
        [Key]
        public long LGRelationId { get; set; }
        public string Name { get; set; }
    }
}

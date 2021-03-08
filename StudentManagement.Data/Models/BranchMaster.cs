using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class BranchMaster:BaseModel
    {
        [Key]
        public long BranchId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}

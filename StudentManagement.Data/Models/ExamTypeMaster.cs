using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class ExamTypeMaster:BaseModel
    {
        [Key]
        public long ExamTypeId { get; set; }

        public string Name { get; set; }
    }
}

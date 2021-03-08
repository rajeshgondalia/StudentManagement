using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public  class CourseMaster:BaseModel
    {
        [Key]
        public long CourseId { get; set; }
        public string    CourseName { get; set; }
    }
}

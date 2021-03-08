using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class BatchMaster:BaseModel
    {
         [Key]
        public long BatchId { get; set; }
        public string Name { get; set; }
    }
}

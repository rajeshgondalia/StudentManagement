﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
   public class CategoryMaster:BaseModel
    {
        [Key]
        public long CategoryId { get; set; }
        public string    Name { get; set; }
    }
}

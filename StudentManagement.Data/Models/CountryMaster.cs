using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class CountryMaster:BaseModel
    {
        [Key]
        public long CountryId { get; set; }
        public string CountryName { get; set; }
    }
}

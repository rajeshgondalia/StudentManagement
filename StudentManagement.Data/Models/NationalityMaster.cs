using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class NationalityMaster : BaseModel
    {
        [Key]
        public long NationalityId { get; set; }
        public string Nationality { get; set; }
    }
}

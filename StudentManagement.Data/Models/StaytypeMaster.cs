using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentManagement.Data.Models
{
    public class StaytypeMaster:BaseModel
    {
        [Key]
        public long StaytypeId { get; set; }
        public string Staytype { get; set; }

    }
}

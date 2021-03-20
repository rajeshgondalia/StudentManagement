using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagementAdmin.Data.DbModel.BaseModel
{
    public class EntityWithAudit
    {

        public long? CreatedBy { get; set; }


        public DateTime CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }


        public DateTime? ModifiedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
       

    }
}

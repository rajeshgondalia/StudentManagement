using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class HistoryPersonalDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long? PersonalDetailId { get; set; }
        [ForeignKey("PersonalDetailId")]
        public virtual PersonalDetail PersonalDetail { get; set; }

        public long? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }


        [Column(TypeName = "nvarchar(20)")]
        public string Mobile1 { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Mobile2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PersonalEmail1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PersonalEmail2 { get; set; }

        public long GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual GenderMaster GenderMaster { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime Dob { get; set; }

        public long CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual CategoryMaster CategoryMaster { get; set; }

        public long BloodGroupdId { get; set; }
        [ForeignKey("BloodGroupdId")]
        public virtual BloodgroupMaster BloodgroupMaster { get; set; }
        public long ReligionId { get; set; }
        [ForeignKey("ReligionId")]
        public virtual ReligionMaster ReligionMaster { get; set; }
        public long CityId { get; set; }
        [ForeignKey("CityId")]
        public virtual CityMaster CityMaster { get; set; }
        public long CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual CountryMaster CountryMaster { get; set; }

        public long? StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual StateMaster StateMaster { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string StatePincode { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string CountryPincode { get; set; }


        public long StayTypeId { get; set; }
        [ForeignKey("StayTypeId")]
        public virtual StaytypeMaster StaytypeMaster { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string StayAddress { get; set; }

        public long StayRelationId { get; set; }
        [ForeignKey("StayRelationId")]
        public virtual RelationMaster RelationMaster { get; set; }

        public long? CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}

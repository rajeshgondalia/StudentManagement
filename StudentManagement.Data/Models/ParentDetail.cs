using StudentManagement.Data.DBContexts;
using StudentManagementAdmin.Data.DbModel.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.Models
{
  public  class ParentDetail:EntityWithAudit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ParentDetailId { get; set; }

        public long UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FatherName { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FatherMobile1 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FatherMobile2 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FatherEmail { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string FatherAddress { get; set; }

        
        public long?  FatherCityId { get; set; }
        [ForeignKey("FatherCityId")]
        public virtual CityMaster FatherCityMaster { get; set; }

        public long? FatherStateId { get; set; }
        [ForeignKey("FatherStateId")]
        public virtual StateMaster FatherStateMaster { get; set; }

        public long? FatherCountryId { get; set; }
        [ForeignKey("FatherCountryId")]
        public virtual CountryMaster FatherCountryMaster { get; set; }




        [Column(TypeName = "varchar(50)")]
        public string FatherPincode { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string MotherName { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string MotherMobile1 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string MotherMobile2 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string MotherEmail { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string MotherAddress { get; set; }

        public long? MotherCityId { get; set; }
        [ForeignKey("MotherCityId")]
        public virtual CityMaster MotherCityMaster { get; set; }

        public long? MotherStateId { get; set; }
        [ForeignKey("MotherStateId")]
        public virtual StateMaster MotherStateMaster { get; set; }

        public long? MotherCountryId { get; set; }
        [ForeignKey("MotherCountryId")]
        public virtual CountryMaster MotherCountryMaster { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string MotherPincode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LGPincode { get; set; }


        [Column(TypeName = "nvarchar(max)")]
        public string LGName { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string LGMobile1 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string LGMobile2 { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string LGEmail { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string LGAddress { get; set; }

        public long? LGCityId { get; set; }
        [ForeignKey("LGCityId")]
        public virtual CityMaster LGCityMaster { get; set; }

        public long? LGStateId { get; set; }
        [ForeignKey("LGStateId")]
        public virtual StateMaster LGStateMaster { get; set; }

        public long? LGCountryId { get; set; }
        [ForeignKey("LGCountryId")]
        public virtual CountryMaster CountryMaster { get; set; }

        public long? RelationId { get; set; }
        [ForeignKey("RelationId")]
        public virtual RelationMaster RelationMaster { get; set; }

    }
}

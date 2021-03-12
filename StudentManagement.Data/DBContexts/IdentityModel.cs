
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagement.Data.DBContexts
{
    public class UserRole : IdentityUserRole<long> {


        [NotMapped]
        public string NormalizedName { get; set; }
        [NotMapped]
        public string ConcurrencyStamp { get; set; }

        [NotMapped]
        public string Discriminator { get; set; }

    }

    public class UserClaim : IdentityUserClaim<long> { }

    public class UserLogin : IdentityUserLogin<long> { }

    public class Role : IdentityRole<long>
    {
        
        public Role()
        {
            DisplayRoleName = "";
        }
      
        [NotMapped]
        public  string DisplayRoleName { get; set; }

        [NotMapped]
        public override  string NormalizedName { get; set; }


        [NotMapped]
        public override string ConcurrencyStamp { get; set; }



        public long? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }



    }

    public class ApplicationUser : IdentityUser<long>
    {


        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }


        [StringLength(50)]
        public string LastName { get; set; }

        [NotMapped] public string FullName => $@"{FirstName} {LastName}";


        
        public string Name { get; set; }

     
        [Required, StringLength(200)]
        public string OfficialEmail { get; set; }

        [StringLength(200)]
        public string RecoveryEmail { get; set; }

        [StringLength(15)]
        public string RecoveryMobileNo { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}

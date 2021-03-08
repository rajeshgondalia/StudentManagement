
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Data.DBContexts
{
    public class StudentDbContext : IdentityDbContext<ApplicationUser, IdentityRole<long>, long>
    {

        #region Db Sets
        public DbSet<AdmissionbatchMaster> AdmissionbatchMasters { get; set; }
        public DbSet<AdmissiontypeMaster> AdmissiontypeMaster { get; set; }
        public DbSet<BatchMaster> BatchMaster { get; set; }
        public DbSet<BloodgroupMaster> BloodgroupMaster { get; set; }
        public DbSet<BranchMaster> BranchMaster { get; set; }
        public DbSet<CampusMaster> CampusMaster { get; set; }
        public DbSet<CategoryMaster> CategoryMaster { get; set; }
        public DbSet<CityMaster> CityMaster { get; set; }
        public DbSet<CollegeDetail> CollegeDetail { get; set; }
        public DbSet<CollegeMaster> CollegeMaster { get; set; }
        public DbSet<CountryMaster> CountryMaster { get; set; }
        public DbSet<CourseMaster> CourseMaster { get; set; }
        public DbSet<DegreeMaster> DegreeMaster { get; set; }
        public DbSet<DiplomaMaster> DiplomaMaster { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<DocumentTypeMaster> DocumentTypeMaster { get; set; }
        public DbSet<DomicileMaster> DomicileMaster { get; set; }
        public DbSet<EntranceExamMaster> EntranceExamMaster { get; set; }
        public DbSet<ExamTypeMaster> ExamTypeMaster { get; set; }
        public DbSet<GenderMaster> GenderMaster { get; set; }
        public DbSet<LGRelationMaster> LGRelationMaster { get; set; }
        public DbSet<NationalityMaster> NationalityMaster { get; set; }
        public DbSet<ParentDetail> ParentDetail { get; set; }
        public DbSet<PersonalDetail> PersonalDetail { get; set; }
        public DbSet<ReligionMaster> ReligionMaster { get; set; }
       
        public DbSet<StateMaster> StateMaster { get; set; }
        public DbSet<StayrelationMaster> StayrelationMaster { get; set; }
        public DbSet<StudentAttendence> StudentAttendence { get; set; }
        public DbSet<StudentQualication> StudentQualication { get; set; }
        public DbSet<TenMaster> TenMaster { get; set; }
        public DbSet<TenPlusTwoMaster> TenPlusTwoMaster { get; set; }
       

        #endregion


        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            // Change Default filed datatype & length
            modelBuilder.Entity<ApplicationUser>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>().Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<UserClaim>().Property(x => x.ClaimType).HasMaxLength(50);
            modelBuilder.Entity<UserClaim>().Property(x => x.ClaimValue).HasMaxLength(200);

            modelBuilder.Entity<ApplicationUser>().Property(x => x.Email).HasMaxLength(100);
            modelBuilder.Entity<ApplicationUser>().Property(x => x.UserName).HasMaxLength(100);
            modelBuilder.Entity<ApplicationUser>().Property(x => x.PhoneNumber).HasMaxLength(12);



            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

    }
}


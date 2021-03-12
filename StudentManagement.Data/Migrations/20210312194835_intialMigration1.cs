using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class intialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissiontypeMaster",
                columns: table => new
                {
                    AdmissiontypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Admissiontype = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissiontypeMaster", x => x.AdmissiontypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 12, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OfficialEmail = table.Column<string>(maxLength: 200, nullable: false),
                    RecoveryEmail = table.Column<string>(maxLength: 200, nullable: true),
                    RecoveryMobileNo = table.Column<string>(maxLength: 15, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatchMaster",
                columns: table => new
                {
                    BatchId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchMaster", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "BloodgroupMaster",
                columns: table => new
                {
                    BloodgroupId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Bloodgroup = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodgroupMaster", x => x.BloodgroupId);
                });

            migrationBuilder.CreateTable(
                name: "CampusMaster",
                columns: table => new
                {
                    CampusId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusMaster", x => x.CampusId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMaster",
                columns: table => new
                {
                    CategoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CityMaster",
                columns: table => new
                {
                    CityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMaster", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "ClassMaster",
                columns: table => new
                {
                    ClassId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassMaster", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "CountryMaster",
                columns: table => new
                {
                    CountryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMaster", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "CourseMaster",
                columns: table => new
                {
                    CourseId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMaster", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "DegreeMaster",
                columns: table => new
                {
                    DegreeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeMaster", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "DiplomaMaster",
                columns: table => new
                {
                    DiplomaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiplomaMaster", x => x.DiplomaId);
                });

            migrationBuilder.CreateTable(
                name: "EntranceExamMaster",
                columns: table => new
                {
                    EntranceExamId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    EntranceExamName = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntranceExamMaster", x => x.EntranceExamId);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(nullable: true),
                    TargetSite = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Stack = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "GenderMaster",
                columns: table => new
                {
                    GenId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMaster", x => x.GenId);
                });

            migrationBuilder.CreateTable(
                name: "HistoryStudentAttendance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AttendanceId = table.Column<long>(nullable: false),
                    ClassId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false),
                    LectureNoId = table.Column<long>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AttendanceBy = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryStudentAttendance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoryStudentAttendanceDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AttendanceDetail = table.Column<long>(nullable: false),
                    AttendanceId = table.Column<long>(nullable: false),
                    StudentId = table.Column<long>(nullable: false),
                    IsPresent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryStudentAttendanceDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LectureMaster",
                columns: table => new
                {
                    LectureId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    LactureName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureMaster", x => x.LectureId);
                });

            migrationBuilder.CreateTable(
                name: "MarkingScheame",
                columns: table => new
                {
                    MarkingShchemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    MarkingShchem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkingScheame", x => x.MarkingShchemId);
                });

            migrationBuilder.CreateTable(
                name: "PGDegreeMaster",
                columns: table => new
                {
                    PGDegreeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    PGDegreeName = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PGDegreeMaster", x => x.PGDegreeId);
                });

            migrationBuilder.CreateTable(
                name: "RelationMaster",
                columns: table => new
                {
                    RelationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationMaster", x => x.RelationId);
                });

            migrationBuilder.CreateTable(
                name: "ReligionMaster",
                columns: table => new
                {
                    ReligionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Religion = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligionMaster", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "StaytypeMaster",
                columns: table => new
                {
                    StaytypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Staytype = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaytypeMaster", x => x.StaytypeId);
                });

            migrationBuilder.CreateTable(
                name: "SubjectMaster",
                columns: table => new
                {
                    SubjectId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectMaster", x => x.SubjectId);
                });

            migrationBuilder.CreateTable(
                name: "YearSemesterMaster",
                columns: table => new
                {
                    YearSemesterId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    YearSemester = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearSemesterMaster", x => x.YearSemesterId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TenMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TwelveMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DiplomaMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DegreeMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PGMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    EntranceExamMasrksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ColoredPhotograph = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CasteCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DomicileCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    BirthCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Adharcard = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeMaster",
                columns: table => new
                {
                    CollegeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CampusId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeMaster", x => x.CollegeId);
                    table.ForeignKey(
                        name: "FK_CollegeMaster_CampusMaster_CampusId",
                        column: x => x.CampusId,
                        principalTable: "CampusMaster",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassStudentDetail",
                columns: table => new
                {
                    ClassStudentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassId = table.Column<long>(nullable: false),
                    StudentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStudentDetail", x => x.ClassStudentId);
                    table.ForeignKey(
                        name: "FK_ClassStudentDetail_ClassMaster_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassStudentDetail_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateMaster",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CountryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMaster", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_StateMaster_CountryMaster_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BranchMaster",
                columns: table => new
                {
                    BranchId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchMaster", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_BranchMaster_CourseMaster_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseMaster",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentQualication",
                columns: table => new
                {
                    StudentQualicationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    DegreeId = table.Column<long>(nullable: true),
                    DiplomaId = table.Column<long>(nullable: true),
                    TenMarkingScheameId = table.Column<long>(nullable: true),
                    TenBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TenYearOfPassing = table.Column<int>(type: "int", nullable: true),
                    TenCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TenSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TwelveMakingScheameId = table.Column<long>(nullable: true),
                    TwelveBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TwelveYearOfPassing = table.Column<int>(type: "int", nullable: true),
                    TwelveCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwelvePCM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwelveSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DiplomaYear = table.Column<int>(type: "int", nullable: true),
                    DiplomaMarkingScheameId = table.Column<long>(nullable: true),
                    DiplomaCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiplomaBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    DiplomaSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DegreeYear = table.Column<int>(type: "int", nullable: true),
                    DegreeMarkingScheameId = table.Column<long>(nullable: true),
                    DegreeCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DegreeSchoolName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    DegreeBoardName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PGDegreeId = table.Column<long>(nullable: false),
                    PGDegreeYear = table.Column<int>(type: "int", nullable: true),
                    PGDegreeMarkingScheameId = table.Column<long>(nullable: true),
                    PGDegreeCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PGDegreeSchoolName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    PGDegreeBoardName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    EntranceExamId = table.Column<long>(nullable: false),
                    IsEntrance = table.Column<bool>(type: "bit", nullable: false),
                    EntranceExamYear = table.Column<int>(type: "int", nullable: true),
                    EntranceExamRollno = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamMarkObt = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamAir = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamCatefgoryRank = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQualication", x => x.StudentQualicationId);
                    table.ForeignKey(
                        name: "FK_StudentQualication_DegreeMaster_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "DegreeMaster",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_MarkingScheame_DegreeMarkingScheameId",
                        column: x => x.DegreeMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_DiplomaMaster_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "DiplomaMaster",
                        principalColumn: "DiplomaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_MarkingScheame_DiplomaMarkingScheameId",
                        column: x => x.DiplomaMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                        column: x => x.EntranceExamId,
                        principalTable: "EntranceExamMaster",
                        principalColumn: "EntranceExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentQualication_PGDegreeMaster_PGDegreeId",
                        column: x => x.PGDegreeId,
                        principalTable: "PGDegreeMaster",
                        principalColumn: "PGDegreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentQualication_MarkingScheame_PGDegreeMarkingScheameId",
                        column: x => x.PGDegreeMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_MarkingScheame_TenMarkingScheameId",
                        column: x => x.TenMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_MarkingScheame_TwelveMakingScheameId",
                        column: x => x.TwelveMakingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubjectDetail",
                columns: table => new
                {
                    ClassSubjectDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjectDetail", x => x.ClassSubjectDetailId);
                    table.ForeignKey(
                        name: "FK_ClassSubjectDetail_ClassMaster_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjectDetail_SubjectMaster_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectMaster",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendance",
                columns: table => new
                {
                    AttendanceId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassId = table.Column<long>(nullable: false),
                    SubjectId = table.Column<long>(nullable: false),
                    LectureId = table.Column<long>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    AttendanceBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendance", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_AspNetUsers_AttendanceBy",
                        column: x => x.AttendanceBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_ClassMaster_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_LectureMaster_LectureId",
                        column: x => x.LectureId,
                        principalTable: "LectureMaster",
                        principalColumn: "LectureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_SubjectMaster_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectMaster",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoryDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<long>(nullable: true),
                    TenMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TwelveMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DiplomaMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DegreeMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PGMarksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    EntranceExamMasrksheetPath = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    ColoredPhotograph = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CasteCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DomicileCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    BirthCertificate = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Passport = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Adharcard = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryDocuments_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "DocumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryDocuments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryClassStudentDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassStudentId = table.Column<long>(nullable: false),
                    ClassId = table.Column<long>(nullable: true),
                    StudentId = table.Column<long>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClassStudentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryClassStudentDetail_ClassMaster_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryClassStudentDetail_ClassStudentDetail_ClassStudentId",
                        column: x => x.ClassStudentId,
                        principalTable: "ClassStudentDetail",
                        principalColumn: "ClassStudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryClassStudentDetail_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParentDetail",
                columns: table => new
                {
                    ParentDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherCityId = table.Column<long>(nullable: true),
                    FatherStateId = table.Column<long>(nullable: true),
                    FatherCountryId = table.Column<long>(nullable: true),
                    FatherPincode = table.Column<string>(type: "varchar(50)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherCityId = table.Column<long>(nullable: true),
                    MotherStateId = table.Column<long>(nullable: true),
                    MotherCountryId = table.Column<long>(nullable: true),
                    MotherPincode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LGPincode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LGName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGCityId = table.Column<long>(nullable: true),
                    LGStateId = table.Column<long>(nullable: true),
                    LGCountryId = table.Column<long>(nullable: true),
                    RelationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentDetail", x => x.ParentDetailId);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CityMaster_FatherCityId",
                        column: x => x.FatherCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CountryMaster_FatherCountryId",
                        column: x => x.FatherCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_StateMaster_FatherStateId",
                        column: x => x.FatherStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CityMaster_LGCityId",
                        column: x => x.LGCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CountryMaster_LGCountryId",
                        column: x => x.LGCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_StateMaster_LGStateId",
                        column: x => x.LGStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CityMaster_MotherCityId",
                        column: x => x.MotherCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_CountryMaster_MotherCountryId",
                        column: x => x.MotherCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_StateMaster_MotherStateId",
                        column: x => x.MotherStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_RelationMaster_RelationId",
                        column: x => x.RelationId,
                        principalTable: "RelationMaster",
                        principalColumn: "RelationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParentDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetail",
                columns: table => new
                {
                    PersonalDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    Mobile1 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Mobile2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PersonalEmail1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PersonalEmail2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GenderId = table.Column<long>(nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    BloodGroupdId = table.Column<long>(nullable: true),
                    ReligionId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    CountryId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    StayTypeId = table.Column<long>(nullable: true),
                    StayAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StayRelationId = table.Column<long>(nullable: true),
                    StayCountryId = table.Column<long>(nullable: true),
                    StayStateId = table.Column<long>(nullable: true),
                    StayCityId = table.Column<long>(nullable: true),
                    StayPinCode = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetail", x => x.PersonalDetailId);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_BloodgroupMaster_BloodGroupdId",
                        column: x => x.BloodGroupdId,
                        principalTable: "BloodgroupMaster",
                        principalColumn: "BloodgroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CategoryMaster_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryMaster",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CityMaster_CityId",
                        column: x => x.CityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CountryMaster_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_GenderMaster_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderMaster",
                        principalColumn: "GenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_ReligionMaster_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "ReligionMaster",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CityMaster_StayCityId",
                        column: x => x.StayCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CountryMaster_StayCountryId",
                        column: x => x.StayCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_RelationMaster_StayRelationId",
                        column: x => x.StayRelationId,
                        principalTable: "RelationMaster",
                        principalColumn: "RelationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_StateMaster_StayStateId",
                        column: x => x.StayStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_StaytypeMaster_StayTypeId",
                        column: x => x.StayTypeId,
                        principalTable: "StaytypeMaster",
                        principalColumn: "StaytypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeDetail",
                columns: table => new
                {
                    CollegeDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    CampusId = table.Column<long>(nullable: false),
                    CollegeId = table.Column<long>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    BatchId = table.Column<long>(nullable: false),
                    branchId = table.Column<long>(nullable: true),
                    YearSemesterId = table.Column<long>(nullable: false),
                    AdmissionTypeId = table.Column<long>(nullable: false),
                    AdmissionBatchTypeId = table.Column<long>(nullable: true),
                    Universityenrollmentnumber = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AdharNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CollegeRollNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UniversityExamRoleNo = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeDetail", x => x.CollegeDetailId);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_BatchMaster_AdmissionBatchTypeId",
                        column: x => x.AdmissionBatchTypeId,
                        principalTable: "BatchMaster",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_AdmissiontypeMaster_AdmissionTypeId",
                        column: x => x.AdmissionTypeId,
                        principalTable: "AdmissiontypeMaster",
                        principalColumn: "AdmissiontypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_BatchMaster_BatchId",
                        column: x => x.BatchId,
                        principalTable: "BatchMaster",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_CampusMaster_CampusId",
                        column: x => x.CampusId,
                        principalTable: "CampusMaster",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_CourseMaster_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseMaster",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_YearSemesterMaster_YearSemesterId",
                        column: x => x.YearSemesterId,
                        principalTable: "YearSemesterMaster",
                        principalColumn: "YearSemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_BranchMaster_branchId",
                        column: x => x.branchId,
                        principalTable: "BranchMaster",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryStudentQualication",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentQualicationId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    DegreeId = table.Column<long>(nullable: true),
                    DiplomaId = table.Column<long>(nullable: true),
                    TenMarkingScheameId = table.Column<long>(nullable: true),
                    TenBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TenYearOfPassing = table.Column<int>(type: "int", nullable: true),
                    TenCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TenSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TwelveMakingScheameId = table.Column<long>(nullable: true),
                    TwelveBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TwelveYearOfPassing = table.Column<int>(type: "int", nullable: true),
                    TwelveCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwelvePCM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TwelveSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DiplomaYear = table.Column<int>(type: "int", nullable: true),
                    DiplomaMarkingScheameId = table.Column<long>(nullable: true),
                    DiplomaCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiplomaBoardName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    DiplomaSchoolName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    DegreeYear = table.Column<int>(type: "int", nullable: true),
                    DegreeMarkingScheameId = table.Column<long>(nullable: true),
                    DegreeCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DegreeSchoolName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    DegreeBoardName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PGDegreeId = table.Column<long>(nullable: false),
                    PGDegreeYear = table.Column<int>(type: "int", nullable: true),
                    PGDegreeMarkingScheameId = table.Column<long>(nullable: true),
                    PGDegreeCGPA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PGDegreeSchoolName = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    PGDegreeBoardName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    EntranceExamId = table.Column<long>(nullable: false),
                    IsEntrance = table.Column<bool>(type: "bit", nullable: false),
                    EntranceExamYear = table.Column<int>(type: "int", nullable: true),
                    EntranceExamRollno = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamMarkObt = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamAir = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntranceExamCatefgoryRank = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryStudentQualication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_DegreeMaster_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "DegreeMaster",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_MarkingScheame_DegreeMarkingScheameId",
                        column: x => x.DegreeMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_DiplomaMaster_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "DiplomaMaster",
                        principalColumn: "DiplomaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_MarkingScheame_DiplomaMarkingScheameId",
                        column: x => x.DiplomaMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_EntranceExamMaster_EntranceExamId",
                        column: x => x.EntranceExamId,
                        principalTable: "EntranceExamMaster",
                        principalColumn: "EntranceExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_PGDegreeMaster_PGDegreeId",
                        column: x => x.PGDegreeId,
                        principalTable: "PGDegreeMaster",
                        principalColumn: "PGDegreeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_MarkingScheame_PGDegreeMarkingScheameId",
                        column: x => x.PGDegreeMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_StudentQualication_StudentQualicationId",
                        column: x => x.StudentQualicationId,
                        principalTable: "StudentQualication",
                        principalColumn: "StudentQualicationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_MarkingScheame_TenMarkingScheameId",
                        column: x => x.TenMarkingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_MarkingScheame_TwelveMakingScheameId",
                        column: x => x.TwelveMakingScheameId,
                        principalTable: "MarkingScheame",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryStudentQualication_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubjectTeacherDetail",
                columns: table => new
                {
                    ClassSubjectTeacherId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassSubjectDetailId = table.Column<long>(nullable: true),
                    TeacherId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjectTeacherDetail", x => x.ClassSubjectTeacherId);
                    table.ForeignKey(
                        name: "FK_ClassSubjectTeacherDetail_ClassSubjectDetail_ClassSubjectDetailId",
                        column: x => x.ClassSubjectDetailId,
                        principalTable: "ClassSubjectDetail",
                        principalColumn: "ClassSubjectDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryParentDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentDetailId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherCityId = table.Column<long>(nullable: true),
                    FatherStateId = table.Column<long>(nullable: true),
                    FatherCountryId = table.Column<long>(nullable: true),
                    FatherPincode = table.Column<string>(type: "varchar(50)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherCityId = table.Column<long>(nullable: true),
                    MotherStateId = table.Column<long>(nullable: true),
                    MotherCountryId = table.Column<long>(nullable: true),
                    MotherPincode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LGPincode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LGName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGMobile1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGMobile2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LGCityId = table.Column<long>(nullable: true),
                    LGStateId = table.Column<long>(nullable: true),
                    LGCountryId = table.Column<long>(nullable: true),
                    RelationId = table.Column<long>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryParentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CityMaster_FatherCityId",
                        column: x => x.FatherCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CountryMaster_FatherCountryId",
                        column: x => x.FatherCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_StateMaster_FatherStateId",
                        column: x => x.FatherStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CityMaster_LGCityId",
                        column: x => x.LGCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CountryMaster_LGCountryId",
                        column: x => x.LGCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_StateMaster_LGStateId",
                        column: x => x.LGStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CityMaster_MotherCityId",
                        column: x => x.MotherCityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_CountryMaster_MotherCountryId",
                        column: x => x.MotherCountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_StateMaster_MotherStateId",
                        column: x => x.MotherStateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_ParentDetail_ParentDetailId",
                        column: x => x.ParentDetailId,
                        principalTable: "ParentDetail",
                        principalColumn: "ParentDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_RelationMaster_RelationId",
                        column: x => x.RelationId,
                        principalTable: "RelationMaster",
                        principalColumn: "RelationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryParentDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryPersonalDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalDetailId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    Mobile1 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Mobile2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PersonalEmail1 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PersonalEmail2 = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GenderId = table.Column<long>(nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    BloodGroupdId = table.Column<long>(nullable: false),
                    ReligionId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: false),
                    CountryId = table.Column<long>(nullable: false),
                    StateId = table.Column<long>(nullable: true),
                    StatePincode = table.Column<string>(type: "varchar(10)", nullable: true),
                    CountryPincode = table.Column<string>(type: "varchar(10)", nullable: true),
                    StayTypeId = table.Column<long>(nullable: false),
                    StayAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StayRelationId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryPersonalDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_BloodgroupMaster_BloodGroupdId",
                        column: x => x.BloodGroupdId,
                        principalTable: "BloodgroupMaster",
                        principalColumn: "BloodgroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_CategoryMaster_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategoryMaster",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_CityMaster_CityId",
                        column: x => x.CityId,
                        principalTable: "CityMaster",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_CountryMaster_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_GenderMaster_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderMaster",
                        principalColumn: "GenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_PersonalDetail_PersonalDetailId",
                        column: x => x.PersonalDetailId,
                        principalTable: "PersonalDetail",
                        principalColumn: "PersonalDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_ReligionMaster_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "ReligionMaster",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_RelationMaster_StayRelationId",
                        column: x => x.StayRelationId,
                        principalTable: "RelationMaster",
                        principalColumn: "RelationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_StaytypeMaster_StayTypeId",
                        column: x => x.StayTypeId,
                        principalTable: "StaytypeMaster",
                        principalColumn: "StaytypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryPersonalDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryCollegeDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeDetailId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    CampusId = table.Column<long>(nullable: false),
                    CollegeId = table.Column<long>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    BatchId = table.Column<long>(nullable: false),
                    branchId = table.Column<long>(nullable: true),
                    YearSemesterId = table.Column<long>(nullable: false),
                    AdmissionTypeId = table.Column<long>(nullable: false),
                    AdmissionBatchTypeId = table.Column<long>(nullable: true),
                    Universityenrollmentnumber = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AdharNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    CollegeRollNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UniversityExamRoleNo = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryCollegeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_BatchMaster_AdmissionBatchTypeId",
                        column: x => x.AdmissionBatchTypeId,
                        principalTable: "BatchMaster",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_AdmissiontypeMaster_AdmissionTypeId",
                        column: x => x.AdmissionTypeId,
                        principalTable: "AdmissiontypeMaster",
                        principalColumn: "AdmissiontypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_BatchMaster_BatchId",
                        column: x => x.BatchId,
                        principalTable: "BatchMaster",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_CampusMaster_CampusId",
                        column: x => x.CampusId,
                        principalTable: "CampusMaster",
                        principalColumn: "CampusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_CollegeDetail_CollegeDetailId",
                        column: x => x.CollegeDetailId,
                        principalTable: "CollegeDetail",
                        principalColumn: "CollegeDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_CourseMaster_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseMaster",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_YearSemesterMaster_YearSemesterId",
                        column: x => x.YearSemesterId,
                        principalTable: "YearSemesterMaster",
                        principalColumn: "YearSemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoryCollegeDetail_BranchMaster_branchId",
                        column: x => x.branchId,
                        principalTable: "BranchMaster",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoryClassSubjectTeacherDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassSubjectTeacherId = table.Column<long>(nullable: true),
                    ClassSubjectDetailId = table.Column<long>(nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TeacherId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClassSubjectTeacherDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryClassSubjectTeacherDetail_ClassSubjectTeacherDetail_ClassSubjectDetailId",
                        column: x => x.ClassSubjectDetailId,
                        principalTable: "ClassSubjectTeacherDetail",
                        principalColumn: "ClassSubjectTeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BranchMaster_CourseId",
                table: "BranchMaster",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudentDetail_ClassId",
                table: "ClassStudentDetail",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassStudentDetail_StudentId",
                table: "ClassStudentDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_ClassId",
                table: "ClassSubjectDetail",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_SubjectId",
                table: "ClassSubjectDetail",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectTeacherDetail_ClassSubjectDetailId",
                table: "ClassSubjectTeacherDetail",
                column: "ClassSubjectDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_AdmissionBatchTypeId",
                table: "CollegeDetail",
                column: "AdmissionBatchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_AdmissionTypeId",
                table: "CollegeDetail",
                column: "AdmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_BatchId",
                table: "CollegeDetail",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_CampusId",
                table: "CollegeDetail",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_CourseId",
                table: "CollegeDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_UserId",
                table: "CollegeDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_YearSemesterId",
                table: "CollegeDetail",
                column: "YearSemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_branchId",
                table: "CollegeDetail",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeMaster_CampusId",
                table: "CollegeMaster",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassStudentDetail_ClassId",
                table: "HistoryClassStudentDetail",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassStudentDetail_ClassStudentId",
                table: "HistoryClassStudentDetail",
                column: "ClassStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassStudentDetail_StudentId",
                table: "HistoryClassStudentDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassSubjectTeacherDetail_ClassSubjectDetailId",
                table: "HistoryClassSubjectTeacherDetail",
                column: "ClassSubjectDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_AdmissionBatchTypeId",
                table: "HistoryCollegeDetail",
                column: "AdmissionBatchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_AdmissionTypeId",
                table: "HistoryCollegeDetail",
                column: "AdmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_BatchId",
                table: "HistoryCollegeDetail",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_CampusId",
                table: "HistoryCollegeDetail",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_CollegeDetailId",
                table: "HistoryCollegeDetail",
                column: "CollegeDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_CourseId",
                table: "HistoryCollegeDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_UserId",
                table: "HistoryCollegeDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_YearSemesterId",
                table: "HistoryCollegeDetail",
                column: "YearSemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryCollegeDetail_branchId",
                table: "HistoryCollegeDetail",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryDocuments_DocumentId",
                table: "HistoryDocuments",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryDocuments_UserId",
                table: "HistoryDocuments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_FatherCityId",
                table: "HistoryParentDetail",
                column: "FatherCityId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_FatherCountryId",
                table: "HistoryParentDetail",
                column: "FatherCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_FatherStateId",
                table: "HistoryParentDetail",
                column: "FatherStateId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_LGCityId",
                table: "HistoryParentDetail",
                column: "LGCityId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_LGCountryId",
                table: "HistoryParentDetail",
                column: "LGCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_LGStateId",
                table: "HistoryParentDetail",
                column: "LGStateId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_MotherCityId",
                table: "HistoryParentDetail",
                column: "MotherCityId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_MotherCountryId",
                table: "HistoryParentDetail",
                column: "MotherCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_MotherStateId",
                table: "HistoryParentDetail",
                column: "MotherStateId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_ParentDetailId",
                table: "HistoryParentDetail",
                column: "ParentDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_RelationId",
                table: "HistoryParentDetail",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryParentDetail_UserId",
                table: "HistoryParentDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_BloodGroupdId",
                table: "HistoryPersonalDetail",
                column: "BloodGroupdId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_CategoryId",
                table: "HistoryPersonalDetail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_CityId",
                table: "HistoryPersonalDetail",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_CountryId",
                table: "HistoryPersonalDetail",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_GenderId",
                table: "HistoryPersonalDetail",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_PersonalDetailId",
                table: "HistoryPersonalDetail",
                column: "PersonalDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_ReligionId",
                table: "HistoryPersonalDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_StateId",
                table: "HistoryPersonalDetail",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_StayRelationId",
                table: "HistoryPersonalDetail",
                column: "StayRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_StayTypeId",
                table: "HistoryPersonalDetail",
                column: "StayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryPersonalDetail_UserId",
                table: "HistoryPersonalDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_DegreeId",
                table: "HistoryStudentQualication",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_DegreeMarkingScheameId",
                table: "HistoryStudentQualication",
                column: "DegreeMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_DiplomaId",
                table: "HistoryStudentQualication",
                column: "DiplomaId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_DiplomaMarkingScheameId",
                table: "HistoryStudentQualication",
                column: "DiplomaMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_EntranceExamId",
                table: "HistoryStudentQualication",
                column: "EntranceExamId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_PGDegreeId",
                table: "HistoryStudentQualication",
                column: "PGDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_PGDegreeMarkingScheameId",
                table: "HistoryStudentQualication",
                column: "PGDegreeMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_StudentQualicationId",
                table: "HistoryStudentQualication",
                column: "StudentQualicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_TenMarkingScheameId",
                table: "HistoryStudentQualication",
                column: "TenMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_TwelveMakingScheameId",
                table: "HistoryStudentQualication",
                column: "TwelveMakingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryStudentQualication_UserId",
                table: "HistoryStudentQualication",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_FatherCityId",
                table: "ParentDetail",
                column: "FatherCityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_FatherCountryId",
                table: "ParentDetail",
                column: "FatherCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_FatherStateId",
                table: "ParentDetail",
                column: "FatherStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_LGCityId",
                table: "ParentDetail",
                column: "LGCityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_LGCountryId",
                table: "ParentDetail",
                column: "LGCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_LGStateId",
                table: "ParentDetail",
                column: "LGStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_MotherCityId",
                table: "ParentDetail",
                column: "MotherCityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_MotherCountryId",
                table: "ParentDetail",
                column: "MotherCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_MotherStateId",
                table: "ParentDetail",
                column: "MotherStateId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_RelationId",
                table: "ParentDetail",
                column: "RelationId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentDetail_UserId",
                table: "ParentDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_BloodGroupdId",
                table: "PersonalDetail",
                column: "BloodGroupdId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_CategoryId",
                table: "PersonalDetail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_CityId",
                table: "PersonalDetail",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_CountryId",
                table: "PersonalDetail",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_GenderId",
                table: "PersonalDetail",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_ReligionId",
                table: "PersonalDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StateId",
                table: "PersonalDetail",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayCityId",
                table: "PersonalDetail",
                column: "StayCityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayCountryId",
                table: "PersonalDetail",
                column: "StayCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayRelationId",
                table: "PersonalDetail",
                column: "StayRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayStateId",
                table: "PersonalDetail",
                column: "StayStateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayTypeId",
                table: "PersonalDetail",
                column: "StayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_UserId",
                table: "PersonalDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StateMaster_CountryId",
                table: "StateMaster",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_AttendanceBy",
                table: "StudentAttendance",
                column: "AttendanceBy");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_ClassId",
                table: "StudentAttendance",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_LectureId",
                table: "StudentAttendance",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_SubjectId",
                table: "StudentAttendance",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_DegreeId",
                table: "StudentQualication",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_DegreeMarkingScheameId",
                table: "StudentQualication",
                column: "DegreeMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_DiplomaId",
                table: "StudentQualication",
                column: "DiplomaId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_DiplomaMarkingScheameId",
                table: "StudentQualication",
                column: "DiplomaMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_EntranceExamId",
                table: "StudentQualication",
                column: "EntranceExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_PGDegreeId",
                table: "StudentQualication",
                column: "PGDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_PGDegreeMarkingScheameId",
                table: "StudentQualication",
                column: "PGDegreeMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_TenMarkingScheameId",
                table: "StudentQualication",
                column: "TenMarkingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_TwelveMakingScheameId",
                table: "StudentQualication",
                column: "TwelveMakingScheameId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_UserId",
                table: "StudentQualication",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CollegeMaster");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "HistoryClassStudentDetail");

            migrationBuilder.DropTable(
                name: "HistoryClassSubjectTeacherDetail");

            migrationBuilder.DropTable(
                name: "HistoryCollegeDetail");

            migrationBuilder.DropTable(
                name: "HistoryDocuments");

            migrationBuilder.DropTable(
                name: "HistoryParentDetail");

            migrationBuilder.DropTable(
                name: "HistoryPersonalDetail");

            migrationBuilder.DropTable(
                name: "HistoryStudentAttendance");

            migrationBuilder.DropTable(
                name: "HistoryStudentAttendanceDetail");

            migrationBuilder.DropTable(
                name: "HistoryStudentQualication");

            migrationBuilder.DropTable(
                name: "StudentAttendance");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ClassStudentDetail");

            migrationBuilder.DropTable(
                name: "ClassSubjectTeacherDetail");

            migrationBuilder.DropTable(
                name: "CollegeDetail");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "ParentDetail");

            migrationBuilder.DropTable(
                name: "PersonalDetail");

            migrationBuilder.DropTable(
                name: "StudentQualication");

            migrationBuilder.DropTable(
                name: "LectureMaster");

            migrationBuilder.DropTable(
                name: "ClassSubjectDetail");

            migrationBuilder.DropTable(
                name: "BatchMaster");

            migrationBuilder.DropTable(
                name: "AdmissiontypeMaster");

            migrationBuilder.DropTable(
                name: "CampusMaster");

            migrationBuilder.DropTable(
                name: "YearSemesterMaster");

            migrationBuilder.DropTable(
                name: "BranchMaster");

            migrationBuilder.DropTable(
                name: "BloodgroupMaster");

            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "CityMaster");

            migrationBuilder.DropTable(
                name: "GenderMaster");

            migrationBuilder.DropTable(
                name: "ReligionMaster");

            migrationBuilder.DropTable(
                name: "StateMaster");

            migrationBuilder.DropTable(
                name: "RelationMaster");

            migrationBuilder.DropTable(
                name: "StaytypeMaster");

            migrationBuilder.DropTable(
                name: "DegreeMaster");

            migrationBuilder.DropTable(
                name: "MarkingScheame");

            migrationBuilder.DropTable(
                name: "DiplomaMaster");

            migrationBuilder.DropTable(
                name: "EntranceExamMaster");

            migrationBuilder.DropTable(
                name: "PGDegreeMaster");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ClassMaster");

            migrationBuilder.DropTable(
                name: "SubjectMaster");

            migrationBuilder.DropTable(
                name: "CourseMaster");

            migrationBuilder.DropTable(
                name: "CountryMaster");
        }
    }
}

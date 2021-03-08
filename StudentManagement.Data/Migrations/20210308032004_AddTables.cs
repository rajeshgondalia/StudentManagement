using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissionbatchMasters",
                columns: table => new
                {
                    AdmissionbatchId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Admissionbatch = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionbatchMasters", x => x.AdmissionbatchId);
                });

            migrationBuilder.CreateTable(
                name: "AdmissiontypeMaster",
                columns: table => new
                {
                    AdmissiontypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Admissiontype = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissiontypeMaster", x => x.AdmissiontypeId);
                });

            migrationBuilder.CreateTable(
                name: "BatchMaster",
                columns: table => new
                {
                    BatchId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
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
                    IsActive = table.Column<bool>(nullable: false),
                    Bloodgroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodgroupMaster", x => x.BloodgroupId);
                });

            migrationBuilder.CreateTable(
                name: "BranchMaster",
                columns: table => new
                {
                    BranchId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchMaster", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "CampusMaster",
                columns: table => new
                {
                    CampusId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CollegeMaster",
                columns: table => new
                {
                    PK_CollegeMaster = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeMaster", x => x.PK_CollegeMaster);
                });

            migrationBuilder.CreateTable(
                name: "CountryMaster",
                columns: table => new
                {
                    CountryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryName = table.Column<string>(nullable: true)
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
                    IsActive = table.Column<bool>(nullable: false),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMaster", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypeMaster",
                columns: table => new
                {
                    DocumentTypeMasterId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DocumentTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypeMaster", x => x.DocumentTypeMasterId);
                });

            migrationBuilder.CreateTable(
                name: "DomicileMaster",
                columns: table => new
                {
                    DomicileId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Domicile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomicileMaster", x => x.DomicileId);
                });

            migrationBuilder.CreateTable(
                name: "ExamTypeMaster",
                columns: table => new
                {
                    ExamTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypeMaster", x => x.ExamTypeId);
                });

            migrationBuilder.CreateTable(
                name: "GenderMaster",
                columns: table => new
                {
                    GenId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderMaster", x => x.GenId);
                });

            migrationBuilder.CreateTable(
                name: "LGRelationMaster",
                columns: table => new
                {
                    LGRelationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LGRelationMaster", x => x.LGRelationId);
                });

            migrationBuilder.CreateTable(
                name: "MarkingSchemUGPGD",
                columns: table => new
                {
                    MarkingShchemId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    MarkingShchem = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkingSchemUGPGD", x => x.MarkingShchemId);
                });

            migrationBuilder.CreateTable(
                name: "NationalityMaster",
                columns: table => new
                {
                    NationalityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Nationality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalityMaster", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "ReligionMaster",
                columns: table => new
                {
                    ReligionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Religion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligionMaster", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "StayrelationMaster",
                columns: table => new
                {
                    StayrelationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Stayrelation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StayrelationMaster", x => x.StayrelationId);
                });

            migrationBuilder.CreateTable(
                name: "StaytypeMaster",
                columns: table => new
                {
                    StaytypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Staytype = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaytypeMaster", x => x.StaytypeId);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendence",
                columns: table => new
                {
                    StudentAttendenceId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Held = table.Column<int>(nullable: false),
                    Attendence = table.Column<int>(nullable: false),
                    percent = table.Column<decimal>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true),
                    DateOfAttend = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendence", x => x.StudentAttendenceId);
                });

            migrationBuilder.CreateTable(
                name: "StateMaster",
                columns: table => new
                {
                    StateId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMaster", x => x.StateId);
                    table.ForeignKey(
                        name: "FK_StateMaster_CountryMaster_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeDetail",
                columns: table => new
                {
                    CollegeDetailId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    StudentId = table.Column<long>(nullable: false),
                    CampusId = table.Column<long>(nullable: false),
                    CollegeId = table.Column<long>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    BatchId = table.Column<long>(nullable: false),
                    branchId = table.Column<long>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    AdmissionTypeId = table.Column<long>(nullable: false),
                    AdmissionBatchTypeId = table.Column<long>(nullable: false),
                    Universityenrollmentnumber = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    AdharNumber = table.Column<string>(nullable: true),
                    CollegeRollNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeDetail", x => x.CollegeDetailId);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_AdmissionbatchMasters_AdmissionBatchTypeId",
                        column: x => x.AdmissionBatchTypeId,
                        principalTable: "AdmissionbatchMasters",
                        principalColumn: "AdmissionbatchId",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_CollegeDetail_CollegeMaster_CollegeId",
                        column: x => x.CollegeId,
                        principalTable: "CollegeMaster",
                        principalColumn: "PK_CollegeMaster",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_CourseMaster_CourseId",
                        column: x => x.CourseId,
                        principalTable: "CourseMaster",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeDetail_BranchMaster_branchId",
                        column: x => x.branchId,
                        principalTable: "BranchMaster",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    DocumentTypeId = table.Column<long>(nullable: false),
                    UploadPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypeMaster_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypeMaster",
                        principalColumn: "DocumentTypeMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntranceExamMaster",
                columns: table => new
                {
                    EntranceExamId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    ExamTypeId = table.Column<long>(nullable: false),
                    ExamYear = table.Column<int>(nullable: false),
                    RollNumber = table.Column<string>(nullable: true),
                    MarkObtained = table.Column<int>(nullable: false),
                    ExamAir = table.Column<string>(nullable: true),
                    ExamCategoryRank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntranceExamMaster", x => x.EntranceExamId);
                    table.ForeignKey(
                        name: "FK_EntranceExamMaster_ExamTypeMaster_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamTypeMaster",
                        principalColumn: "ExamTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeMaster",
                columns: table => new
                {
                    DegreeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DegreeYear = table.Column<int>(nullable: false),
                    DegreeMarkingId = table.Column<long>(nullable: false),
                    CGPA = table.Column<decimal>(nullable: false),
                    BoardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeMaster", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_DegreeMaster_MarkingSchemUGPGD_DegreeMarkingId",
                        column: x => x.DegreeMarkingId,
                        principalTable: "MarkingSchemUGPGD",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiplomaMaster",
                columns: table => new
                {
                    DiplomaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DiplomaYear = table.Column<int>(nullable: false),
                    DiplomaMarkingId = table.Column<long>(nullable: false),
                    CGPA = table.Column<decimal>(nullable: false),
                    BoardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiplomaMaster", x => x.DiplomaId);
                    table.ForeignKey(
                        name: "FK_DiplomaMaster_MarkingSchemUGPGD_DiplomaMarkingId",
                        column: x => x.DiplomaMarkingId,
                        principalTable: "MarkingSchemUGPGD",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenMaster",
                columns: table => new
                {
                    TenMasterId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    TenMarkingId = table.Column<long>(nullable: false),
                    BoardName = table.Column<string>(nullable: true),
                    YearOfPassing = table.Column<int>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    CGPA = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenMaster", x => x.TenMasterId);
                    table.ForeignKey(
                        name: "FK_TenMaster_MarkingSchemUGPGD_TenMarkingId",
                        column: x => x.TenMarkingId,
                        principalTable: "MarkingSchemUGPGD",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TenPlusTwoMaster",
                columns: table => new
                {
                    TenMasterId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    TenPlusTwoMarkingId = table.Column<long>(nullable: false),
                    BoardName = table.Column<string>(nullable: true),
                    YearOfPassing = table.Column<int>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    CGPA = table.Column<decimal>(nullable: false),
                    PCMCGPA = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenPlusTwoMaster", x => x.TenMasterId);
                    table.ForeignKey(
                        name: "FK_TenPlusTwoMaster_MarkingSchemUGPGD_TenPlusTwoMarkingId",
                        column: x => x.TenPlusTwoMarkingId,
                        principalTable: "MarkingSchemUGPGD",
                        principalColumn: "MarkingShchemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityMaster",
                columns: table => new
                {
                    CityId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    StateId = table.Column<long>(nullable: false),
                    PinCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMaster", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityMaster_StateMaster_StateId",
                        column: x => x.StateId,
                        principalTable: "StateMaster",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentQualication",
                columns: table => new
                {
                    StudentQualicationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    EntranceExamId = table.Column<long>(nullable: true),
                    DegreeId = table.Column<long>(nullable: true),
                    DiplomaId = table.Column<long>(nullable: true),
                    TenId = table.Column<long>(nullable: true),
                    TenPlusTwoId = table.Column<long>(nullable: true)
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
                        name: "FK_StudentQualication_DiplomaMaster_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "DiplomaMaster",
                        principalColumn: "DiplomaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                        column: x => x.EntranceExamId,
                        principalTable: "EntranceExamMaster",
                        principalColumn: "EntranceExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_TenMaster_TenId",
                        column: x => x.TenId,
                        principalTable: "TenMaster",
                        principalColumn: "TenMasterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentQualication_TenPlusTwoMaster_TenPlusTwoId",
                        column: x => x.TenPlusTwoId,
                        principalTable: "TenPlusTwoMaster",
                        principalColumn: "TenMasterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParentDetail",
                columns: table => new
                {
                    StudentId = table.Column<long>(nullable: false),
                    FatherName = table.Column<string>(nullable: true),
                    FatherMobile1 = table.Column<string>(nullable: true),
                    FatherMobile2 = table.Column<string>(nullable: true),
                    FatherEmail = table.Column<string>(nullable: true),
                    FatherAddress = table.Column<string>(nullable: true),
                    FatherCityId = table.Column<long>(nullable: true),
                    FatherStateId = table.Column<long>(nullable: true),
                    FatherCountryId = table.Column<long>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    MotherMobile1 = table.Column<string>(nullable: true),
                    MotherMobile2 = table.Column<string>(nullable: true),
                    MotherEmail = table.Column<string>(nullable: true),
                    MotherAddress = table.Column<string>(nullable: true),
                    MotherCityId = table.Column<long>(nullable: true),
                    MotherStateId = table.Column<long>(nullable: true),
                    MotherCountryId = table.Column<long>(nullable: true),
                    LGName = table.Column<string>(nullable: true),
                    LGMobile1 = table.Column<string>(nullable: true),
                    LGMobile2 = table.Column<string>(nullable: true),
                    LGEmail = table.Column<string>(nullable: true),
                    LGAddress = table.Column<string>(nullable: true),
                    LGCityId = table.Column<long>(nullable: true),
                    LGStateId = table.Column<long>(nullable: true),
                    LGCountryId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentDetail", x => x.StudentId);
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
                        name: "FK_ParentDetail_AspNetUsers_StudentId",
                        column: x => x.StudentId,
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
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    Mobile1 = table.Column<string>(nullable: true),
                    Mobile2 = table.Column<string>(nullable: true),
                    PersonalEmail1 = table.Column<string>(nullable: true),
                    PersonalEmail2 = table.Column<string>(nullable: true),
                    GenderId = table.Column<long>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false),
                    BloodGroupdId = table.Column<long>(nullable: false),
                    ReligionId = table.Column<long>(nullable: false),
                    NationalityId = table.Column<long>(nullable: false),
                    DomicileId = table.Column<long>(nullable: false),
                    CityId = table.Column<long>(nullable: true),
                    StateId = table.Column<long>(nullable: true),
                    CountryId = table.Column<long>(nullable: true),
                    StayTypeId = table.Column<long>(nullable: true),
                    StayAddress = table.Column<string>(nullable: true),
                    StayRelationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetail", x => x.PersonalDetailId);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_BloodgroupMaster_BloodGroupdId",
                        column: x => x.BloodGroupdId,
                        principalTable: "BloodgroupMaster",
                        principalColumn: "BloodgroupId",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_CountryMaster_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryMaster",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_DomicileMaster_DomicileId",
                        column: x => x.DomicileId,
                        principalTable: "DomicileMaster",
                        principalColumn: "DomicileId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_GenderMaster_GenderId",
                        column: x => x.GenderId,
                        principalTable: "GenderMaster",
                        principalColumn: "GenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_NationalityMaster_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "NationalityMaster",
                        principalColumn: "NationalityId",
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalDetail_StayrelationMaster_StayRelationId",
                        column: x => x.StayRelationId,
                        principalTable: "StayrelationMaster",
                        principalColumn: "StayrelationId",
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

            migrationBuilder.CreateIndex(
                name: "IX_CityMaster_StateId",
                table: "CityMaster",
                column: "StateId");

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
                name: "IX_CollegeDetail_CollegeId",
                table: "CollegeDetail",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_CourseId",
                table: "CollegeDetail",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_StudentId",
                table: "CollegeDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeDetail_branchId",
                table: "CollegeDetail",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeMaster_DegreeMarkingId",
                table: "DegreeMaster",
                column: "DegreeMarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_DiplomaMaster_DiplomaMarkingId",
                table: "DiplomaMaster",
                column: "DiplomaMarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntranceExamMaster_ExamTypeId",
                table: "EntranceExamMaster",
                column: "ExamTypeId");

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
                name: "IX_PersonalDetail_DomicileId",
                table: "PersonalDetail",
                column: "DomicileId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_GenderId",
                table: "PersonalDetail",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_NationalityId",
                table: "PersonalDetail",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_ReligionId",
                table: "PersonalDetail",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StateId",
                table: "PersonalDetail",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayRelationId",
                table: "PersonalDetail",
                column: "StayRelationId");

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
                name: "IX_StudentQualication_DegreeId",
                table: "StudentQualication",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_DiplomaId",
                table: "StudentQualication",
                column: "DiplomaId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_EntranceExamId",
                table: "StudentQualication",
                column: "EntranceExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_TenId",
                table: "StudentQualication",
                column: "TenId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentQualication_TenPlusTwoId",
                table: "StudentQualication",
                column: "TenPlusTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_TenMaster_TenMarkingId",
                table: "TenMaster",
                column: "TenMarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_TenPlusTwoMaster_TenPlusTwoMarkingId",
                table: "TenPlusTwoMaster",
                column: "TenPlusTwoMarkingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeDetail");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "LGRelationMaster");

            migrationBuilder.DropTable(
                name: "ParentDetail");

            migrationBuilder.DropTable(
                name: "PersonalDetail");

            migrationBuilder.DropTable(
                name: "StudentAttendence");

            migrationBuilder.DropTable(
                name: "StudentQualication");

            migrationBuilder.DropTable(
                name: "AdmissionbatchMasters");

            migrationBuilder.DropTable(
                name: "AdmissiontypeMaster");

            migrationBuilder.DropTable(
                name: "BatchMaster");

            migrationBuilder.DropTable(
                name: "CampusMaster");

            migrationBuilder.DropTable(
                name: "CollegeMaster");

            migrationBuilder.DropTable(
                name: "CourseMaster");

            migrationBuilder.DropTable(
                name: "BranchMaster");

            migrationBuilder.DropTable(
                name: "DocumentTypeMaster");

            migrationBuilder.DropTable(
                name: "BloodgroupMaster");

            migrationBuilder.DropTable(
                name: "CategoryMaster");

            migrationBuilder.DropTable(
                name: "CityMaster");

            migrationBuilder.DropTable(
                name: "DomicileMaster");

            migrationBuilder.DropTable(
                name: "GenderMaster");

            migrationBuilder.DropTable(
                name: "NationalityMaster");

            migrationBuilder.DropTable(
                name: "ReligionMaster");

            migrationBuilder.DropTable(
                name: "StayrelationMaster");

            migrationBuilder.DropTable(
                name: "StaytypeMaster");

            migrationBuilder.DropTable(
                name: "DegreeMaster");

            migrationBuilder.DropTable(
                name: "DiplomaMaster");

            migrationBuilder.DropTable(
                name: "EntranceExamMaster");

            migrationBuilder.DropTable(
                name: "TenMaster");

            migrationBuilder.DropTable(
                name: "TenPlusTwoMaster");

            migrationBuilder.DropTable(
                name: "StateMaster");

            migrationBuilder.DropTable(
                name: "ExamTypeMaster");

            migrationBuilder.DropTable(
                name: "MarkingSchemUGPGD");

            migrationBuilder.DropTable(
                name: "CountryMaster");
        }
    }
}

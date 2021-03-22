using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentManagement.Data.DBContexts;
using StudentManagement.Service.Implementation;
using StudentManagement.Service.Interface;
using StudentManagement.Web.AutoMapperProfileConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton(Configuration);
            services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.ini
            services.AddIdentity<ApplicationUser, Role>()
                .AddRoles<Role>()
                .AddEntityFrameworkStores<StudentDbContext>()
                .AddDefaultTokenProviders();
            services.AddScoped<RoleManager<Role>>();

            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ClaimsPrincipalFactory>();
            services.AddScoped<IPersonalDetailService, PersonalDetailRepository>();

            #region Identity Configuration
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;

                

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = false;
            });

            //Seting the Account Login page
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/Identity/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Identity/Account/Login
                options.LogoutPath = "/Identity/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Identity/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = true;
            });
            //Seting the Post Configure
            services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme, options =>
            {
                //configure your other properties
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/Identity/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Identity/Account/Login
                options.LogoutPath = "/Identity/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Identity/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = true;
            });
            services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });
            #endregion

            #region Dependencyinjection 
            services.AddScoped<IErrorLogService, ErrorLogRepository>();
            services.AddScoped<ICityMasterService, CityMasterRepository>();
            services.AddScoped<IStateMasterService, StateMasterRepository>();
            services.AddScoped<ICountryMasterService, CountryMasterRepository>();
            services.AddScoped<IReligionMasterService, ReligionMasterRepository>();
            services.AddScoped<IBloodGroupMasterService, BloodGroupMasterRepository>();
            services.AddScoped<ICategoryMasterService, CategoryMasterRepository>();
            services.AddScoped<IGenderService, GenderRepository>();
            services.AddScoped<ICampusMasterService, CampusRepository>();
            services.AddScoped<ICollegeMasterService,CollegeRepository>();
            services.AddScoped<ICourseMasterService, CourseRepository>();
            services.AddScoped<IBranchMasterService, BranchRepository>();
            services.AddScoped<IYearSemesterMasterService, YearSemRepository>();
            services.AddScoped<IBatchMasterService, BatchRepostitory>();
            services.AddScoped<IAdmissionTypeMasterService, AdmissionTypeRepository>();
            services.AddScoped<ICollegeDetailService, CollegeDetailRepository>();
            services.AddScoped<IStayTypeService, StayTypeRepository>();
            services.AddScoped<IRelationService, RelationRepository>();
            services.AddScoped<IParentdetailService, ParentDetailRepository>();
            services.AddScoped<IMarkingSchemeService, MarkingSchemeRepository>();
            services.AddScoped<IDiplomaService, DiplomaRepository>();
            services.AddScoped<IDegreeService, DegreeRepository>();
            services.AddScoped<IEntranceExamService, EntranceExamRepository>();
            services.AddScoped<IStudentQualificationSerivce, StudentQualificationRepository>();
            services.AddScoped<IDocumentService, DocumentRepository>();
            services.AddScoped<IPGDegreeService, PGRpository>();
            services.AddScoped<ILectureService, LectureRepository>();
            services.AddScoped<ISubjectService, SubjectRepository>();
            services.AddScoped<IClassService, ClassRepository>();
            services.AddScoped<IClassSubjectDetailService, ClassSubjectDetailRepository>();
            services.AddScoped<IUserService, UserRepository>();
            services.AddScoped<IAttendenceDetailService, AttendenceDetailRepository>();
            services.AddScoped<IStudentAttendanceService, StudentAttendanceRepository>();
            services.AddScoped<IClassStudentDetailService, ClassStudentDetailRepository>();
            

            #endregion


            services.AddAuthentication
            (CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie();








            services.AddMvc();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            /**Add Automapper**/
            // services.AddAutoMapper(typeof(Startup));
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AmProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSession(opts =>
            {
                opts.Cookie.IsEssential = true; // make the session cookie Essential
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
            //set login as default page
            services.AddMvc()
             .AddRazorPagesOptions(options =>
             {
                 options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
             })
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            .AddSessionStateTempDataProvider();
            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
            services.AddSession();

            #region Configure App Settings

            /**Email Settings**/
            //services.Configure<EmailSettingsGmail>(Configuration.GetSection("EmailSettingsGmail"));

            /**Settings**/
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
          
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "Admin",
                   areaName: "Admin",
                   pattern: "Admin/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                  name: "Student",
                  areaName: "Student",
                  pattern: "Student/{controller=Home}/{action=Index}");

                endpoints.MapAreaControllerRoute(
                 name: "Staff",
                 areaName: "Staff",
                 pattern: "Staff/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });

            StudentManagementIdentityDataInitializer.SeedData(userManager, roleManager);
        }
    }
}

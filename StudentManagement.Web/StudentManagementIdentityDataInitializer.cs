
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using StudentManagement.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentManagementIdentityDataInitializer
    {
   
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<Role> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            var user = new ApplicationUser
            {
                FirstName = "Aman",
                LastName = "Sharma",
                MiddleName = "",
                UserName = "ams@narola.email",
                OfficialEmail = "ams@narola.email",
                NormalizedUserName = "Admin",
                Email = "ams@narola.email",
                NormalizedEmail = "ams@narola.email",
                EmailConfirmed = true,
                IsActive = true,
              

            };
            if (userManager.FindByEmailAsync(user.UserName).Result != null) return;

            var result = userManager.CreateAsync(user, "Password123#").Result;

            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user, "Admin").Wait();
            }

            var studentUser = new ApplicationUser
            {
                FirstName = "Bharat",
                LastName = "B",
                MiddleName = "",
                UserName = "Bharat@gmail.com",
                OfficialEmail = "Bharat@gmail.com",
                NormalizedUserName = "Student",
                Email = "Bharat@gmail.com",
                NormalizedEmail = "Bharat@gmail.com",
                EmailConfirmed = true,
                IsActive = true,


            };
            if (userManager.FindByEmailAsync(studentUser.UserName).Result != null) return;

            var StudentResult = userManager.CreateAsync(studentUser, "Password123#").Result;

            if (StudentResult.Succeeded)
            {
                userManager.AddToRoleAsync(studentUser, "Student").Wait();
            }


            var user2 = new ApplicationUser
            {
                FirstName = "vrushal",
                LastName = "s",
                MiddleName = "",
                UserName = "vrushal@gmail.com",
                OfficialEmail = "vrushal@gmail.com",
                NormalizedUserName = "vrushal@gmail.com",
                Email = "vrushal@gmail.com",
                NormalizedEmail = "vrushal@gmail.com",
                EmailConfirmed = true,
                IsActive = true,

            };
            if (userManager.FindByEmailAsync(user2.UserName).Result != null) return;

            var vresult = userManager.CreateAsync(user2, "Password123#").Result;

            if (vresult.Succeeded)
            {
                userManager.AddToRoleAsync(user2, "Student").Wait();
            }



            var TeacherUser = new ApplicationUser
            {
                FirstName = "Staff",
                LastName = "s",
                MiddleName = "",
                UserName = "Staff@gmail.com",
                OfficialEmail = "Staff@gmail.com",
                NormalizedUserName = "Staff",
                Email = "Staff@gmail.com",
                NormalizedEmail = "Staff@gmail.com",
                EmailConfirmed = true,
                IsActive = true,


            };
            if (userManager.FindByEmailAsync(TeacherUser.UserName).Result != null) return;

            var teacherResult = userManager.CreateAsync(TeacherUser, "Password123#").Result;

            if (teacherResult.Succeeded)
            {
                userManager.AddToRoleAsync(TeacherUser, "Staff").Wait();
            }



        }

        private static void SeedRoles(RoleManager<Role> roleManager)
        {
            #region User Roles
            Dictionary<string, string> normalizedName = new Dictionary<string, string>
            {
                { "Admin", "Admin"},
                { "Student", "Student"},
                { "User", "User"},
                { "Staff", "Staff"},
            };

            var existrolesList = roleManager.Roles.Select(x => x.Name).ToList();
            if (existrolesList.Any())
            {
                var notExirst = normalizedName.Keys.Except(existrolesList);
                foreach (var notRole in notExirst)
                {
                    string normalized = normalizedName.FirstOrDefault(x => x.Key == notRole).Value;
                    var roleResult = roleManager.CreateAsync(new Role { Name = notRole, ConcurrencyStamp = notRole }).Result;
                }
            }
            else
            {
                foreach (var objRole in normalizedName.Keys)
                {
                    string normalized = normalizedName.FirstOrDefault(x => x.Key == objRole).Value;
                    IdentityResult roleResult = roleManager.CreateAsync(new Role { Name = objRole,ConcurrencyStamp =objRole}).Result;
                }
            }
            #endregion
        }

        public static long GetTimeZoneId(string currentTimeZone, string connection)
        {
            using (var sqlCon = new SqlConnection(connection))
            {
                var query = $@"EXEC GetCurrentTimeZone '{currentTimeZone}';";
                sqlCon.Open();
                var sqlCmd = new SqlCommand(query, sqlCon);
                var result = sqlCmd.ExecuteScalar();
                sqlCon.Close();
                return (long?)result ?? 0;
            }
        }
    }
}

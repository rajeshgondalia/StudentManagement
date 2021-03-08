using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class StaffAccessRepostitory : GenericRepository<StaffAccess>, IStaffAccessService
    {
        private readonly StudentDbContext _context;

        public StaffAccessRepostitory(StudentDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
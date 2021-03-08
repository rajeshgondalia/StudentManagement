using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
   public class MenuAccessRepository : GenericRepository<MenuAccess>, IMenuAccessService
    {
        private readonly StudentDbContext _context;

        public MenuAccessRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
     

    }
}

using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Implementation
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserService
    {
        private readonly StudentDbContext _context;
        public UserRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        //public async Task<List<UserDto>> GetUserList(SqlParameter[] paraObjects)
        //{
        //    var dataSet = await _context.GetQueryDatatableAsync(StoredProcedureList.GetUserList, paraObjects);
        //    return Common.ConvertDataTable<UserDto>(dataSet.Tables[0]);
        //}
    }
}

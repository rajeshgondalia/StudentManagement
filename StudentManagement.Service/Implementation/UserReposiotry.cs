using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagement.Data;
using StudentManagement.Data.DBContexts;
using System;
using System.Collections.Generic;
using System.Text;
using StudentManagement.Data.Extensions;
using System.Threading.Tasks;
using StudentManagement.Data.Utility;
using Microsoft.Data.SqlClient;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Dto;

namespace StudentManagement.Service.Implementation
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserService
    {
        private readonly StudentDbContext _context;
        public UserRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<StudentDto>> GetStudentList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetStudentList, paraObjects);
            return Common.ConvertDataTable<StudentDto>(dataSet.Tables[0]);
        }
    }
}

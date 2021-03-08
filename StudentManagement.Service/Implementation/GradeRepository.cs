using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StudentManagementAdmin.Data.Utility;
using StudentManagementAdmin.Data.Extensions;
using StudentManagement.Service.Dto;
using StudentManagement.Service.GlobalConstant;

namespace StudentManagement.Service.Implementation
{
  
    public class GradeRepository : GenericRepository<Grades>, IGradeService
    {
        private readonly StudentDbContext _context;

        public GradeRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<GradeDto>> GetGradeList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetGradeList, paraObjects);
            return Common.ConvertDataTable<GradeDto>(dataSet.Tables[0]);
        }

    }
}

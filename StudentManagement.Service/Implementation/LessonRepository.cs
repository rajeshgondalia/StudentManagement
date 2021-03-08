using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using StudentManagement.Service.Implementation.BaseService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StudentManagementAdmin.Data.Extensions;
using StudentManagementAdmin.Data.Utility;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Dto;

namespace StudentManagement.Service.Implementation
{
    public class LessonRepository : GenericRepository<Lessons>, ILessonService
    {
        private readonly StudentDbContext _context;

        public LessonRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<LessonDto>> GetLessonList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetLessonList, paraObjects);
            return Common.ConvertDataTable<LessonDto>(dataSet.Tables[0]);
        }
    }
}
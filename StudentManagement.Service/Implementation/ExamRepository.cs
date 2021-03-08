using StudentManagement.Service.Dto;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Utility;
using StudentManagement.Data.Extensions;
using StudentManagement.Data.Models;

namespace StudentManagement.Service.Implementation
{
   public class ExamRepository : GenericRepository<CourseMaster>, IExamService
    {
        private readonly StudentDbContext _context;

        public ExamRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<ExamDto>> GetExamList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetExamList, paraObjects);
            return Common.ConvertDataTable<ExamDto>(dataSet.Tables[0]);
        }
        public async Task<List<ExamDto>> GetQuestionList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetQuestionList, paraObjects);
            return Common.ConvertDataTable<ExamDto>(dataSet.Tables[0]);
        }

    }
}

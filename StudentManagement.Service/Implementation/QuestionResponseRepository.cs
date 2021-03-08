using StudentManagement.Service.Dto;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using StudentManagementAdmin.Data.Extensions;
using StudentManagementAdmin.Data.Utility;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Implementation
{
   public class QuestionResponseRepository : GenericRepository<QuestionResponse>, IQuestionResponseService
    {
        private readonly StudentDbContext _context;

        public QuestionResponseRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<QADto>> GetQAReport(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetQADateWiseReport, paraObjects);
            return Common.ConvertDataTable<QADto>(dataSet.Tables[0]);
        }
    }
}

   
   
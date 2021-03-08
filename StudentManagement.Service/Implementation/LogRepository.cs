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
   public class LogRepository : GenericRepository<Log>, ILogService
    {
        private readonly StudentDbContext _context;

        public LogRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<StaffDto>> GetStaffList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetStaffList, paraObjects);
            return Common.ConvertDataTable<StaffDto>(dataSet.Tables[0]);
        }
        public async Task<List<StaffReportDto>> GetStaffOperationReport(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetStaffOperationReport, paraObjects);
            return Common.ConvertDataTable<StaffReportDto>(dataSet.Tables[0]);
        }
    }
}
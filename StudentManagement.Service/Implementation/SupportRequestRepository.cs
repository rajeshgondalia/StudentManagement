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
    public class SupportRequestRepository : GenericRepository<SupportRequest>, ISupportRequestService
    {
        private readonly StudentDbContext _context;

        public SupportRequestRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<SupportReportDto>> GetSupportReportList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetSupportReportList, paraObjects);
            return Common.ConvertDataTable<SupportReportDto>(dataSet.Tables[0]);
        }
        public async Task<List<SupportResponseDto>> GetSupportHistoryList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetSupportHistoryList, paraObjects);
            return Common.ConvertDataTable<SupportResponseDto>(dataSet.Tables[0]);
        }

    }
}
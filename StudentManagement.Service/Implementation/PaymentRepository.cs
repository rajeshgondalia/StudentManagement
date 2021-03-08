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
   public class PaymentRepository : GenericRepository<Payments>, IPaymentService
    {
        private readonly StudentDbContext _context;

        public PaymentRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<PaymentHistoryDto>> GetPaymentByTutorList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetPaymentHistoryByTutor, paraObjects);
            return Common.ConvertDataTable<PaymentHistoryDto>(dataSet.Tables[0]);
        }
        public async Task<List<PaymentHistoryDto>> GetPaymentByStaffList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetPaymentHistoryByStaff, paraObjects);
            return Common.ConvertDataTable<PaymentHistoryDto>(dataSet.Tables[0]);
        }

    }
}

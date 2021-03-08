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
   public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionService
    {
        private readonly StudentDbContext _context;

        public SubscriptionRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<SubscriptionDto>> GetSubscriptionList(SqlParameter[] paraObjects)
        {
            var dataSet = await _context.GetQueryDatatableAsync(SpConstants.GetSubscriptionList, paraObjects);
            return Common.ConvertDataTable<SubscriptionDto>(dataSet.Tables[0]);
        }
    }
}

using StudentManagement.Service.Dto;
using StudentManagement.Service.Interface.BaseInterface;
using StudentManagementAdmin.Data.DbModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface ISubscriptionService: IGenericService<Subscription>
    {
        Task<List<SubscriptionDto>> GetSubscriptionList(SqlParameter[] paraObjects);
    }
}

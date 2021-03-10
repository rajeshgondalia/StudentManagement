using StudentManagementAdmin.Data.DbModel;
using StudentManagement.Service.Interface.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

using StudentManagement.Data.Models;

namespace StudentManagement.Service.Interface
{
    public interface IErrorLogService : IGenericService<ErrorLog>
    {
        void AddErrorLog(System.Exception ex, string appType);
    }
}

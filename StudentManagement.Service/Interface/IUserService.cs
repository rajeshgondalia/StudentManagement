using StudentManagement.Service.Interface.BaseInterface;
using StudentManagementAdmin.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement.Service.Interface
{
    public interface IUserService : IGenericService<ApplicationUser>
    {
    }
}

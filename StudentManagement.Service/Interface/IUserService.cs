
using Microsoft.Data.SqlClient;
using StudentManagement.Data.DBContexts;
using StudentManagement.Service.Dto;
using StudentManagement.Service.Interface.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface IUserService : IGenericService<ApplicationUser>
    {
        Task<List<StudentDto>> GetStudentList(SqlParameter[] paraObjects);
    }
}

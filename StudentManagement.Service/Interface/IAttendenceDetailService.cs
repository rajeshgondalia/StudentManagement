using Microsoft.Data.SqlClient;
using StudentManagement.Data.Models;
using StudentManagement.Service.Dto;
using StudentManagement.Service.Interface.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Interface
{
    public interface IAttendenceDetailService : IGenericService<StudentAttendanceDetail>
    {
        Task<List<StudentClassDetailDto>> GetClassDetailList(SqlParameter[] paraObjects);
    }
}

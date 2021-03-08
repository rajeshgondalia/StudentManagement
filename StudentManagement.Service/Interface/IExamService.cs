using StudentManagement.Service.Dto;
using StudentManagement.Service.Interface.BaseInterface;
using StudentManagementAdmin.Data.DbModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Data.Models;

namespace StudentManagement.Service.Interface
{
 public  interface IExamService : IGenericService<CourseMaster>
    {
        Task<List<ExamDto>> GetExamList(SqlParameter[] paraObjects);
        Task<List<ExamDto>> GetQuestionList(SqlParameter[] paraObjects);
    }
}
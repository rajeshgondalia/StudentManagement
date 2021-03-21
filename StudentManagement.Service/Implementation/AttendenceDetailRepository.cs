using Microsoft.Data.SqlClient;
using StudentManagement.Data.DBContexts;
using StudentManagement.Data.Extensions;
using StudentManagement.Data.Models;
using StudentManagement.Data.Utility;
using StudentManagement.Service.Dto;
using StudentManagement.Service.GlobalConstant;
using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Service.Implementation
{
  public  class AttendenceDetailRepository : GenericRepository<StudentAttendanceDetail>, IAttendenceDetailService
    {
        private readonly StudentDbContext _db;
        public AttendenceDetailRepository(StudentDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<List<StudentClassDetailDto>> GetClassDetailList(SqlParameter[] paraObjects)
        {
            var dataSet = await _db.GetQueryDatatableAsync(SpConstants.GetClassDetailList, paraObjects);
            return Common.ConvertDataTable<StudentClassDetailDto>(dataSet.Tables[0]);
        }

    }
}

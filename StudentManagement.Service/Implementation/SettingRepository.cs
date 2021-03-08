using StudentManagement.Service.Implementation.BaseService;
using StudentManagement.Service.Interface;
using StudentManagementAdmin.Data;
using StudentManagementAdmin.Data.DbModel;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudentManagement.Service.Implementation
{
   public class SettingRepository : GenericRepository<Settings>, ISettingService
    {
        private readonly StudentDbContext _context;

        public SettingRepository(StudentDbContext context) : base(context)
        {
            _context = context;
        }

        public void AddSettings(Settings objsettings)
        {
            throw new NotImplementedException();
        }
    }
}

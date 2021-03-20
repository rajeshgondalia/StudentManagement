
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using StudentManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyLearnerAdmin.Utility.JqueryDataTable
{
    public static class CommonMethod
    {
        #region Get Common JQuery Datatable Sql Param List
        public static  JQueryDataTableSqlParam GetJQueryDatatableParamList(JQueryDataTableParamModel param, string sortingColumn)
        {
            var searchRecords = new SqlParameter { ParameterName = "@SearchRecords", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
            var parameters = new JQueryDataTableSqlParam()
            {
                SearchRecord = searchRecords,
                Parameters = new List<SqlParameter>
                {
                    new SqlParameter("@iDisplayStart",SqlDbType.Int){Value = param.iDisplayStart},
                    new SqlParameter("@iDisplayLength",SqlDbType.Int){Value = param.iDisplayLength},
                    new SqlParameter("@SortColumn",SqlDbType.VarChar){Value = sortingColumn},
                    new SqlParameter("@SortDir",SqlDbType.VarChar){Value = param.sSortDir_0 ?? ""},
                    new SqlParameter("@Search",SqlDbType.NVarChar){Value = param.sSearch ?? ""},
                    searchRecords
                }
            };

            return parameters;
        }
        
        #endregion


    #region File Operations

    public static string CheckServerPath(string currentPath, string folderPath, string fileName)
    {
        var fullPath = Path.Combine(currentPath, folderPath);
        if (!Directory.Exists(fullPath))
            Directory.CreateDirectory(fullPath);
        return Path.Combine(fullPath, fileName);
    }

    public static string GetFileName(string oldName)
    {
        return $@"{DateTime.Now.Ticks}{Path.GetExtension(oldName)}";
    }

    public static void DeleteFile(string path, bool isFullPath = false)
    {
        if (string.IsNullOrEmpty(path)) return;
        var fullPath = isFullPath ? path : Path.Combine(path);
        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }
    }

    public static async Task UploadFileAsync(string currentPath, string folderPath, string fileName, IFormFile file)
    {
        string path = CheckServerPath(currentPath, folderPath, fileName);
        using (var stream = new FileStream(path, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
    }


        /// <summary>
        /// Will return null if the CLR datetime will not fit in an SQL datetime
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime? EnsureSQLSafe(this DateTime? datetime)
        {
            if (datetime.HasValue && (datetime.Value < (DateTime)SqlDateTime.MinValue || datetime.Value > (DateTime)SqlDateTime.MaxValue))
                return null;

            return datetime;
        }

        #endregion
    }
}

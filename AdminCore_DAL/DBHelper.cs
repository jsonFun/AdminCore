using AdminCore_Comm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCore_DAL
{
    public class DBHelper : DbContext
    {
        /// <summary>
        /// 读取SqlServer地址
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SysConfig.SqlServerConfig);
            base.OnConfiguring(optionsBuilder);
        }
    }
}

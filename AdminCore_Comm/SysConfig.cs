using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCore_Comm
{
    public class SysConfig
    {
        //AppConfigurtaionServices.Configuration["ServiceUrl"]; //读取一级配置节点配置
        //AppConfigurtaionServices.Configuration["Appsettings:SystemName"]; //读取二级子节点配置
        private static string _SqlServerConfig = "";
        /// <summary>
        /// sqlserver连接地址
        /// </summary>
        public static string SqlServerConfig
        {
            get {
                _SqlServerConfig = "Data Source=.;Initial Catalog=AdminCore;Persist Security Info=True;User ID=sa;Password=8023";
                if (string.IsNullOrEmpty(_SqlServerConfig))
                {
                    _SqlServerConfig = ConfigHelper.Configuration.GetConnectionString("SqlServerConnection"); 
                }
               
                return _SqlServerConfig;
            }
        }
    }
}

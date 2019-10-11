using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminCore_Web.Models;
using AdminCore_Comm;

namespace AdminCore_Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string strTmp = "abcdefg某某某";
            int i = System.Text.Encoding.Default.GetBytes(strTmp).Length;
            int j = strTmp.Length;
            var ss = SysConfig.SqlServerConfig;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

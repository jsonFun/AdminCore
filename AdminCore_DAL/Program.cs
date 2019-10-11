using AdminCore_DAL.Dal;
using AdminCore_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdminCore_DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public async static Task  add()
        {
            Users users = new Users();
            users.CreateTime = DateTime.Now.ToString();
            users.CreateUser = "test";
            users.Email = "123@qq.com";
            users.LoginName = "admin";
            users.Password = "admin";
            users.Name = "管理员";
            users.Phone = "1100";
            users.Qq = "709930795";
            UserDal ud = new UserDal();
            await ud.AddUsers(users);
        }
    }
}

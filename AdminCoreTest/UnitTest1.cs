using AdminCore_DAL.Dal;
using AdminCore_Entity.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AdminCoreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public async System.Threading.Tasks.Task AddUsersTestAsync()
        {
            Users users = new Users();
            users.CreateTime = DateTime.Now.ToString();
            users.CreateUser = "test";
            users.Email = "123@qq.com";
            users.LoginName = "admin";
            users.Password = "admin";
            users.Name = "π‹¿Ì‘±";
            users.Phone = "1100";
            users.Qq = "709930795";
            UserDal ud = new UserDal();
            await ud.AddUsers(users);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task UpdateUsersTestAsync()
        {
            Users users = new Users();
            users.UpdateTime = DateTime.Now.ToString();
            users.UpdateUser = "admin";
            users.Id = 1;
            UserDal ud = new UserDal();
            await ud.UpdateUser(users);
        }
        [TestMethod]
        public async System.Threading.Tasks.Task DeleteUsersTestAsync()
        {
            Users users = new Users();
            users.Id = 1;
            UserDal ud = new UserDal();
            await ud.DeleteUser(users);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetUsersTestAsync()
        {
            UserDal ud = new UserDal();
            var ss = await ud.GetUsers();
        }


    }
}

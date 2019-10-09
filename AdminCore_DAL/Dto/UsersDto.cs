using AdminCore_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCore_DAL.Dto
{
    public class UsersDto
    {
        public int code { get; set; }

        public string msg { get; set; }

        public int count { get; set; }

        public List<Users> data { get; set; }
    }
}

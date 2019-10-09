using System;
using System.Collections.Generic;

namespace AdminCore_Entity.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public int? Status { get; set; }
        public string CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateTime { get; set; }
        public string UpdateUser { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WeiXin { get; set; }
        public string Qq { get; set; }
    }
}

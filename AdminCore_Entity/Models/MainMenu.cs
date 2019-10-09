using System;
using System.Collections.Generic;

namespace AdminCore_Entity.Models
{
    public partial class MainMenu
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public int? Status { get; set; }
        public string CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}

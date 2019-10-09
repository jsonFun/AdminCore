using System;
using System.Collections.Generic;

namespace AdminCore_Entity.Models
{
    public partial class ChildrenMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? MenuId { get; set; }
        public int? Status { get; set; }
        public string CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}

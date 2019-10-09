using AdminCore_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCore_DAL.Dto
{
   public  class MenuDto
    {
        public MainMenu mainMenu { get; set; }
        public List<ChildrenMenu> childrenMenus { get; set; }
    }
}

using AdminCore_DAL.Dto;
using AdminCore_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCore_DAL.Dal
{
    public class MenuDal
    {
        public async Task<List<MenuDto>> GetMenu()
        {
            List<MenuDto> dtos = new List<MenuDto>();
            try
            {
                AdminCoreContext acc = new AdminCoreContext();
                await Task.Run(() =>
                {
                    var menus = acc.MainMenu.ToList();

                });
                
            }
            catch (Exception ex)
            {

                throw;
            }
            return dtos;
        }
    }
}

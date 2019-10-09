using AdminCore_DAL.Dto;
using AdminCore_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCore_DAL.Dal
{
    public class UserDal
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public async Task<UsersDto> GetUsers()
        {

            UsersDto dtos = new UsersDto();
            try
            {
                AdminCoreContext db = new AdminCoreContext();
                await Task.Run(() =>
                {
                    var users = db.Users.ToList();
                    dtos.code = 0;
                    dtos.msg = "";
                    dtos.count = users.Count;
                    dtos.data = users;

                });
            }
            catch (Exception ex)
            {
                
                dtos.code = 1;
                dtos.msg = "查询用户信息失败";
            }
            return dtos;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<ResultDto<string>> AddUsers(Users users)
        {
            ResultDto<string> resultDto = new ResultDto<string>();
            try
            {
                AdminCoreContext db = new AdminCoreContext();
                var userinfo = await db.Users.AddAsync(users);
                await db.SaveChangesAsync();
                resultDto.IsSuccess = true;
                resultDto.ResultMsg = userinfo.Entity.Id.ToString();
            }
            catch (Exception ex)
            {
                resultDto.IsSuccess = false;
                resultDto.ErrMsg = "新增用户失败";
            }
            return resultDto;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<ResultDto<string>> UpdateUser(Users users)
        {
            ResultDto<string> resultDto = new ResultDto<string>();
            resultDto.IsSuccess = true;
            try
            {
                AdminCoreContext db = new AdminCoreContext();
                db.Users.Update(users);
                await db.SaveChangesAsync();
                resultDto.IsSuccess = true;
            }
            catch (Exception ex)
            {
                resultDto.IsSuccess = false;
                resultDto.ErrMsg = "更新用户信息失败";
            }
            return resultDto;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public async Task<ResultDto<string>> DeleteUser(Users users)
        {
            ResultDto<string> resultDto = new ResultDto<string>();
            resultDto.IsSuccess = true;
            try
            {
                AdminCoreContext db = new AdminCoreContext();
                db.Remove(users);
                await db.SaveChangesAsync();
                resultDto.IsSuccess = true;
            }
            catch (Exception ex)
            {
                resultDto.IsSuccess = false;
                resultDto.ErrMsg = "删除用户信息失败";
            }
            return resultDto;
        }
    }
}

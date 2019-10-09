using System;
using System.Collections.Generic;
using System.Text;

namespace AdminCore_DAL.Dto
{
    public class ResultDto<T>
    {
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }

        public T ResultMsg { get; set; }
    }
}

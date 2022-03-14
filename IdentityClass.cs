using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中铁流水线管理端
{
   public class IdentityClass
    {
        /// <summary>
        /// 工号
        /// </summary>
        public string JobId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 身份
        /// </summary>
       public string Identity { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }
    }
}

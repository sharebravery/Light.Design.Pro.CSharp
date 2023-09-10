using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Design.Pro.CSharp.Application.Models
{   
    public class User: Entity
    {
        /// <summary>
        /// 用户
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户名(显示)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 邮箱确认
        /// </summary>
        public bool EmailConfirmed { get; set; }
    }
}

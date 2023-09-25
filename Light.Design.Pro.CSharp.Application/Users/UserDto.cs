using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Design.Pro.CSharp.Application.Users
{
    public class UserDto: Entity
    {
        /// <summary>
        /// 账号
        /// </summary>
        [MinLength(3)]
        public string Account { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string? NickName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

    }
}

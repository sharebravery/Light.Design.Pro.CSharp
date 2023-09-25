using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Design.Pro.CSharp.Application.Auth.Dtos
{
    public class LoginDataDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required, MinLength(3)]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required, MinLength(4)]
        public string Password { get; set; }
    }
}

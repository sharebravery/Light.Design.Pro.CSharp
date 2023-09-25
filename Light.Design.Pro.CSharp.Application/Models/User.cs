using Light.Design.Pro.CSharp.Application.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Light.Design.Pro.CSharp.Application.Models
{
    public class User : UserDto
    {
        /// <summary>
        /// 邮箱确认
        /// </summary>
        public bool? EmailConfirmed { get; set; }
    }
}

using Furion.DatabaseAccessor;
using Light.Design.Pro.CSharp.Application.Auth.Dtos;
using Light.Design.Pro.CSharp.Application.Models;
using Light.Design.Pro.CSharp.Application.Users;
using Microsoft.AspNetCore.Http;

namespace Light.Design.Pro.CSharp.Application.Auth
{
    public class Account: IDynamicApiController
    {
        private readonly IRepository<User> _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Account(IRepository<User> userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginDataDto"></param>
        [AllowAnonymous]
        public async Task SignInAsync(LoginDataDto loginDataDto)
        {
            User user = await _userRepository.FirstOrDefaultAsync(u => u.Account == loginDataDto.Account);

            if(user == null)
            {
                throw new InvalidOperationException("无此账号");
            }

            if(user.Password != DESCEncryption.Encrypt(user.CreatedTime.ToString(),loginDataDto.Password))
            {
                throw new InvalidOperationException("密码错误");
            }

            var accessToken = JWTEncryption.Encrypt(new Dictionary<string, object>()
            {
                { "UserId", user.Id },  // 存储Id
                { "Account",user.Account }, // 存储用户名
            });
            var refreshToken = JWTEncryption.GenerateRefreshToken(accessToken, 43200);

            _httpContextAccessor.HttpContext.Response.Headers["access-token"] = accessToken;

            _httpContextAccessor.HttpContext.Response.Headers["x-access-token"] = refreshToken;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public async Task<User> Register(UserDto dto)
        {

            User exist = await _userRepository.FirstOrDefaultAsync(u => u.Account == dto.Account);

            if (exist != null)
            {
                throw Oops.Oh("用户已存在") ;
            }

            var user = dto.Adapt<User>();

            user.Password = DESCEncryption.Encrypt(user.CreatedTime.ToString(), user.Password);

            var u = await _userRepository.InsertNowAsync(user);
            return u.Entity;

        }
    }
}

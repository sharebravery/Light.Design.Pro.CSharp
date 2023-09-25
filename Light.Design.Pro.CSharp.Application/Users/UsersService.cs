using Light.Design.Pro.CSharp.Application.Models;

namespace Light.Design.Pro.CSharp.Application.Users
{
    public class UsersService: IDynamicApiController, IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UsersService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user"></param>
        public void Add(User user) => _userRepository.Insert(user);

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <returns></returns>
        public User Find()
        {
            var user = _userRepository.Find(1);

            if (user == null)
            {
                throw Oops.Oh(404);
            }

            return user;
        }

        /// <summary>
        /// 根据ID查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User FindById(int id)
        {
            User user= _userRepository.Find(id);

            if (user == null)
            {
                throw Oops.Oh(404);
            }

            return user;
        }
    }
}

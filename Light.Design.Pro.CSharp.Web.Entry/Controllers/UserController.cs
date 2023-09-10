using Furion.DatabaseAccessor;
using Furion.FriendlyException;
using Light.Design.Pro.CSharp.Application.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]/[action]")]
public class UserController: ControllerBase
{
    private readonly IRepository<User> _userRepository;
    public UserController(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// 新增用户
    /// </summary>
    /// <param name="user"></param>
    [HttpPost]
    public void AddUser(User user) => _userRepository.Insert(user);

    /// <summary>
    /// 条件查询
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public User Find()
    {
        var user = _userRepository.Find(1);

        if (user == null)
        {
             throw Oops.Oh(404);
        }

        return user;
    }
}
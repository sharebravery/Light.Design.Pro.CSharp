using Light.Design.Pro.CSharp.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Design.Pro.CSharp.Application.Users
{
    public interface IUserService
    {
        public void Add(User user);

        public User Find();
                public User FindById(int id);
    }
}

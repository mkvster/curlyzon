using Curlyzon.Model;
using Curlyzon.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curlyzon.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public SessionUserInfo Login(string userName, string password)
        {
            //TODO
            return new SessionUserInfo()
            {
                UserId = userName,
                UserRoles = new List<string>() { "admin" }
            };
        }
    }
}

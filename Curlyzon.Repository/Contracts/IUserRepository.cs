using Curlyzon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curlyzon.Repository.Contracts
{
    public interface IUserRepository
    {
        SessionUserInfo Login(string userName, string password);
    }
}

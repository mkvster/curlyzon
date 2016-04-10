using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curlyzon.Model
{
    public class SessionUserInfo
    {
        public String UserId { get; set; }
        public List<String> UserRoles { get; set; }
    }
}

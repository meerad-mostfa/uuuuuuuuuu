using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp_core.Modles
{
    public class Role : IdentityUser
    {
        public string RoleId { get; set; }
        public string Name { get; set; }

        // العلاقة مع المستخدمين
        public List<User> Users { get; set; }
    }
}

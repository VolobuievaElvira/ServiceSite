using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enums;

namespace ClassLibrary.Users
{
    public class Admin : User
    {
        public Admin(int id, string name, string email, string password)
            : base(id, name, email, password)
        {
            ChangeRole(UserRole.Admin);
        }
    }
}

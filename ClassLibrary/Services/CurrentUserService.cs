using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces.Services;
using ClassLibrary.Users;

namespace ClassLibrary.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        User? _user;

        public User? GetUser()
        {
            return _user;
        }

        public void SetUser(User? user)
        {
            _user = user;
        }
    }
}

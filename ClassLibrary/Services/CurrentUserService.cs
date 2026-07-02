using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Classes;

namespace ClassLibrary.Services
{
    public class CurrentUserService
    {
        User? _user;

        public User? GetUser()
        {
            return _user;
        }

        public void SetUser(User user)
        {
            _user = user;
        }
    }
}

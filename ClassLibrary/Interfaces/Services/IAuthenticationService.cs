using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Services
{
    public interface IAuthenticationService
    {
        User? Login(string email, string password);
        void Logout();
    }
}

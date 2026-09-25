using ClassLibrary.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Exceptions;
using ClassLibrary.Enums;
using ClassLibrary.Interfaces.Data;
using ClassLibrary.Interfaces.Services;
using ClassLibrary.Users;

namespace ClassLibrary.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICurrentUserService _currentUserService;
        public AuthenticationService(IUserRepository userRepository, ICurrentUserService currentUserService)
        {
            _userRepository = userRepository;
            _currentUserService = currentUserService;
        }

        public User? Login(string email, string password)
        { 
            User? user = _userRepository.GetAll()
                .FirstOrDefault(x => Equals(x.Email, email));

            if (user != null && user.VerifyPassword(password))
            {
                _currentUserService.SetUser(user);
                return user;
            }
            
            throw new CustomException(AppMessage.LoginFailed);
        }

        public void Logout()
        {
            _currentUserService.SetUser(null);
        }
    }
}

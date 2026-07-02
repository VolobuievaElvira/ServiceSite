using ClassLibrary.Data;
using ClassLibrary.Classes;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserRepository _repository;

        public AuthenticationService(UserRepository repository)
        {
            _repository = repository;
        }

        public User? Login(string email, string password)
        {
            List<User> l = _repository.GetAll().ToList<User>();
            foreach (var usera in l)
            {
                Console.WriteLine($"{usera.Name}, {usera.Email}, {usera.Password}");
            }

            User? user = _repository.GetAll()
                .FirstOrDefault(x => Equals(x.Email, email) && Equals(x.Password, password), null);
            //.FirstOrDefault(x => (x.Email == email) && (x.Password == password), null);

            return user;
        }
    }
}

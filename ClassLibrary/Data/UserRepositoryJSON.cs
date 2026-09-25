using ClassLibrary.Interfaces.Data;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class UserRepositoryJSON : IUserRepository
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void AddUser(User user) 
        {
            _users.Add(user); 
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }

        //LoadJSON
    }
}

using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class UserRepository
    {
        private List<User> _users = new();

        public List<User> GetAll()
        {
            return _users;
        }

        public void AddUser(User user) 
        {
            _users.Add(user); 
        }

        //LoadJSON
    }
}

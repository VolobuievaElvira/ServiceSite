using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enums;

namespace ClassLibrary.Users
{
    public class Master : User
    {
        public string Bio { get; private set; } = string.Empty;
        public List<ServiceType> Skills { get; private set; } = new();

        public Master(int id, string name, string email, string password)
            : base(id, name, email, password)
        {
            ChangeRole(UserRole.Master);
        }

        public void UpdateBio(string bio) => Bio = bio;
        public void UpdateSkills(List<ServiceType> skills) => Skills = skills;
    }
}

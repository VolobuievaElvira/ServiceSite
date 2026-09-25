using ClassLibrary.Enums;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces.Profile
{
    interface IMasterProfileManagementService : IUserProfileManagementService
    {
        void UpdateBio(Master master, string bio);
        void UpdateSkills(Master master, List<ServiceType> skills);
    }
}

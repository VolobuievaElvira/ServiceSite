using ClassLibrary.Enums;
using ClassLibrary.Interfaces.Data;
using ClassLibrary.Interfaces.Profile;
using ClassLibrary.Interfaces.Services;
using ClassLibrary.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary.ProfileManagementService
{
    class MasterProfileManagementService: UserProfileManagementService, IMasterProfileManagementService
    {
        public MasterProfileManagementService(IUserRepository userRepository, ICurrentUserService currentUserService)
            : base(userRepository, currentUserService)
        {
        }
        public void UpdateBio(Master master, string bio) => master.UpdateBio(bio);
        public void UpdateSkills(Master master, List<ServiceType> skills) => master.UpdateSkills(skills);
    }
}

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
    class UserProfileManagementService: IUserProfileManagementService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICurrentUserService _currentUserService;

        public UserProfileManagementService(IUserRepository userRepository, ICurrentUserService currentUserService)
        {
            _userRepository = userRepository;
            _currentUserService = currentUserService;
        }
        public void ChangeName(User user, string newName) => user.ChangeName(newName);
        public void ChangeEmail(User user, string newEmail) => user.ChangeEmail(newEmail);
        public void ChangePassword(User user, string oldPassword, string newPassword)
        {
            if (user.VerifyPassword(oldPassword))
            {
                user.ChangePassword(newPassword);
            }//add if the oldPassword is not correct
        }
        public void ChangePhoto(User user, string newPhotoPath) => user.ChangePhoto(newPhotoPath);

        public void DeleteAccount(User user)
        {
            if (user is null) return;

            if (_currentUserService.GetUser().Id == user.Id)
            {
                _currentUserService.SetUser(null);
            }

            _userRepository.RemoveUser(user);
        }
    }
}

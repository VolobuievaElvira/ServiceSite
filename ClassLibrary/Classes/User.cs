using ClassLibrary.Classes;
using ClassLibrary.Enums;
using System;

namespace ClassLibrary.Classes
{
	public class User
	{
		public Guid Id { get; private set;  }

        private string _name;
        private string _email;
        private string _password;
        private string _photo = "smth standard";//need changes;
        public string Name 
		{
			get
			{
				return _name;
			}
			private set
			{
				if (true)//(value.Trim().Length > 0)
				{
					_name = value;
				}
				else ;//throw exception
			} 
		}
		public string Email 
		{
			get
			{
				return _email;
			} 
			private set
			{
                if (true)//add checks
                {
                    _email = value;
                }
                else;//throw exception
            }
		}
		public string Password 
		{
			get
			{
				return _password;
			} 
			private set
			{
                if (true)//add checks
                {
                    _password = value;
                }
                else;//throw exception
            }
		}
		public string Photo 
		{
			get
			{
				return _photo;
			}
			private set
			{
				if (true)//add checks
				{
					_photo = value;
				}
				else _photo = "smth standard";//need changes
            } 
		}
	
		public UserRole UserRole { get; private set; }

		public User()
		{
			Id = Guid.NewGuid();
		}

		public User(string name, string email, string password):this()
		{
			ChangeName(name);
			ChangeEmail(email);
			ChangePassword(password);
		}

		public void PromoteToCostumer()
		{
			UserRole = UserRole.Costumer;
		}

        public void PromoteToMaster()
        {
            UserRole = UserRole.Master;
        }

        public void PromoteToAdmin()
        {
            UserRole = UserRole.Admin;
        }


		public void ChangeName(string name) { Name = name; }
        public void ChangeEmail(string email) { Email = email; }
        public void ChangePassword(string password) { Password = password; }
        public void ChangePhoto(string photo) { Photo = photo; }
    }
}
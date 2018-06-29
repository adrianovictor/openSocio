using System;
using OpenSocio.Common;
using OpenSocio.Common.Extensions;
using OpenSocio.Domain.Common;

namespace OpenSocio.Domain.Model
{
    public class User : Entity<User>
    {
        public string Name { get; set; }
        public string UserName { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public UserStatus Status { get; set; }

        public User(string name, string userName, string email, string password, string image = null, UserStatus status = UserStatus.Active)
        {
            if (name.IsEmpty()) throw new ArgumentNullException(nameof(name));
            if (userName.IsEmpty()) throw new ArgumentNullException(nameof(userName));
            if (password.IsEmpty()) throw new ArgumentNullException(nameof(password));

            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
            Image = image;
            Status = status;
        }

        public void ChangeStatus(UserStatus status)
        {
            if (Status == UserStatus.Deleted)
                throw new CannotChangeStatusOfADeletedEntityException();
            
            Status = status;

            if (Status == UserStatus.Deleted)
            {
                Email = $"DELETED.{DateTime.Now.ToTimestamp()}.{Email}";
                UserName = $"DELETED.{DateTime.Now.ToTimestamp()}.{UserName}";
            }            
        }

        public void ChangeAvatar(string image)
        {
            Image = image;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
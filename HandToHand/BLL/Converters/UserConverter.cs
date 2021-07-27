using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Converters
{
    public static class UserConverter
    {
        public static User Map(UserDTO user)
        {
            return new User
            {
                UserAdress=user.UserAdress,
                UserFirstName=user.UserFirstName,
                UserId=user.UserId,
                UserLastName=user.UserLastName,
                UserPhone=user.UserPhone,
                UserMail=user.UserMail,
                UserPassword=user.UserPassword,
                
            };
        }

      

        public static UserDTO Map(User user)
        {
            return new UserDTO
            {
                UserAdress = user.UserAdress,
                UserFirstName = user.UserFirstName,
                UserId = user.UserId,
                UserLastName = user.UserLastName,
                UserPhone = user.UserPhone,
                UserMail = user.UserMail,
                UserPassword = user.UserPassword,
                
            };
        }

        public static List<UserDTO> Map(List<User> users)
        {
            return users.Select(u => Map(u)).ToList();
        }


        }
}

using BLL.Converters;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL
    {
        UsersDAL usersDAL = new UsersDAL();

        public List<UserDTO> GetAllUsers()
        {
            return UserConverter.Map(usersDAL.GetAllUsers());
        }

        public bool AddUser(UserDTO user)
        {
           return usersDAL.AddUser(UserConverter.Map(user));
        }

        public long Login(string mail, string password)
        {
            User user = usersDAL.GetAllUsers().FirstOrDefault(u => u.UserMail == mail && u.UserPassword == password);
            if (user != null)
                return user.UserId;
            return -1;
        }
    }
}

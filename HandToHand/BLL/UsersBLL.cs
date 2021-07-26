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

        public void AddUser(UserDTO user)
        {
            usersDAL.AddUser(UserConverter.Map(user));
        }
    }
}

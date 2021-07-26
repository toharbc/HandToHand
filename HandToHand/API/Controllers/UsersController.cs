using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using DTO;

namespace API.Controllers
{
    public class UsersController : ApiController
    {
        UsersBLL usersBLL = new UsersBLL();

        [HttpGet]
        // GET: api/Users
        public List<UserDTO> GetAllUsers()
        {
            return usersBLL.GetAllUsers();
        }
        // POST: api/Users
        [HttpPost]
        public void AddUser([FromBody]UserDTO user)
        {
             usersBLL.AddUser(user);
        }

       

       
    }
}

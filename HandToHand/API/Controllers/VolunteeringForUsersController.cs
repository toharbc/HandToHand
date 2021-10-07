using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DTO;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]

    public class VolunteeringForUsersController : ApiController
    {
        VolunteeringForUsersBLL volunteeringForUsersBLL = new VolunteeringForUsersBLL();

        [HttpGet]
        // GET: api/C
        public List<VolunteeringForUsersDTO> GetAllVolunteeringForUsers()
        {
            return volunteeringForUsersBLL.GetAllVolunteeringForUsers();
        }

        [HttpPost]
        // POST: api/VolunteeringForUsers
        public void AddVolunteeringForUsers([FromBody] VolunteeringForUsersDTO volunteeringForUsers)
        {
            volunteeringForUsersBLL.AddVolunteeringForUsers(volunteeringForUsers);
        }

       
    }
}

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
        [HttpGet]
        [Route ("findVolunteerForNeedHelp")]
        // GET: api/C
        public List<VolunteeringForUsersDTO> findVolunteerForNeedHelp()
        {
            //שולח לפעולה שמקבלת פרטי צריך עזרה או הידי שלו ומחזירה רשימה של כל המתנדבים
            return volunteeringForUsersBLL.GetAllVolunteeringForUsers();
        }

        [HttpPost]
        // POST: api/VolunteeringForUsers
        public bool AddVolunteeringForUsers([FromBody] VolunteeringForUsersDTO volunteeringForUsers)
        {
           return volunteeringForUsersBLL.AddVolunteeringForUsers(volunteeringForUsers);
        }

       
    }
}

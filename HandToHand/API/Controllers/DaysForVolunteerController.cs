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
    public class DaysForVolunteerController : ApiController
    {
        DaysForVolunteerBLL daysForVolunteerBLL = new DaysForVolunteerBLL();
        [HttpGet]
        // GET: api/DaysForVolunteer
        public List<DaysForVolunteerDTO> GetAllDaysForVolunteers()
        {

            return daysForVolunteerBLL.GetAllDaysForVolunteers();
        }


        [HttpPost]
        // POST: api/DaysForVolunteer
        public void AddDaysForVolunteer([FromBody] DaysForVolunteerDTO daysForVolunteer)
        {

            daysForVolunteerBLL.AddUser(daysForVolunteer);
        }

        
    }
}

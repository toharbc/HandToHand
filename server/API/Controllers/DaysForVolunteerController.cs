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
        public bool AddDaysForVolunteer([FromBody] DaysForVolunteerDTO daysForVolunteer)
        {

            return daysForVolunteerBLL.AddDaysForVolunteer(daysForVolunteer);
        }

        
    }
}

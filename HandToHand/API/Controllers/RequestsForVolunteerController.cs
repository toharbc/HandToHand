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
    public class RequestsForVolunteerController : ApiController
    {
        RequestsForVolunteerBLL requestsForVolunteerBLL = new RequestsForVolunteerBLL();
        [HttpGet]
        // GET: api/RequestsForVolunteer
        public List<RequestsForVolunteerDTO> GetAllRequestsForVolunteers()
        {

            return requestsForVolunteerBLL.GetAllRequestsForVolunteers();
        }


        [HttpPost]
        // POST: api/RequestsForVolunteer
        public void AddRequestsForVolunteer([FromBody] RequestsForVolunteerDTO requestsForVolunteer)
        {
            requestsForVolunteerBLL.AddRequestsForVolunteer(requestsForVolunteer);
        }

    }
}

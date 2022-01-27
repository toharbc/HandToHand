using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL;
using DAL;
using DTO;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class HelpRequestsController : ApiController
    {
        HelpRequestsBLL helpRequestsBLL = new HelpRequestsBLL();
        [HttpGet]
        // GET: api/HelpRequests
        public List<HelpRequestsDTO> GetAllHelpRequests()
        {
            return helpRequestsBLL.GetAllHelpRequests();
        }
        [HttpGet]
        public List<HelpRequestsDTO> GetHelpRequestsByRequesterId(long id)
        {
            return helpRequestsBLL.GetHelpRequestsByRequesterId(id);
        }

        [HttpGet]
        public List<HelpRequestsDTO> GetHelpRequestsByVolenteerId(long id)
        {
            return helpRequestsBLL.GetHelpRequestsByVolenteerId(id);
        }
        [HttpGet]
        public List<VolunteeringForUsersDTO> GetVolunteersForHelpRequest(HelpRequest helpRequest)
        {

            return helpRequestsBLL.GetVolunteersForHelpRequest(helpRequest);
        }
        [HttpPost]
        // POST: api/HelpRequests
        public bool AddHelpRequests([FromBody] HelpRequestsDTO helpRequest)
        {
           return helpRequestsBLL.AddHelpRequest(helpRequest);
        }

       
    }
}

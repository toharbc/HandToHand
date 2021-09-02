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
    public class HelpRequestsController : ApiController
    {
        HelpRequestsBLL helpRequestsBLL = new HelpRequestsBLL();
        [HttpGet]
        // GET: api/HelpRequests
        public List<HelpRequestsDTO> GetAllHelpRequests()
        {
            return helpRequestsBLL.GetAllHelpRequests();
        }

        [HttpPost]
        // POST: api/HelpRequests
        public void AddHelpRequests([FromBody] HelpRequestsDTO helpRequest)
        {
            helpRequestsBLL.AddHelpRequest(helpRequest);
        }

       
    }
}

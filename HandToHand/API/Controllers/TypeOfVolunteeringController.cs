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
    public class TypeOfVolunteeringController : ApiController
    {

        TypeOfVolunteeringBLL typeOfVolunteeringBLL = new TypeOfVolunteeringBLL();
        [HttpGet]
        // GET: api/TypeOfVolunteering

        [AcceptVerbs("GET", "POST")]

        [Route("getAllTypeOfVolunteerings")]
        public List<TypeOfVolunteeringDTO> GetAllTypeOfVolunteerings()
        {
            return typeOfVolunteeringBLL.GetAllTypeOfVolunteerings();
        }


        [HttpPost]
        // POST: api/TypeOfVolunteering
        public bool AddTypeOfVolunteering([FromBody] TypeOfVolunteeringDTO typeOfVolunteering)
        {

           return typeOfVolunteeringBLL.AddTypeOfVolunteering(typeOfVolunteering);
        }





    }
}


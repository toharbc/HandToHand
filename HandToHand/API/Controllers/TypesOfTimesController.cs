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
    public class TypesOfTimesController : ApiController
    {
        TypesOfTimesBLL typesOfTimesBLL = new TypesOfTimesBLL();
        [HttpGet]
        // GET: api/TypesOfTimes
        public List<TypesOfTimesDTO> GetAllTypesOfTimes()
        {
            return typesOfTimesBLL.GetAllTypesOfTimes();
        }

        [HttpPost]
        // POST: api/TypesOfTimes
        public void AddTypesOfTimes([FromBody] TypesOfTimesDTO typesOfTimes)
        {
            typesOfTimesBLL.AddTypesOfTimes(typesOfTimes);
        }

    }
}

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
    public class ManagerController : ApiController
    {
        ManagerBLL managerBLL = new ManagerBLL();
        [HttpGet]
        // GET: api/Manager
        public List<ManagerDTO> GetAllManagers()
        {
            return managerBLL.GetAllManagers();
        }

        [HttpPost]
        // POST: api/Manager
        public void AddManager([FromBody] ManagerDTO manager)
        {
            managerBLL.AddManager(manager);
        }

        
    }
}

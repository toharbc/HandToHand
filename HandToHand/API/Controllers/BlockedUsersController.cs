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
    public class BlockedUsersController : ApiController
    {
        BlockedUsersBLL blockedUsersBLL = new BlockedUsersBLL();
        [HttpGet]
        // GET: api/BlockedUsers
        public List<BlockedUserDTO> GetAllBlockedUsers()
        {
            return blockedUsersBLL.GetAllBlockedUsers();
        }

        [HttpPost]
        // POST: api/BlockedUsers
        public void AddBlockedUsers([FromBody] BlockedUserDTO blockedUser)
        {

            blockedUsersBLL.AddBlockedUsers(blockedUser);
        }

       
    }
}

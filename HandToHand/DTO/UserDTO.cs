using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public long UserPhone { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string UserAdress { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ProfileDTO
    {
        public VolunteeringForUsersDTO volunteeringForUsers { get; set; }
        public List<string> Comments { get; set; }
        public int Stars { get; set; }
    }
}

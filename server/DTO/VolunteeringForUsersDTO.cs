using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VolunteeringForUsersDTO
    {
        public long VolunteeringForUsersId { get; set; }
        public long TypeOfVolunteerId { get; set; }
        public long UserId { get; set; }
        public string TypeOfVolunteerName { get; set; }
        public string UserName { get; set; }
        public string UserLocation { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }


    }
}

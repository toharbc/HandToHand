using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     public class RequestsForVolunteerDTO
    {
        public long RequestForVolunteerId { get; set; }
        public long HelpRequestId { get; set; }
        public long VolunteerId { get; set; }
        public string Status { get; set; }
        public bool Done { get; set; }
        public long Review { get; set; }
        public string Comment { get; set; }
    }
}

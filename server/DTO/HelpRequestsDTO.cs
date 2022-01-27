using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HelpRequestsDTO
    {
        public long HelpRequestId { get; set; }
        public long RequesterId { get; set; }
        public long TypeOfVolunteerId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.TimeSpan StartHour { get; set; }
        public System.TimeSpan EndHour { get; set; }
    }
}

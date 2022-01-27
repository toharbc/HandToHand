using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DaysForVolunteerDTO
    {
        public long DaysForVolunteerId { get; set; }
        public long DayOfWeek { get; set; }
        public System.TimeSpan HourStart { get; set; }
        public System.TimeSpan HourEnd { get; set; }
        public long RangeHours { get; set; }
        public long TypesOfTimesId { get; set; }
        public long VolunteerId { get; set; }

    }
}

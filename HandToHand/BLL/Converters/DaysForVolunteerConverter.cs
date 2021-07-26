using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
   public static class DaysForVolunteerConverter
    {
        public static DaysForVolunteer Map(DaysForVolunteerDTO daysForVolunteer)
        {
            return new DaysForVolunteer
            {
                DaysForVolunteerId = daysForVolunteer.DaysForVolunteerId,
                DayOfWeek = daysForVolunteer.DayOfWeek,
                HourStart = daysForVolunteer.HourStart,
                HourEnd = daysForVolunteer.HourEnd,
                RangeHours = daysForVolunteer.RangeHours,
                TypesOfTimesId = daysForVolunteer.TypesOfTimesId,
                VolunteerId = daysForVolunteer.VolunteerId,

            };
        }

        public static DaysForVolunteerDTO Map(DaysForVolunteer daysForVolunteer)
        {
            return new DaysForVolunteerDTO
            {
                DaysForVolunteerId = daysForVolunteer.DaysForVolunteerId,
                DayOfWeek = daysForVolunteer.DayOfWeek,
                HourStart = daysForVolunteer.HourStart,
                HourEnd = daysForVolunteer.HourEnd,
                RangeHours = daysForVolunteer.RangeHours,
                TypesOfTimesId = daysForVolunteer.TypesOfTimesId,
                VolunteerId = daysForVolunteer.VolunteerId,

            };
        }

        public static List<DaysForVolunteerDTO> Map(List<DaysForVolunteer> daysForVolunteers)
        {
            return daysForVolunteers.Select(u => Map(u)).ToList();
        }
    }
}

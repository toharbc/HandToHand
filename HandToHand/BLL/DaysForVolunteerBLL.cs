using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BLL.Converters;

namespace BLL
{
    public class DaysForVolunteerBLL
    {
        DaysForVolunteerDAL daysForVolunteerDAL = new DaysForVolunteerDAL();
        public List<DaysForVolunteerDTO> GetAllDaysForVolunteers()
        {
            return DaysForVolunteerConverter.Map(daysForVolunteerDAL.GetAllDaysForVolunteers());
        }

        public void AddDaysForVolunteer(DaysForVolunteerDTO daysForVolunteer)
        {

            daysForVolunteerDAL.AddDaysForVolunteer(DaysForVolunteerConverter.Map(daysForVolunteer));
        }
    }
}

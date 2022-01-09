using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DaysForVolunteerDAL
    {
        public List<DaysForVolunteer> GetAllDaysForVolunteers()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.DaysForVolunteers.ToList();
            }
        }

        public  bool AddDaysForVolunteer(DaysForVolunteer daysForVolunteer)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.DaysForVolunteers.Add(daysForVolunteer);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}

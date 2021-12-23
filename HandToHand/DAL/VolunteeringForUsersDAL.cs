using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
   public class VolunteeringForUsersDAL
    {
        public List<VolunteeringForUser> GetAllVolunteeringForUsers()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.VolunteeringForUsers
                    .Include(v=>v.User)
                    .Include(v => v.User.DaysForVolunteers)
                    .Include(v=>v.TypeOfVolunteering)
                    .Include(v=>v.User.RequestsForVolunteers)
                    .Include(v => v.User.Area)

                    .ToList();
            }

        }
        public List<Area> GetAllAreas()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.Areas
                    .Include(v => v.AreaName)
                  
                    .Include(v => v.AreaId)

                    .ToList();
            }
        }
    }
}

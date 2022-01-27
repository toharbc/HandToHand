using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RequestsForVolunteerDAL
    {
        public  List<RequestsForVolunteer> GetAllRequestsForVolunteers()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.RequestsForVolunteers.ToList();
            }
        }

        public static bool AddRequestsForVolunteer(RequestsForVolunteer requestsForVolunteer)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.RequestsForVolunteers.Add(requestsForVolunteer);
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

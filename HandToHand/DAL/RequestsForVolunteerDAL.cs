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

        public static void AddRequestsForVolunteer(RequestsForVolunteer requestsForVolunteer)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                db.RequestsForVolunteers.Add(requestsForVolunteer);
                db.SaveChanges();
            }
             
        }
    }
}

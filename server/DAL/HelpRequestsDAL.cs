using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class HelpRequestsDAL
    {
        public  List<HelpRequest> GetAllHelpRequests()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.HelpRequests.ToList();
            }

        }

        public List<HelpRequest> GetHelpRequestsByRequesterId(long id)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.HelpRequests.Where(h=>h.RequesterId==id).ToList();
            }

        }

        public List<HelpRequest> GetHelpRequestsByVolenteerId(long id)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
               return db.RequestsForVolunteers.Where(r => r != null && r.VolunteerId == id).
                    Select(r=>r.HelpRequest).ToList();
            }

        }

        public bool AddHelpRequest(HelpRequest helpRequest)
        {

            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.HelpRequests.Add(helpRequest);
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

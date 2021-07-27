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
        public void AddHelpRequest(HelpRequest helpRequest)
        {

            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                db.HelpRequests.Add(helpRequest);
                db.SaveChanges();
            }
        }
    }
}

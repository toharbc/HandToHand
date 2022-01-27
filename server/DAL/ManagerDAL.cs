using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class ManagerDAL
    {
        public List<Manager> GetAllManagers()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.Managers.ToList();
            }

        }


        public bool AddManager(Manager manager)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.Managers.Add(manager);
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

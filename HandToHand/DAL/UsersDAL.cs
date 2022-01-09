using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UsersDAL
    {
        public List<User> GetAllUsers()
        {
            using(HandToHanddEntities db=new HandToHanddEntities())
            {
                return db.Users.ToList();
            }
        }

        public bool AddUser(User user)   
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                user.AreaId = null;
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
                catch
                {

                    return false;
                }
            }
        }

        public void AddHelpRequests(HelpRequest helpRequest)
        {
            throw new NotImplementedException();
        }
    }
}

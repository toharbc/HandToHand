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

        public void AddUser(User user)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

    }
}

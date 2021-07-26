using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlockedUsersDAL
    {
        public  List<BlockedUser> GetAllBlockedUsers()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.BlockedUsers.ToList();
            }
        }
        public  void AddBlockedUsers(BlockedUser blockedUser)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                db.BlockedUsers.Add(blockedUser);
                db.SaveChanges();
            }

        }
    }
}

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
        public  bool AddBlockedUsers(BlockedUser blockedUser)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.BlockedUsers.Add(blockedUser);
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

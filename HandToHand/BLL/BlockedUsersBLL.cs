using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BLL.Converters;

namespace BLL
{
    public class BlockedUsersBLL
    {
        BlockedUsersDAL blockedUsersDAL = new BlockedUsersDAL();
        public List<BlockedUserDTO> GetAllBlockedUsers()
        {
            return BlockedUsersConverter.Map(blockedUsersDAL.GetAllBlockedUsers());
        }

      
        public  bool AddBlockedUsers(BlockedUserDTO blockedUser)
        {
            return blockedUsersDAL.AddBlockedUsers(BlockedUsersConverter.Map(blockedUser));
        }
    }
}

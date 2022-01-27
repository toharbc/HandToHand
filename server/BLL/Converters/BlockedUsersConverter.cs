using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters   
{
     public static class BlockedUsersConverter
    {
        public static BlockedUser Map(BlockedUserDTO blockedUser)
        {
            return new BlockedUser
            {
                //אנחנו מנסות לראות אם זה עובד
                UserId = blockedUser.UserId
            };

        }
        public static BlockedUserDTO Map(BlockedUser blockedUser)
        {
            return new BlockedUserDTO
            {

                UserId = blockedUser.UserId
            };

        }


        public static List<BlockedUserDTO> Map(List<BlockedUser> blockedUsers)
        {
            return blockedUsers.Select(u => Map(u)).ToList();
        }

    }
}

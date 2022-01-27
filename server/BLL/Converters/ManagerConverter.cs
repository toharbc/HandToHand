using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
    public static class ManagerConverter
    {
        public static Manager Map(ManagerDTO manager)
        {
            return new Manager
            {
                ManagerId = manager.ManagerId,
                Username = manager.Username,
                Password = manager.Password,
              

            };
        }

        public static ManagerDTO Map(Manager manager)
        {
            return new ManagerDTO
            {
                ManagerId = manager.ManagerId,
                Username = manager.Username,
                Password = manager.Password,

            };
        }

        public static List<ManagerDTO> Map(List<Manager> manager)
        {
            return manager.Select(u => Map(u)).ToList();
        }
    }
}

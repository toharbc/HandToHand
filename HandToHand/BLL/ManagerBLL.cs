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
    public class ManagerBLL
    {
        ManagerDAL managerDAL = new ManagerDAL();
        public List<ManagerDTO> GetAllManagers()
        {
            return ManagerConverter.Map(managerDAL.GetAllManagers());
        }

            public void AddManager(ManagerDTO manager)
        {
            managerDAL.AddManager(ManagerConverter.Map(manager));
        }
    }
}

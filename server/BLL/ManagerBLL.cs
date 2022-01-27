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

            public bool AddManager(ManagerDTO manager)
        {
             return managerDAL.AddManager(ManagerConverter.Map(manager));
        }
    }
}

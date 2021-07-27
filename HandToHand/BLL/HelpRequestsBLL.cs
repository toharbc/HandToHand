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
    public class HelpRequestsBLL
    {
        HelpRequestsDAL helpRequestsDAL = new HelpRequestsDAL();
        public  List<HelpRequestsDTO> GetAllHelpRequests()
        {

            return HelpRequestsConverter.Map(helpRequestsDAL.GetAllHelpRequests());
        }

        public void AddHelpRequest(HelpRequestsDTO helpRequest)
        {
            helpRequestsDAL.AddHelpRequest(HelpRequestsConverter.Map(helpRequest));
        }
    }
}

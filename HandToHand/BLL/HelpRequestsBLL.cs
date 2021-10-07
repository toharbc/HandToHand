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

        public List<HelpRequestsDTO> GetHelpRequestsByRequesterId(long id)
        {
            return HelpRequestsConverter.Map(helpRequestsDAL.GetHelpRequestsByRequesterId(id));
        }

        public List<HelpRequestsDTO> GetHelpRequestsByVolenteerId(long id)
        {
            return HelpRequestsConverter.Map(helpRequestsDAL.GetHelpRequestsByVolenteerId(id));
        }
    }
}

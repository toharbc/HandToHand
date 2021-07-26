using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
    public static class HelpRequestsConverter
    {
        public static HelpRequest Map(HelpRequestsDTO helpRequest)
        {
            return new HelpRequest
            {
                HelpRequestId = helpRequest.HelpRequestId,
                RequesterId = helpRequest.RequesterId,
                TypeOfVolunteerId = helpRequest.TypeOfVolunteerId,
                StartDate = helpRequest.StartDate,
                EndDate = helpRequest.EndDate,
                StartHour = helpRequest.StartHour,
                EndHour = helpRequest.EndHour,

            };
        }

        public static HelpRequestsDTO Map(HelpRequest helpRequest)
        {
            return new HelpRequestsDTO
            {
                HelpRequestId = helpRequest.HelpRequestId,
                RequesterId = helpRequest.RequesterId,
                TypeOfVolunteerId = helpRequest.TypeOfVolunteerId,
                StartDate = helpRequest.StartDate,
                EndDate = helpRequest.EndDate,
                StartHour = helpRequest.StartHour,
                EndHour = helpRequest.EndHour,

            };
        }

        public static List<HelpRequestsDTO> Map(List<HelpRequest> helpRequests)
        {
            return helpRequests.Select(u => Map(u)).ToList();
        }
    }
}

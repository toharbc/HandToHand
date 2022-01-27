using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{

    public static class RequestsForVolunteerConverter
    {
        public static RequestsForVolunteer Map(RequestsForVolunteerDTO requestsForVolunteer)
        {
            return new RequestsForVolunteer
            {
                RequestForVolunteerId = requestsForVolunteer.RequestForVolunteerId,
                HelpRequestId = requestsForVolunteer.HelpRequestId,
                VolunteerId = requestsForVolunteer.VolunteerId,
                Status = requestsForVolunteer.Status,
                Done = requestsForVolunteer.Done,
                Review = requestsForVolunteer.Review,
                Comment = requestsForVolunteer.Comment,

            };
        }

        public static RequestsForVolunteerDTO Map(RequestsForVolunteer requestsForVolunteer)
        {
            return new RequestsForVolunteerDTO
            {
                RequestForVolunteerId = requestsForVolunteer.RequestForVolunteerId,
                HelpRequestId = requestsForVolunteer.HelpRequestId,
                VolunteerId = requestsForVolunteer.VolunteerId,
                Status = requestsForVolunteer.Status,
                Done = requestsForVolunteer.Done,
                Review = requestsForVolunteer.Review,
                Comment = requestsForVolunteer.Comment,

            };
        }

        public static List<RequestsForVolunteerDTO> Map(List<RequestsForVolunteer> requestsForVolunteers)
        {
            return requestsForVolunteers.Select(u => Map(u)).ToList();
        }
    }
}

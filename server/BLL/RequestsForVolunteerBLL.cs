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
    public class RequestsForVolunteerBLL
    {
        RequestsForVolunteerDAL requestsForVolunteerDAL = new RequestsForVolunteerDAL();
        public List<RequestsForVolunteerDTO> GetAllRequestsForVolunteers()
        {
            return   RequestsForVolunteerConverter.Map(requestsForVolunteerDAL.GetAllRequestsForVolunteers());
        }

        public bool AddRequestsForVolunteer(RequestsForVolunteerDTO requestsForVolunteer)
        {
           return RequestsForVolunteerDAL.AddRequestsForVolunteer(RequestsForVolunteerConverter.Map(requestsForVolunteer));
        }
    }
}

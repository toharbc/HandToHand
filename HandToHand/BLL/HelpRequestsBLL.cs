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

        //public List<VolunteeringForUsersDTO> GetVolunteersForHelpRequest(HelpRequest helpRequest)
        //{
        //    List<VolunteeringForUsersDTO> matchingVolunteers = new List<VolunteeringForUsersDTO>();
        //    List<VolunteeringForUser> allVoluneerings = new VolunteeringForUsersDAL().GetAllVolunteeringForUsers();
        //    foreach (var v in allVoluneerings)
        //    {
        //        if (v.TypeOfVolunteerId != helpRequest.TypeOfVolunteerId)
        //            continue;
        //        if (helpRequest.User.AreaId != v.User.AreaId)
        //            continue;
        //        if (!TimeMatch(v.User.DaysForVolunteers.ToList(), helpRequest))
        //            continue;
              

        //        matchingVolunteers.Add(VolunteeringForUsersConverter.Map(v));

        //    }

        //   // return matchingVolunteers.OrderBy(m=> DistanseMatch( m.UserLocation,helpRequest.User.UserAdress)).ToList();
        
        //}

        //private int DistanseMatch(string src, string dest)
        //{
        //    return 1;
            //    //Here goes a function that calculates the driving time between 2 points
            //    //Ask friends
            //    // אפרת
            //    int minutes = new BLL.DistanceService().GetDistance(src, dest);
            //    return minutes;

            //    //מקמיל
            //    public int RouteDistanceInSecondOnModeDrive(LocationPoint current, LocationPoint destination)
            //    {
            //        string ApiKey = ConfigurationManager.AppSettings["APIKEY"];
            //        string uri = $"https://maps.googleapis.com/maps/api/distancematrix/xml?key={ApiKey}&origins={current.ToString()}&destinations={destination.ToString()}&mode=driving";
            //        var client = new RestClient(uri);
            //        client.Timeout = -1;
            //        var request = new RestRequest(Method.GET);
            //        IRestResponse response = client.Execute(request);
            //        XDocument xmlResult = XDocument.Parse(response.Content);
            //        int timeInSecond = ConvertXmlToSecond(xmlResult);
            //        return timeInSecond;
            //    }
            //}

            public bool TimeMatch(List<DaysForVolunteer> daysForVolunteers,HelpRequest request)
        {
            for (DateTime d = request.StartDate; d <= request.EndDate; d=d.AddDays(1))
            {
                DaysForVolunteer day = daysForVolunteers.FirstOrDefault(x => x.DayofWeek == (int)d.DayOfWeek);
                if (request.StartHour <= day.HourEnd && request.EndHour >= day.HourStart)
                {
                    return true;
                }
            }

            return false;
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

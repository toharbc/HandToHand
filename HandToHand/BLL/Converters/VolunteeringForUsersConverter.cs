using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
    public static class VolunteeringForUsersConverter
    {

        public static VolunteeringForUser Map(VolunteeringForUsersDTO volunteeringForUser)
        {
            return new VolunteeringForUser
            {
                VolunteeringForUsersId = volunteeringForUser.VolunteeringForUsersId,
                TypeOfVolunteerId = volunteeringForUser.TypeOfVolunteerId,
                UserId = volunteeringForUser.UserId,
                

            };
        }

        public static VolunteeringForUsersDTO Map(VolunteeringForUser volunteeringForUser)
        {
            return new VolunteeringForUsersDTO
            {
                VolunteeringForUsersId = volunteeringForUser.VolunteeringForUsersId,
                TypeOfVolunteerId = volunteeringForUser.TypeOfVolunteerId,
                UserId = volunteeringForUser.UserId,
                TypeOfVolunteerName= volunteeringForUser.TypeOfVolunteering.TypeOfVolunteeringName,
                UserLocation= volunteeringForUser.User.UserAdress,
                AreaId=volunteeringForUser.User.AreaId.Value,
                AreaName=volunteeringForUser.User.Area.AreaName,
                UserName= volunteeringForUser.User.UserFirstName+" "+ volunteeringForUser.User.UserLastName

            };
        }

        public static List<VolunteeringForUsersDTO> Map(List<VolunteeringForUser> volunteeringForUsers)
        {
            return volunteeringForUsers.Select(u => Map(u)).ToList();
        }
    }
}

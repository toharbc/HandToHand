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
            if (volunteeringForUser != null)
            {
                VolunteeringForUsersDTO newVolunteer = new VolunteeringForUsersDTO();
                newVolunteer.VolunteeringForUsersId = volunteeringForUser.VolunteeringForUsersId;
                newVolunteer.TypeOfVolunteerId = volunteeringForUser.TypeOfVolunteerId;
                newVolunteer.UserId = volunteeringForUser.UserId;
                if (volunteeringForUser.TypeOfVolunteering != null)
                {
                    newVolunteer.TypeOfVolunteerName = volunteeringForUser.TypeOfVolunteering.TypeOfVolunteeringName;
                }
                if (volunteeringForUser.User != null)
                {
                    newVolunteer.UserLocation = volunteeringForUser.User.UserAdress;
                    if (volunteeringForUser.User.AreaId != null)
                    {
                        newVolunteer.AreaId = volunteeringForUser.User.AreaId.Value;
                    }
                    if (volunteeringForUser.User.Area != null)
                    {
                        newVolunteer.AreaName = volunteeringForUser.User.Area.AreaName;
                    }
                    newVolunteer.UserName = volunteeringForUser.User.UserFirstName + " " + volunteeringForUser.User.UserLastName;
                }
                return newVolunteer;
            }
            return null;
        }

        public static List<VolunteeringForUsersDTO> Map(List<VolunteeringForUser> volunteeringForUsers)
        {
            return volunteeringForUsers.Select(u => Map(u)).ToList();
        }
    }
}

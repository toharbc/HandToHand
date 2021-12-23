using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class VolunteeringForUsersBLL
    {
        VolunteeringForUsersDAL volunteeringForUsersDAL = new VolunteeringForUsersDAL();

        public List<VolunteeringForUsersDTO> GetAllVolunteeringForUsers()
        {
           return Converters.VolunteeringForUsersConverter.Map(volunteeringForUsersDAL.GetAllVolunteeringForUsers());
        }
        //public List<Area> GetAllAreas()
        //{
        //    return Converters.VolunteeringForUsersConverter.Map(volunteeringForUsersDAL.GetAllAreas());
        //}


        public void AddVolunteeringForUsers(VolunteeringForUsersDTO volunteeringForUsers)
        {
            throw new NotImplementedException();
        }
    }
}

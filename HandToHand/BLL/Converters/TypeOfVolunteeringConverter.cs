using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
    public static class TypeOfVolunteeringConverter
    {

        public static TypeOfVolunteering Map(TypeOfVolunteeringDTO typeOfVolunteering)
        {
            return new TypeOfVolunteering
            {
                TypeOfVolunteeringId = typeOfVolunteering.TypeOfVolunteeringId,
                TypeOfVolunteeringName = typeOfVolunteering.TypeOfVolunteeringName,
               

            };
        }

        public static TypeOfVolunteeringDTO Map(TypeOfVolunteering typeOfVolunteering)
        {
            return new TypeOfVolunteeringDTO
            {
                TypeOfVolunteeringId = typeOfVolunteering.TypeOfVolunteeringId,
                TypeOfVolunteeringName = typeOfVolunteering.TypeOfVolunteeringName,

            };
        }

        public static List<TypeOfVolunteeringDTO> Map(List<TypeOfVolunteering> typeOfVolunteering)
        {
            return typeOfVolunteering.Select(u => Map(u)).ToList();
        }
    }
}

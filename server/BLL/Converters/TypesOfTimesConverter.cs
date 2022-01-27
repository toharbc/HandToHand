using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL.Converters
{
    public static class TypesOfTimesConverter
    {

        public static TypesOfTime Map(TypesOfTimesDTO typesOfTime)
        {
            return new TypesOfTime
            {
                TypesOfTimesId = typesOfTime.TypesOfTimesId,
                TypesOfTimesName = typesOfTime.TypesOfTimesName,
       

            };
        }

        public static TypesOfTimesDTO Map(TypesOfTime typesOfTime)
        {
            return new TypesOfTimesDTO
            {
                TypesOfTimesId = typesOfTime.TypesOfTimesId,
                TypesOfTimesName = typesOfTime.TypesOfTimesName,

            };
        }

        public static List<TypesOfTimesDTO> Map(List<TypesOfTime> typesOfTimes)
        {
            return typesOfTimes.Select(u => Map(u)).ToList();
        }
    }
}

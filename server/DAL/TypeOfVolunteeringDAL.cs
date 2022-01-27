using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
     public class TypeOfVolunteeringDAL
    {

        public List<TypeOfVolunteering> GetAllTypeOfVolunteering()
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.TypeOfVolunteerings.ToList();
            }
        }

        public static bool AddTypeOfVolunteering(TypeOfVolunteering typeOfVolunteering)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                try
                {
                    db.TypeOfVolunteerings.Add(typeOfVolunteering);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        public TypeOfVolunteering GetTypeOfVolunteeringById(int typeId)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                TypeOfVolunteering type = db.TypeOfVolunteerings.FirstOrDefault(t => t != null &&
                t.TypeOfVolunteeringId == typeId);
                return type;
            }
        }
    }
}

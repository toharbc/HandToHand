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

        public static void AddTypeOfVolunteering(TypeOfVolunteering typeOfVolunteering)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                db.TypeOfVolunteerings.Add(typeOfVolunteering);
                db.SaveChanges();
            }

        }
    }
}

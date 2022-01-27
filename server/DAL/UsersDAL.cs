using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public enum ETypeUser { Volunteer = 1, HelpRequest, Other }; 
    public class UsersDAL
    {
        public List<User> GetAllUsers()
        {
            using(HandToHanddEntities db=new HandToHanddEntities())
            {
                return db.Users.ToList();
            }
        }

        public bool AddUser(User user)   
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                user.AreaId = null;
                try
                {
                    if (CheckIsValid(user))
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch
                {

                    return false;
                }
            }
        }
        //פונקצייה בודקת אם קיים משתמש עם אותה סיסמא
        public bool CheckIsValid(User currentUser)
        {
            using(HandToHanddEntities db = new HandToHanddEntities())
            {
                User user = db.Users.Where(u => u != null && u.UserPassword == currentUser.UserPassword).FirstOrDefault();
                if (user != null)
                    return false;
                return true;
            }
        }
        public ETypeUser CheckType(int userId)
        {
            using(HandToHanddEntities db = new HandToHanddEntities())
            {
                VolunteeringForUser volunteer = db.VolunteeringForUsers.FirstOrDefault(
                    v => v != null && v.UserId == userId);
                if (volunteer != null)
                    return ETypeUser.Volunteer;
                HelpRequest helpRequest = db.HelpRequests.FirstOrDefault(
                    h => h != null && h.User != null && h.User.UserId == userId);
                if (helpRequest != null)
                    return ETypeUser.HelpRequest;
                return ETypeUser.Other;
            }
        }
        public User GetUser(int userId)
        {
            using (HandToHanddEntities db = new HandToHanddEntities())
            {
                return db.Users.FirstOrDefault(
                    u => u != null && u.UserId == userId);
            }
        }

        public void AddHelpRequests(HelpRequest helpRequest)
        {
            throw new NotImplementedException();
        }
    }
}

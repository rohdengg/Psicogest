using Psicogest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Data
{
    public static class UserData
    {
        public static void AddUserToDb(User user)
        {
            using (var db = new PsicogestContext())
            {
                db.Add(user);
                db.SaveChanges();
            }
        }

        public static User GetUserByName(string userName)
        {
            using (var db = new PsicogestContext())
            {
                return db.Users.Where(x => x.UserName == userName).FirstOrDefault();
            }
        }
    }
}

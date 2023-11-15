using Psicogest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Data
{
    public static class PatientDevelopmentData
    {
        public static void AddDevelopmentToDb(PatientDevelopment development)
        {
            using (var db = new PsicogestContext())
            {
                db.Add(development);
                db.SaveChanges();
            }
        }
    }
}

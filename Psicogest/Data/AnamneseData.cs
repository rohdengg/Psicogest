using Psicogest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Psicogest.Data
{
    public static class AnamneseData
    {
        public static void AddAnamneseToDb(Anamnese anamnese)
        {
            using (var db = new PsicogestContext())
            {
                db.Add(anamnese);
                db.SaveChanges();
            }
        }

        public static Anamnese GetAnamneseByPatientId(int id)
        {
            using ( var db = new PsicogestContext())
            {
                return db.Anamneses.Where(x => x.PatientId == id).FirstOrDefault();
            }
        }
    }
}

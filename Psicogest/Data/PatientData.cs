using Psicogest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Data
{
    public static class PatientData
    {
        public static void AddPatientToDb(Patient patient)
        {
            using(var db = new PsicogestContext())
            {
                db.Add(patient);
                db.SaveChanges();
            }
        }

        public static List<Patient> GetAllPatients(int userId)
        {
            using (var db = new PsicogestContext())
            {
                return db.Patients.Where(p => p.UserId == userId).OrderBy(p => p.Name).ToList();
            }
        }

        public static void UpdatePatient(Patient updatedPatient)
        {
            using (var db = new PsicogestContext())
            {
                var patient = db.Patients.Find(updatedPatient.Id);
                patient.Name = updatedPatient.Name;
                patient.Email = updatedPatient.Email;
                patient.Phone = updatedPatient.Phone;

                db.SaveChanges();
            }
        }

        public static void DeletePatient(int id)
        {
            using (var db = new PsicogestContext())
            {
                var patient = db.Patients.Find(id);
                db.Patients.Remove(patient);

                db.SaveChanges();
            }
        }
    }
}


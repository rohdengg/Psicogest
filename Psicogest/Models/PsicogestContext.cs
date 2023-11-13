using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Models
{
    internal class PsicogestContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Anamnese> Anamneses { get; set; }
        public DbSet<PatientDevelopment> PatientDevelopments { get; set; }

        public string path = @"C:\Users\gabri\OneDrive\Documentos\psicogestDB\psicogest.db";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data source={path}"); 
    }
}

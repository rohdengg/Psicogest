using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Models
{
    public class Anamnese
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Gender { get; set; }
        public long? EmergencyContact {  get; set; }
        public string? MainComplaint { get; set; }
        public string? Symptoms { get; set; }
        public string? Job { get; set; }
        public string? Medicines { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Schooling { get; set; }

    }
}

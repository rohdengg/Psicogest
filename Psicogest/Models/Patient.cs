using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicogest.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

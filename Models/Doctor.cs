using System;
using System.Collections.Generic;

namespace MedicalScan.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Specialities = new HashSet<Speciality>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Speciality> Specialities { get; set; }
    }
}

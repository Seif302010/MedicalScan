using System;
using System.Collections.Generic;

namespace MedicalScan.Models
{
    public partial class Speciality
    {
        public Speciality()
        {
            Doctors = new HashSet<Doctor>();
        }

        public int Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}

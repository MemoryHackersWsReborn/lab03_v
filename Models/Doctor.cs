using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab03_v.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int HospitalId { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
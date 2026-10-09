using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class PrescribedMedicine
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string Dose { get; set; }
        public int HowManyDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid? MedicineId { get; set; }
        public Guid? DoctorId { get; set; }

        public Doctor Doctor { get; set; }
        public Medicine Medicine { get; set; }

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}

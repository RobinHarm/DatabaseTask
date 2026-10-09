using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int WorkerNr { get; set; }
        public float Telephone { get; set; }
        [MaxLength(50)]
        public string Speciality { get; set; }
        public Guid? DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
        public ICollection<Study> Studies { get; set; } = new List<Study>();
        public ICollection<PrescribedMedicine> PrescribedMedicines { get; set; } = new List<PrescribedMedicine>();


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Study
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public float Price { get; set; }
        public DateTime StudyDate { get; set; }
        [MaxLength(200)]
        public string Result { get; set; }
        public Guid? DoctorId { get; set; }

        public Doctor Doctor { get; set; }

        public ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime VisitDate { get; set; }
        public float Time { get; set; }
        [MaxLength(150)]
        public string Reason { get; set; }
        [MaxLength(200)]
        public string Summary { get; set; }
        public Guid? DoctorId { get; set; }
        public Guid? PatientId { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}

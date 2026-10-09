using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class HospitalCure
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivingDate { get; set; }
        public DateTime LeavingDate { get; set; }
        [MaxLength(200)]
        public string Reason { get; set; }

        public ICollection<Patient> patients { get; set; } = new List<Patient>();
    }
}

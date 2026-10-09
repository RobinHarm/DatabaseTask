using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }
        public float Floor { get; set; }
        public int AmountOfBed { get; set; }
        public Guid? PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}

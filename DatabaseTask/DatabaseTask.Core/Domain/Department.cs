using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(60)]
        public string DepartmentName { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int Floor { get; set; }
        public float Telephone { get; set; }
        public Guid? HospitalId { get; set; }

        public Hospital Hospital { get; set; }

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}

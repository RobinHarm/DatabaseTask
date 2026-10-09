using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int PersonalId { get; set; }
        public DateTime DOB { get; set; }
        public float Telephone { get; set; }
        [MaxLength(90)]
        public string Email { get; set; }
        public Guid? StudyId { get; set; }
        public Guid? HospitalCureId { get; set; }
        public Guid? PrescribedMedicineId { get; set; }

        public Study Study { get; set; }
        public Ward Ward { get; set; }
        public HospitalCure HospitalCure { get; set; }
        public PrescribedMedicine PrescribedMedicine { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}

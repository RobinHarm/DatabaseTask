using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Hospital
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(70)]
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Status { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }
        public int Phone { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}

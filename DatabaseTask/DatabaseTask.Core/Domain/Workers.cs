using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Workers
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(50)]
        public string Email { get; set; } = null!;
        public int? PhoneNumber { get; set; }
        public int? Age { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        [MaxLength(60)]
        public string Address { get; set; } = null!;
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;

        public int Office_Id { get; set; }
        [ForeignKey(nameof(Office_Id))]
        public Office Office { get; set; } = null!;

        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
        public ICollection<HealthInspection> HealthInspections { get; set; } = new List<HealthInspection>();
        public ICollection<Favours> Favours { get; set; } = new List<Favours>();
        public ICollection<Borrowed> Borroweds { get; set; } = new List<Borrowed>();
        public ICollection<JobName> JobNames { get; set; } = new List<JobName>();
        public ICollection<SickPage> SickPages { get; set; } = new List<SickPage>();
        public ICollection<WorkerChildren> WorkerChildren { get; set; } = new List<WorkerChildren>();
        public ICollection<Hints> Hints { get; set; } = new List<Hints>();
        
    }
}

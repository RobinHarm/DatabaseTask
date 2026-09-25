using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HealthInspection
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Address { get; set; } = string.Empty;
        [MaxLength(95)]
        public string HealthStatus { get; set; } = string.Empty;
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

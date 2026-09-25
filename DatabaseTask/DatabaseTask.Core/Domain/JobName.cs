using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class JobName
    {
        public int Id { get; set; }
        [MaxLength(75)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Specialization { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

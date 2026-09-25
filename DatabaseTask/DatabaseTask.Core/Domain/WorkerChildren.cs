using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class WorkerChildren
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public int? PersonalNumber { get; set; }
        public int? Age { get; set; }

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

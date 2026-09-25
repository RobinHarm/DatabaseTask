using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Hints
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(200)]
        public string Reason { get; set; } = string.Empty;

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

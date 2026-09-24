using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class CHAMBER
    {
        [Key]
        public int id { get; set; }
        public int number { get; set; }
        public int floor { get; set; }
        public int maximum_capacity { get; set; }

        public ICollection<PRISONERS> Prisoners { get; set; } = new List<PRISONERS>();
        public ICollection<CHAMBER> Chambers { get; set; } = new List<CHAMBER>();
    }
}

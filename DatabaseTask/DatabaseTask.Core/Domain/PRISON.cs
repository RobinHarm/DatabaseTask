using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PRISON
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Location { get; set; }
        public int Maximum_capacity { get; set; }

        public ICollection<GUARDS> Guards { get; set; } = new List<GUARDS>();
        public ICollection<BLOCK> Blocks { get; set; } = new List<BLOCK>();
        public ICollection<BUILDING> Building { get; set; } = new List<BUILDING>();
    }
}

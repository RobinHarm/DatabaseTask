using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class VISIT
    {
        [Key]
        public int id { get; set; }
        public DateOnly DATE { get; set; }
        public int start_time { get; set; }
        public int finish_time { get; set; }
        [MaxLength(60)]
        public string visiting_status { get; set; }

        public ICollection<PRISONERS> Prisoners { get; set; } = new List<PRISONERS>();
        public ICollection<VISITORS> Visitors { get; set; } = new List<VISITORS>();
    }
}

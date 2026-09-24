using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class SHIFT
    {
        [Key]
        public int Id { get; set; }
        public int start_time { get; set; }
        public int finish_time { get; set; }
        public DateTime date { get; set; }

        public ICollection<GUARDS> Guards { get; set; } = new List<GUARDS>();

    }
}

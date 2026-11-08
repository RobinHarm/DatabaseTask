using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Registreerimine
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RegistreerimiseKuupäev { get; set; }
        public bool RegistreerimiseStaatus { get; set; }
        [MaxLength(50)]
        public string RegistreerimiseViis { get; set; }
        [MaxLength(50)]
        public string RegistreerimiseTöötaja { get; set; }

        public Guid? MakseId { get; set; }

        public Koolitus Koolitus { get; set; }
        public Õppija Õppija { get; set; }

        public ICollection<Makse> Maksed { get; set; } = new List<Makse>();
    }
}

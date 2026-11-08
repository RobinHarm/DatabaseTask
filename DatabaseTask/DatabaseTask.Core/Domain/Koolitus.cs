using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Koolitus
    {
        [Key]
        public Guid id { get; set; }
        [MaxLength(50)]
        public string KoolituseNimi { get; set; }
        [MaxLength(150)]
        public string KoolituseKirjeldus { get; set; }
        public DateTime AlgusKuupäev { get; set; }
        public DateTime LõppKuupäev { get; set; }
        public int MahtTundides { get; set; }
        public float Hind { get; set; }
        public bool KoolituseStaatus { get; set; }
       
        public Guid? KoolitajaId { get; set; }
        public Guid? ÕppijaId { get; set; }
        public Guid? RegistreerimineId { get; set; }

        public Koolitaja Koolitaja { get; set; }
        public Ruum Ruum { get; set; }
        public Registreerimine Registreerimine { get; set; }

        public ICollection<Õppija> Õppijad { get; set; } = new List<Õppija>();
    }
}

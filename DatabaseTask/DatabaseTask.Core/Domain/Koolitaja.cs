using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Koolitaja
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(15)]
        public string KoolitajaEesnimi { get; set; }
        [MaxLength(30)]
        public string KoolitajaPerekonnanimi { get; set; }
        [MaxLength(75)]
        public string KoolitajaEPost { get; set; }
        public int KoolitajaTelefon { get; set; }
        [MaxLength(75)]
        public string Spetsialiseerumine { get; set; }
        public DateTime TööleAsumiseKuupäev { get; set; }
        public int TasuTunniEest { get; set; }

        public Koolitus Koolitus { get; set; }
    }
}

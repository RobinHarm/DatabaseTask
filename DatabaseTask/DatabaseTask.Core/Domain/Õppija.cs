using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Õppija
    {
        [Key]
        public Guid Id { get; set; }
        public int Märkused { get; set; }
        [MaxLength(30)]
        public string Eesnimi { get; set; }
        [MaxLength(30)]
        public string Perekonnanimi { get; set; }
        public int Isikukood { get; set; }
        public DateTime Sünnikuupäev { get; set; }
        [MaxLength(75)]
        public string EPost { get; set; }
        public int Telefon { get; set; }
        [MaxLength(50)]
        public string Tänav { get; set; }
        [MaxLength(30)]
        public string Linn { get; set; }
        public int Postiindeks { get; set; }
        [MaxLength(50)]
        public string Valdkond { get; set; }
        public int Tase { get; set; }
        public int Hinne { get; set; }
        public int LäbitudTunnid { get; set; }
        public int PuudumisteArv { get; set; }
        public bool TunnistusVäljastatud { get; set; }
        public int TagasisideHinne { get; set; }
        [MaxLength(200)]
        public string TagasisideKommentaar { get; set; }
        public DateTime LõpetamiseKuupäev { get; set; }

        public Guid? RegistreerimineId { get; set; }

        public Registreerimine Registreerimine { get; set; }

        public ICollection<Koolitus> Koolitused { get; set; } = new List<Koolitus>();
    }
}

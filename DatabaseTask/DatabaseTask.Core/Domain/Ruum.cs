using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ruum
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string RuumiNimi { get; set; }
        [MaxLength(75)]
        public string Hoone { get; set; }
        public int Korrus { get; set; }
        public int KohtadeArv { get; set; }
        [MaxLength(100)]
        public string RuumiTüüp { get; set; }

        public Guid? KoolitusId { get; set; }

        public ICollection<Koolitus> Koolitused { get; set; } = new List<Koolitus>();
    }
}

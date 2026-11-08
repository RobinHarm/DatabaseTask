using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Makse
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime MakseKuupäev { get; set; }
        public int MakseSumma { get; set; }
        [MaxLength(35)]
        public string MakseViis { get; set; }
        public bool MakseStaatus { get; set; }
        public int ArveNumber { get; set; }
        public DateTime MakseTähtaeg { get; set; }
        public int Viivis { get; set; }

        public Registreerimine Registreerimine { get; set; }
    }
}

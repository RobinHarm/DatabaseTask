using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class BLOCK
    {
        [Key]
        public int id { get; set; }
        public int number { get; set; }
        [MaxLength(60)]
        public string name { get; set; }
        public int security_level { get; set; }
        public int PRISON_Id { get; set; }
        [ForeignKey(nameof(PRISON_Id))]
        public PRISON PRISON { get; set; } = null!;

        public ICollection<CHAMBER> Chambers { get; set; } = new List<CHAMBER>();
    }
}

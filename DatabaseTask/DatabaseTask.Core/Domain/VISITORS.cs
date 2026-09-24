using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class VISITORS
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        public int personal_number { get; set; }
        public int Telephone_number { get; set; }
        [MaxLength(15)]
        public string relation_to_the_prisoner { get; set; }

        public int VISIT_Id { get; set; }
        [ForeignKey(nameof(VISIT_Id))]
        public VISIT VISIT { get; set; } = null!;

        public ICollection<PRISONERS> Prisoners { get; set; } = new List<PRISONERS>();
    }
}

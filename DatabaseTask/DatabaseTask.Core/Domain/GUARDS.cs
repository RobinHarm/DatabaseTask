using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class GUARDS
    {
        [Key]
        public int GUARDS_Id { get; set; }

        public int Prison_Id { get; set; }

        [ForeignKey(nameof(Prison_Id))]
        public PRISON PRISON { get; set; } = null!;
        [MaxLength(50)]
        public string First_name { get; set; } = null!;
        [MaxLength(50)]
        public string Last_name { get; set; } = null!;
        public int Worker_number { get; set; }
        [MaxLength(70)]
        public string job { get; set; } = null!;

        public ICollection<SHIFT> Shifts { get; set; } = new List<SHIFT>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class CRIME
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public int Difficulty_level { get; set; }

        public int PRISONER_Id { get; set; }
        [ForeignKey(nameof(PRISONER_Id))]
        public PRISONERS PRISONERS { get; set; } = null!;
    }
}

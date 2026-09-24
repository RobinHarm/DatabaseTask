using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PUNISHMENT
    {
        [Key]
        public int id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        [MaxLength(60)]
        public string punishment_Type { get; set; }

        public int PRISONERS_Id { get; set; }
        [ForeignKey(nameof(PRISONERS_Id))]
        public PRISONERS PRISONERS { get; set; } = null!; 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PRISONERS
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string First_Name { get; set; }
        [MaxLength(50)]
        public string Last_name { get; set; }
        public DateTime DOB { get; set; }
        public int personal_number { get; set; }
        public DateTime arrival_date { get; set; }
        public bool prisoner_status { get; set; }


        public int VISIT_Id { get; set; }
        [ForeignKey(nameof(VISIT_Id))]
        public VISIT VISIT { get; set; } = null!;


        public int CHAMBER_Id { get; set; }
        [ForeignKey(nameof(CHAMBER_Id))]
        public CHAMBER CHAMBER { get; set; } = null!;

        new ICollection<PUNISHMENT> Punishments { get; set; } = new List<PUNISHMENT>();
        new ICollection<CRIME> Crimes { get; set; } = new List<CRIME>();
        new ICollection<VISITORS> Visitors { get; set; } = new List<VISITORS>();
    }
}

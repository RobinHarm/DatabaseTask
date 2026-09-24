using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class BUILDING
    {
        [Key]
        public int id { get; set; }

        public int PRISON_Id { get; set; }
        [ForeignKey(nameof(PRISON_Id))]
        public PRISON PRISON { get; set; } = null!;
    }
}

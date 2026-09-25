using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Office
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(60)]
        public string Address { get; set; } = string.Empty;
        public int? PhoneNumber { get; set; }
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;
        public DateTime Registration_Date { get; set; }
        public DateTime End_Date { get; set; }
        public bool Status { get; set; }
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;

        public int Company_Id { get; set; }
        [ForeignKey(nameof(Company_Id))]
        public Company Company { get; set; } = null!;

        public int Intranet_Id { get; set; }
        [ForeignKey(nameof(Intranet_Id))]
        public Intranet Intranet { get; set; } = null!;

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

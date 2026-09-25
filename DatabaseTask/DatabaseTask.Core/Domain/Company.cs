using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        public int Id { get; set; }
        [MaxLength(50)] 
        public string Name { get; set; } = null!;
        public DateTime Registration_Date { get; set; }
        public DateTime end_Date { get; set; }
        [MaxLength(50)]
        public string Email { get; set; } = null!;
        public int? PhoneNumber { get; set; }
        [MaxLength(60)]
        public string Address { get; set; } = null!;
        public bool Status { get; set; }
        [MaxLength(200)]
        public string Comment { get; set; } = null!;




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Intranet
    {
        public int Id { get; set; }
        public int? Users { get; set; }
        public bool Status { get; set; }
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class SickPage
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        [MaxLength(200)]
        public string Reason { get; set; } = string.Empty;
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;

        public ICollection<Workers> Workers { get; set; } = new List<Workers>();
    }
}

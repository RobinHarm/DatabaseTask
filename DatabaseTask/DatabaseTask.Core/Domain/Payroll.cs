using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Payroll
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public float Sum { get; set; }
        public DateTime date { get; set; }

        public Employee Employee { get; set; }
    }
}

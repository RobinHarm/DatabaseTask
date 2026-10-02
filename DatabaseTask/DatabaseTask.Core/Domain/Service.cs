using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }
        public string ServiceType { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
    }
}

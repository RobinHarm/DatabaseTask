using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class ServiceOrder
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? ServicesId { get; set; }
        public Guid? BookingId { get; set; }
        public DateTime Date { get; set; }

        public Booking Booking { get; set; }
        public Service Service { get; set; }
    }
}

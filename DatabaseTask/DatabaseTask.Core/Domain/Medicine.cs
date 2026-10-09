using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Medicine
    {
        [Key]
        public Guid? Id { get; set; }
        [MaxLength(80)]
        public string MedicineName { get; set; }
        [MaxLength(200)]
        public string ActiveIngredient { get; set; }
        [MaxLength(80)]
        public string Producer { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        public PrescribedMedicine PrescribedMedicine { get; set; }
    }
}

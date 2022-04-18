using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Infrastructure.Data
{
    public class SalonService
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [ForeignKey(nameof(Service))]
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        [ForeignKey(nameof(Salon))]
        public Guid SalonId { get; set; }
        public Salon Salon { get; set; }
    }
}

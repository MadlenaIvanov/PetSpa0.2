using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Infrastructure.Data
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string Image { get; set; }

        public ICollection<SalonService> Salons { get; set; } = new List<SalonService>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Infrastructure.Data
{
    public class Salon
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string NameOfSalon { get; set; }

        [Required]
        [StringLength(500)]
        public string Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [ForeignKey(nameof(Location))]
        public Guid LocationId { get; set; }
        public Location Location { get; set; }

        public ICollection<SalonService> Services { get; set; } = new List<SalonService>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();


    }
}

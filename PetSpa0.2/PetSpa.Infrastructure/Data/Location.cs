using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Infrastructure.Data
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string LocationTown { get; set; }

        public ICollection<Salon> Salons { get; set; } = new List<Salon>();
    }
}

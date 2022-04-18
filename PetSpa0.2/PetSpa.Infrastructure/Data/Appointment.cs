using PetSpa.Infrastructure.Data.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetSpa.Infrastructure.Data
{
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateOfAppointment { get; set; }


        [StringLength(30)]
        public string NameOfPet { get; set; }
        public int AgeOfPet { get; set; }

        public decimal WeightOfPet { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [ForeignKey(nameof(Service))]
        public Guid ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [Required]
        [ForeignKey(nameof(Salon))]
        public Guid SalonId { get; set; }
        public virtual Salon Salon { get; set; }
    }
}

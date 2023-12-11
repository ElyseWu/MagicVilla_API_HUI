using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaCreateDTO
    {

        [Required]
        [MaxLength(30)]
        public String Name { get; set; }
        public String? Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public String? ImageUrl { get; set; }
        public String? Amenity { get; set; }
    }
}

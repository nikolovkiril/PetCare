namespace PetCare.Data.Models.VetService
{
    using System.ComponentModel.DataAnnotations;

    using static PetCare.Models.DataConstants.VetService;

    public class VetService
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ServiceNameMaxLength)]
        public string ServiceName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImgUrl { get; set; }
    }
}

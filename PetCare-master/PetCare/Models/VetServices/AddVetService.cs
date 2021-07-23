namespace PetCare.Models.VetServices
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.VetService;

    public class AddVetService
    {
        [Required]
        [StringLength(ServiceNameMaxLength, 
            MinimumLength = ServiceNameMinLength,
            ErrorMessage = "Name must be between '3' and '30' symbols.")]
        [Display(Name = "Service Name")]
        public string ServiceName { get; init; }

        [Required]
        [MinLength(DescriptionMinLength,
            ErrorMessage = "Description must be at least '5' symbols.")]
        public string Description { get; init; }

        [Required]
        [Display(Name = "Img Url")]
        public string ImgUrl { get; init; }
    }
}

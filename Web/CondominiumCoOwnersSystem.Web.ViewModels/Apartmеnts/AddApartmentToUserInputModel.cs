namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class AddApartmentToUserInputModel : IMapTo<Apartment>
    {
        [Required]
        [Range(0, 50, ErrorMessage ="Етажа трябва да бъде между 0 и 50")]
        public int Floor { get; set; }

        [Required]
        public int ApartmentId { get; set; }

        public IEnumerable<ApartmentDropDownViewModel> Apartments { get; set; }

        [Required]
        [Range(0, 8, ErrorMessage ="Моля въведете брой обитатели.")]
        public int Inhabitant { get; set; }

        [Required]
        [Display(Name = "Building")]
        public int BuildingId { get; set; }

        public IEnumerable<BuildingDropDownViewModel> Buildings { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        public IEnumerable<AllCityViewModel> Cities { get; set; }
    }
}

namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    // TODO: extract Validation Constat
    public class AddApartmentToUserInputModel : IMapTo<Apartment>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете вашият номер на етаж!")]
        [Range(0, 50, ErrorMessage ="Етажа трябва да бъде между 0 и 50.")]
        public int Floor { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля изберете вашият апартамент!")]
        [Display(Name = "Апартамент:")]
        public int ApartmentId { get; set; }

        public IEnumerable<ApartmentDropDownViewModel> Apartments { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете броят живущи в апартамента!")]
        [Range(0, 8, ErrorMessage ="Моля въведете актуален брой обитатели.")]
        public int Inhabitant { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля изберете вашата сграда!")]
        [Display(Name = "Сграда:")]
        public int BuildingId { get; set; }

        public IEnumerable<BuildingDropDownViewModel> Buildings { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля изберете вашият град!")]
        [Display(Name = "Град:")]
        public int CityId { get; set; }

        public IEnumerable<AllCityViewModel> Cities { get; set; }
    }
}

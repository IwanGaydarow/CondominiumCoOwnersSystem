namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    // TODO: extract Validation Constat
    public class AddApartmentToUserInputModel : IMapTo<Apartment>, IMapFrom<Apartment>
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля изберете вашият апартамент!")]
        [Display(Name = "Апартамент:")]
        public int ApartmentId { get; set; }

        public IEnumerable<ApartmentDropDownViewModel> Apartments { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете броят живущи в апартамента!")]
        [Range(0, 8, ErrorMessage = "Моля въведете актуален брой обитатели.")]
        public int Inhabitants { get; set; }

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

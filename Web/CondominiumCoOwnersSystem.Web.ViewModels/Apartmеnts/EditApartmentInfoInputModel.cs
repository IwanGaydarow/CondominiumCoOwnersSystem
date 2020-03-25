namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.ComponentModel.DataAnnotations;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class EditApartmentInfoInputModel : IMapTo<Apartment>, IMapFrom<Apartment>
    {
        [Required]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете вашият номер на етаж!")]
        [Range(0, 50, ErrorMessage = "Етажа трябва да бъде между 0 и 50.")]
        public int Floor { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете броят живущи в апартамента!")]
        [Range(0, 8, ErrorMessage = "Моля въведете актуален брой обитатели.")]
        public int Inhabitants { get; set; }
    }
}

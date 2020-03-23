namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ApartmentDropDownViewModel : IMapFrom<Apartment>
    {
        public int Id { get; set; }

        public int Number { get; set; }
    }
}

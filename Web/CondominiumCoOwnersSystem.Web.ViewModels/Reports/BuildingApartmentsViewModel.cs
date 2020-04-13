namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingApartmentsViewModel : IMapFrom<Apartment>
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int Inhabitants { get; set; }

        public decimal IdealParts { get; set; }
    }
}

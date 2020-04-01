namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingsOfUserViewModel : IMapFrom<Building>
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string CityName { get; set; }
    }
}

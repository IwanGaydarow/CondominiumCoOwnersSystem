namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingUtilityBillsViewModel : IMapFrom<BuildingUtilityBills>
    {
        public string UtilityName { get; set; }
    }
}

namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using System;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingAdditionalRepairsViewModel : IMapFrom<BuildingAdditionalRepairs>
    {
        public string MadeBy { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}

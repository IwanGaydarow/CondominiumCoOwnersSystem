namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using System;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingServiceSubscriptionViewModel : IMapFrom<BuildingServiceSubscription>
    {
        public DateTime CreatedOn { get; set; }

        public decimal Fee { get; set; }

        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string ServiceDescription { get; set; }
    }
}

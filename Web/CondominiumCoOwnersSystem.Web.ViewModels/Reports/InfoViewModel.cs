namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class InfoViewModel : IMapFrom<Building>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Street { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        [IgnoreMap]
        public string PaymentMethodAsString { get; set; }

        public decimal FundRepairFee { get; set; }

        public string FundRepairTypeOfDestribution { get; set; }

        [IgnoreMap]
        public int ApartmentsCount { get; set; }

        public IList<BuildingUtilityBillsViewModel> BuildingUtilityBills { get; set; }

        [IgnoreMap]
        public IEnumerable<BuildingServiceSubscriptionViewModel> BuildingServiceSubscriptions { get; set; }
    }
}

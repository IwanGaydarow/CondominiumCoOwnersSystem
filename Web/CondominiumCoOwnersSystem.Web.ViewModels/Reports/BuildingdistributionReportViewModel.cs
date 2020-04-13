namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    using System.Collections.Generic;

    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingDistributionReportViewModel : IMapFrom<Building>
    {
        public BuildingDistributionReportViewModel()
        {
            this.ApartmentsUtilityTax = new List<IEnumerable<KeyValuePair<int, decimal>>>();
            this.ApartmentsSubscriptionTax = new List<IEnumerable<KeyValuePair<int, decimal>>>();
            this.ApartmentsAdditionalTax = new List<IEnumerable<KeyValuePair<int, decimal>>>();
        }

        public string Street { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        [IgnoreMap]
        public string PaymentMethodAsString { get; set; }

        public decimal FundRepairFee { get; set; }

        public PaymentMethod FundRepairTypeOfDestribution { get; set; }

        [IgnoreMap]
        public string FundRepairTypeOfDestributionAsString { get; set; }

        [IgnoreMap]
        public IEnumerable<KeyValuePair<int, decimal>> ApartmentsFundRepairTax { get; set; }

        [IgnoreMap]
        public IList<IEnumerable<KeyValuePair<int, decimal>>> ApartmentsUtilityTax { get; set; }

        [IgnoreMap]
        public IList<IEnumerable<KeyValuePair<int, decimal>>> ApartmentsSubscriptionTax { get; set; }

        [IgnoreMap]
        public IList<IEnumerable<KeyValuePair<int, decimal>>> ApartmentsAdditionalTax { get; set; }

        public IEnumerable<BuildingApartmentsViewModel> Apartments { get; set; }

        public IEnumerable<BuildingUtilityBillsViewModel> UtilityBills { get; set; }

        public IEnumerable<BuildingServiceSubscriptionViewModel> SubscriptionBills { get; set; }

        public IEnumerable<BuildingAdditionalRepairsViewModel> AdditionalRepairsBills { get; set; }
    }
}

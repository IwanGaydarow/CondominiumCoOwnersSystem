namespace CondominiumCoOwnersSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ReportService : IReportsService
    {
        private readonly IDeletableEntityRepository<BuildingServiceSubscription> serviceRepository;
        private readonly IDeletableEntityRepository<Company> companyRepositor;
        private readonly IDeletableEntityRepository<Building> buildingRepository;
        private readonly IDeletableEntityRepository<BuildingUtilityBills> utilityBillsRepository;
        private readonly IDeletableEntityRepository<BuildingAdditionalRepairs> additionalRepairsRepository;

        public ReportService(
            IDeletableEntityRepository<BuildingServiceSubscription> serviceRepository,
            IDeletableEntityRepository<Company> companyRepositor,
            IDeletableEntityRepository<Building> buildingRepository,
            IDeletableEntityRepository<BuildingUtilityBills> utilityBillsRepository,
            IDeletableEntityRepository<BuildingAdditionalRepairs> additionalRepairsRepository)
        {
            this.serviceRepository = serviceRepository;
            this.companyRepositor = companyRepositor;
            this.buildingRepository = buildingRepository;
            this.utilityBillsRepository = utilityBillsRepository;
            this.additionalRepairsRepository = additionalRepairsRepository;
        }

        public T GetCompanyInfoById<T>(int companyId)
        {
            return this.companyRepositor.All().Where(x => x.Id == companyId).To<T>().FirstOrDefault();
        }

        public T GetDistributionReportForBuilding<T>(int buildingId)
        {
            var query = this.buildingRepository.All().Where(x => x.Id == buildingId);

            return query.To<T>().FirstOrDefault();
        }

        public IEnumerable<T> GetFiltrateUtilityBillsForReport<T>(int buildingId, int month)
        {
            return this.utilityBillsRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId && x.CreatedOn.Month == month).To<T>().ToList();
        }

        public IEnumerable<T> GetFiltrateAdditionalRepairsForReport<T>(int buildingId, int month)
        {
            return this.additionalRepairsRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId && x.CreatedOn.Month == month).To<T>().ToList();
        }

        public IEnumerable<T> GetFiltrateSubscriptionBillsForReport<T>(int buildingId, int month)
        {
            return this.serviceRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId && x.CreatedOn.Month == month).To<T>().ToList();
        }

        /// <summary>
        /// Taking all oldest records for BuildingServiceSubscription table. Using this to inform user about
        /// all companies service in a building and from how long they servd.
        /// </summary>
        public IEnumerable<T> GetOldestBuildingServiceSubscriptions<T>(int buildingId)
        {
            // TODO:Test oldest year and curent year with same month. Should return oldest.
            // Exampl: 13.01.2019 and 13.01.2020 should return 13.01.2019
            var query = this.serviceRepository.All()
                .Where(x => x.BuildingId == buildingId)
                .OrderBy(x => x.CreatedOn);

            var oldestDate = query.Select(x => x.CreatedOn).First();

            return query.Where(x => x.CreatedOn <= oldestDate).To<T>().ToList();
        }

        /// <summary>
        /// Convert paymentMethod to bulgarin translation.This method is here, because only Data-Service layar knows about paymentMethod model.
        /// </summary>
        public string ConvertPaymentMethodToString(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.CountOfApartment => GlobalConstants.PaymentMethodCountOfApartment,
                PaymentMethod.CountOfPeople => GlobalConstants.PaymentMethodCountOfPeople,
                PaymentMethod.IdealParts => GlobalConstants.PaymentMethodIdealParts,
                _ => " ",
            };
        }
    }
}

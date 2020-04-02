namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ReportService : IReportsService
    {
        private readonly IDeletableEntityRepository<BuildingServiceSubscription> serviceRepository;
        private readonly IDeletableEntityRepository<Company> companyRepositor;

        public ReportService(
            IDeletableEntityRepository<BuildingServiceSubscription> serviceRepository,
            IDeletableEntityRepository<Company> companyRepositor)
        {
            this.serviceRepository = serviceRepository;
            this.companyRepositor = companyRepositor;
        }

        public T GetCompanyInfoById<T>(int companyId)
        {
            return this.companyRepositor.All().Where(x => x.Id == companyId).To<T>().FirstOrDefault();
        }

        /// <summary>
        /// Taking all oldest records for BuildingServiceSubscription table. Using this to inform user about
        /// all companies service in a building and from how long they servd.
        /// </summary>
        /// <returns>
        /// BuildingServiceSubscriptionViewModel with info about company name and id, description about this service
        ///  and oldest date and fee for this service.
        ///  </returns>
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
    }
}

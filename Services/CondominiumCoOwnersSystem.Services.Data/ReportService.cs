namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ReportService : IReportsService
    {
        private readonly IRepository<Company> repository;
        private readonly IRepository<Apartment> apartmentRepository;

        public ReportService(
            IRepository<Company> repository,
            IRepository<Apartment> apartmentRepository)
        {
            this.repository = repository;
            this.apartmentRepository = apartmentRepository;
        }

        public IEnumerable<T> GetAllCompaniesInCondominium<T>(int buildingId)
        {
            return this.repository.All()
                .SelectMany(x => x.BuildingServiceSubscription.Where(y => y.BuildingId == buildingId))
                .To<T>()
                .ToList();
        }
    }
}

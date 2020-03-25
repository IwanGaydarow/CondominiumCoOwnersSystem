namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class BuildingService : IBuildingsService
    {
        private readonly IRepository<Building> buildingRepository;

        public BuildingService(IRepository<Building> buildingRepository)
        {
            this.buildingRepository = buildingRepository;
        }

        public IEnumerable<T> GetAllBuildingsByCity<T>(int cityId)
        {
            return this.buildingRepository.All()
                .Where(x => x.CityId == cityId)
                .To<T>().ToList();
        }
    }
}

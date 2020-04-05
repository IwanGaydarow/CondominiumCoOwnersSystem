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

        /// <summary>
        /// Filtrate all building where user own apartment.
        /// </summary>
        public IEnumerable<T> GetAllBuildingByUserId<T>(string userId)
        {
            return this.buildingRepository.All().Where(x =>
                        x.Apartments.Any(y => y.UserId == userId))
                        .To<T>().ToList();
        }

        public IEnumerable<T> GetAllBuildingsByCity<T>(int cityId)
        {
            return this.buildingRepository.All()
                .Where(x => x.CityId == cityId)
                .To<T>().ToList();
        }

        public T GetBuildingById<T>(int buildingId)
        {
            return this.buildingRepository.All()
                .Where(x => x.Id == buildingId)
                .To<T>().FirstOrDefault();
        }
    }
}

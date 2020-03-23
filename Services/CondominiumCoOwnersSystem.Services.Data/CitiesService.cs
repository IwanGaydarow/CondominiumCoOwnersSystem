namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class CitiesService : ICitiesService
    {
        private readonly IRepository<City> cityRepository;

        public CitiesService(IRepository<City> cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public IEnumerable<T> AllCities<T>()
        {
            return this.cityRepository.All().To<T>().ToList();
        }
    }
}

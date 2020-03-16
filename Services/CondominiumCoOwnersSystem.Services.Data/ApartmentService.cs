namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ApartmentService : IApartmentService
    {
        private readonly IDeletableEntityRepository<Apartment> apartmentRepository;

        public ApartmentService(IDeletableEntityRepository<Apartment> apartmentRepository)
        {
            this.apartmentRepository = apartmentRepository;
        }

        public IEnumerable<T> GetAllApartments<T>(string username)
        {
            return this.apartmentRepository.All()
                .Where(x => x.User.UserName == username)
                .To<T>().ToList();
        }

        public T GetDetails<T>(int apartmentId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.Id == apartmentId)
                .To<T>().FirstOrDefault();
        }
    }
}

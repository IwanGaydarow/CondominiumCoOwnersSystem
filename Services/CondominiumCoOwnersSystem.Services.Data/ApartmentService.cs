namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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

        public IEnumerable<T> GetAllApartments<T>(string userId)
        {
            return this.apartmentRepository.AllAsNoTracking()
                .Where(x => x.User.Id == userId || x.IsDeleted == false)
                .To<T>().ToList();
        }

        public T GetDetails<T>(int apartmentId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.Id == apartmentId)
                .To<T>().FirstOrDefault();
        }

        public async Task RemoveApartment(int apartmentId)
        {
            var apartmentForDelete = await this.apartmentRepository
                .GetByIdWithDeletedAsync(apartmentId);

            this.apartmentRepository.Delete(apartmentForDelete);
            await this.apartmentRepository.SaveChangesAsync();
        }
    }
}

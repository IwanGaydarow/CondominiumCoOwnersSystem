namespace CondominiumCoOwnersSystem.Services.Data
{
    using System;
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

        public async Task AddApartmentToUserAsync(int apartmentId, int floor, int inhabitant, string userId)
        {
            var apartment = await this.apartmentRepository.GetByIdWithDeletedAsync(apartmentId);

            if (apartment == null)
            {
                throw new NullReferenceException();
            }

            apartment.UserId = userId;
            apartment.Floor = floor;
            apartment.Inhabitants = inhabitant;
            apartment.IsDeleted = false;

            await this.apartmentRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllApartmentsOfUser<T>(string userId)
        {
            return this.apartmentRepository.All()
                .Where(x => x.User.Id == userId && x.IsDeleted == false)
                .To<T>().ToList();
        }

        public IEnumerable<T> GetAllFreeApartments<T>(int buildingId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId && x.IsDeleted == true)
                .To<T>().ToList();
        }

        public T GetApartmentDetails<T>(int apartmentId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.Id == apartmentId)
                .To<T>().FirstOrDefault();
        }

        public async Task RemoveApartmentFromUser(int apartmentId)
        {
            var apartmentForDelete = await this.apartmentRepository
                .GetByIdWithDeletedAsync(apartmentId);

            this.apartmentRepository.Delete(apartmentForDelete);
            await this.apartmentRepository.SaveChangesAsync();
        }
    }
}

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

        public async Task AddApartmentToUserAsync(int apartmentId, int inhabitant, string userId)
        {
            var apartment = await this.apartmentRepository.GetByIdWithDeletedAsync(apartmentId);

            if (apartment == null)
            {
                throw new NullReferenceException();
            }

            apartment.Inhabitants = inhabitant;
            apartment.UserId = userId;

            await this.apartmentRepository.SaveChangesAsync();
        }

        public int CountOfApartmentsInBuilding(int buildingId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId).Count();
        }

        public async Task EditApartment(int apartmentId, int inhabitants)
        {
            var apartmentToEdit = this.apartmentRepository.All()
                .Where(x => x.Id == apartmentId)
                .FirstOrDefault();

            if (apartmentToEdit == null)
            {
                throw new NullReferenceException();
            }

            apartmentToEdit.Inhabitants = inhabitants;

            this.apartmentRepository.Update(apartmentToEdit);
            await this.apartmentRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllApartmentsOfUser<T>(string userId)
        {
            var apartments = this.apartmentRepository.All()
                .Where(x => x.User.Id == userId)
                .AsQueryable();

            if (apartments == null)
            {
                return null;
            }

            return apartments.To<T>().ToList();
        }

        public IEnumerable<T> GetAllFreeApartments<T>(int buildingId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId && x.UserId == null)
                .OrderBy(x => x.Number)
                .To<T>().ToList();
        }

        public T GetApartmentById<T>(int apartmentId)
        {
            return this.apartmentRepository.All()
                .Where(x => x.Id == apartmentId)
                .To<T>().FirstOrDefault();
        }

        public T GetApartmentDetails<T>(int apartmentId)
        {
            return this.apartmentRepository.All()
                .Where(x => x.Id == apartmentId)
                .To<T>().FirstOrDefault();
        }

        public async Task RemoveApartmentFromUser(int apartmentId)
        {
            var apartmentForDelete = await this.apartmentRepository
                .GetByIdWithDeletedAsync(apartmentId);
            apartmentForDelete.UserId = null;

            this.apartmentRepository.Update(apartmentForDelete);
            await this.apartmentRepository.SaveChangesAsync();
        }
    }
}

namespace CondominiumCoOwnersSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;
    using Microsoft.AspNetCore.Identity;

    public class ApartmentService : IApartmentService
    {
        private readonly IDeletableEntityRepository<Apartment> apartmentRepository;

        public ApartmentService(IDeletableEntityRepository<Apartment> apartmentRepository)
        {
            this.apartmentRepository = apartmentRepository;
        }

        public async Task AddApartmentAsync(int apartmentId, int floor, int inhabitant, string userId)
        {
            var apartment = this.apartmentRepository.AllWithDeleted().Where(x => x.Id == apartmentId).FirstOrDefault();

            if (apartment == null)
            {
                throw new NullReferenceException();
            }

            apartment.UserId = userId;
            apartment.Floor = floor;
            apartment.Inhabitants = inhabitant;

            await this.apartmentRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllApartments<T>(string userId)
        {
            return this.apartmentRepository.All()
                .Where(x => x.User.Id == userId || x.IsDeleted == false)
                .To<T>().ToList();
        }

        public IEnumerable<T> GetAllFreeApartments<T>(int buildingId)
        {
            return this.apartmentRepository.AllWithDeleted()
                .Where(x => x.BuildingId == buildingId)
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

namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApartmentService
    {
        IEnumerable<T> GetAllApartmentsOfUser<T>(string userId);

        IEnumerable<T> GetAllFreeApartments<T>(int buildingId);

        T GetApartmentDetails<T>(int apartmentId);

        Task RemoveApartmentFromUser(int apartmentId);

        Task AddApartmentToUserAsync(int apartmentId, int floor, int inhabitant, string userId);
    }
}

namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApartmentService
    {
        IEnumerable<T> GetAllApartments<T>(string userId);

        IEnumerable<T> GetAllFreeApartments<T>(int buildingId);

        T GetDetails<T>(int apartmentId);

        Task RemoveApartment(int apartmentId);

        Task AddApartmentAsync(int apartmentId, int floor, int inhabitant, string userId);
    }
}

namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApartmentService
    {
        int CountOfApartmentsInBuilding(int buildingId);

        IEnumerable<T> GetAllApartmentsOfUser<T>(string userId);

        IEnumerable<T> GetAllFreeApartments<T>(int buildingId);

        T GetApartmentById<T>(int apartmentId);

        T GetApartmentDetails<T>(int apartmentId);

        Task EditApartment(int apartmentId, int inhabitants);

        Task RemoveApartmentFromUser(int apartmentId);

        Task AddApartmentToUserAsync(int apartmentId, int inhabitant, string userId);
    }
}

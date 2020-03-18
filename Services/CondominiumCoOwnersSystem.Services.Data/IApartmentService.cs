namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IApartmentService
    {
        IEnumerable<T> GetAllApartments<T>(string username);

        T GetDetails<T>(int apartmentId);

        Task RemoveApartment(int apartmentId);
    }
}

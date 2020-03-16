namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    public interface IApartmentService
    {
        IEnumerable<T> GetAllApartments<T>(string username);

        T GetDetails<T>(int apartmentId);
    }
}

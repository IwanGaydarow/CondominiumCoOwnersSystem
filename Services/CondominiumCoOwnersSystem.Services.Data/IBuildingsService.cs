namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    public interface IBuildingsService
    {
        IEnumerable<T> GetAllBuildingsByCity<T>(int cityId);
    }
}

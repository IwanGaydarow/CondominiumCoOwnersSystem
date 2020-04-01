namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    public interface IBuildingsService
    {
        IEnumerable<T> GetAllBuildingsByCity<T>(int cityId);

        
        IEnumerable<T> GetAllBuildingByUserId<T>(string userId);

        T GetBuildingById<T>(int buildingId);
    }
}

namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IReportsService
    {
        IEnumerable<T> GetOldestBuildingServiceSubscriptions<T>(int buildingId);

        T GetCompanyInfoById<T>(int companyId);
    }
}

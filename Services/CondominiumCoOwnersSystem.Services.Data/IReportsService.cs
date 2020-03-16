namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    public interface IReportsService
    {
        IEnumerable<T> GetAllCompaniesInCondominium<T>(int buildingId);
    }
}

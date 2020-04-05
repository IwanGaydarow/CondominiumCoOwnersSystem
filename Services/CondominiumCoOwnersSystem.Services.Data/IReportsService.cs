namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public interface IReportsService
    {
        IEnumerable<T> GetOldestBuildingServiceSubscriptions<T>(int buildingId);

        T GetCompanyInfoById<T>(int companyId);

        string ConvertPaymentMethodToString(PaymentMethod paymentMethod);
    }
}

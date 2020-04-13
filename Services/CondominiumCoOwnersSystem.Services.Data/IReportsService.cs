namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    using CondominiumCoOwnersSystem.Data.Models.Enums;

    public interface IReportsService
    {
        T GetDistributionReportForBuilding<T>(int buildingId);

        IEnumerable<T> GetFiltrateUtilityBillsForReport<T>(int buildingId, int month);

        IEnumerable<T> GetFiltrateAdditionalRepairsForReport<T>(int buildingId, int month);

        IEnumerable<T> GetFiltrateSubscriptionBillsForReport<T>(int buildingId, int month);

        IEnumerable<T> GetOldestBuildingServiceSubscriptions<T>(int buildingId);

        T GetCompanyInfoById<T>(int companyId);

        string ConvertPaymentMethodToString(PaymentMethod paymentMethod);
    }
}

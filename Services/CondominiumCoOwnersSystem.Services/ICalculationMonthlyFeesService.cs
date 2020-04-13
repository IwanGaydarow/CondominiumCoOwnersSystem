namespace CondominiumCoOwnersSystem.Services
{
    using System.Collections.Generic;

    using CondominiumCoOwnersSystem.Services.Models;

    public interface ICalculationMonthlyFeesService
    {
        KeyValuePair<int, decimal> CalculateTax(
            string paymentMethod,
            decimal totalFee,
            IEnumerable<ApartmentsCalculationModel> apartmentInfo);

        public IEnumerable<KeyValuePair<int, decimal>> CalculateFundRepair(
            string paymentMethod,
            decimal totalFee,
            IEnumerable<ApartmentsCalculationModel> apartmentInfo);
    }
}

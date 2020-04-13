namespace CondominiumCoOwnersSystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Services.Models;

    public class CalculationMonthlyFeesService : ICalculationMonthlyFeesService
    {
        private KeyValuePair<int, decimal> tax;
        private IList<KeyValuePair<int, decimal>> fundrepairTax;

        public KeyValuePair<int, decimal> CalculateTax(string paymentMethod, decimal totalFee, IEnumerable<ApartmentsCalculationModel> apartmentInfo)
        {
            if (paymentMethod == GlobalConstants.PaymentMethodCountOfApartment)
            {
                var apartmentTax = Math.Round(totalFee / apartmentInfo.Count(), 2);

                foreach (var apartment in apartmentInfo)
                {
                    this.tax = new KeyValuePair<int, decimal>(apartment.Id, apartmentTax);
                }

                return this.tax;
            }
            else if (paymentMethod == GlobalConstants.PaymentMethodCountOfPeople)
            {
                var peopleCount = apartmentInfo.Sum(x => x.Inhabitants);
                var taxForOnePerson = totalFee / peopleCount;

                foreach (var apartment in apartmentInfo)
                {
                    var taxForApartment = Math.Round(taxForOnePerson * apartment.Inhabitants, 2);

                    this.tax = new KeyValuePair<int, decimal>(apartment.Id, taxForApartment);
                }

                return this.tax;
            }
            else if (paymentMethod == GlobalConstants.PaymentMethodIdealParts)
            {
                var taxForOnePercent = totalFee / 100;

                foreach (var apartment in apartmentInfo)
                {
                    var apartmentTax = Math.Round(taxForOnePercent * apartment.IdealParts, 2);
                    this.tax = new KeyValuePair<int, decimal>(apartment.Id, apartmentTax);
                }

                return this.tax;
            }
            else
            {
                throw new ArgumentException("PaymentMethod is not corect.");
            }
        }

        public IEnumerable<KeyValuePair<int, decimal>> CalculateFundRepair(string paymentMethod, decimal totalFee, IEnumerable<ApartmentsCalculationModel> apartmentInfo)
        {
            this.fundrepairTax = new List<KeyValuePair<int, decimal>>();

            if (paymentMethod == GlobalConstants.PaymentMethodCountOfApartment)
            {
                var apartmentTax = Math.Round(totalFee / apartmentInfo.Count(), 2, MidpointRounding.AwayFromZero);

                foreach (var apartment in apartmentInfo)
                {
                    this.fundrepairTax.Add(new KeyValuePair<int, decimal>(apartment.Id, apartmentTax));
                }

                return this.fundrepairTax;
            }
            else if (paymentMethod == GlobalConstants.PaymentMethodCountOfPeople)
            {
                var peopleCount = apartmentInfo.Sum(x => x.Inhabitants);
                var taxForOnePerson = totalFee / peopleCount;

                foreach (var apartment in apartmentInfo)
                {
                    var taxForApartment = Math.Round(taxForOnePerson * apartment.Inhabitants, 2, MidpointRounding.AwayFromZero);

                    this.fundrepairTax.Add(new KeyValuePair<int, decimal>(apartment.Id, taxForApartment));
                }

                return this.fundrepairTax;
            }
            else if (paymentMethod == GlobalConstants.PaymentMethodIdealParts)
            {
                var taxForOnePercent = totalFee / 100;

                foreach (var apartment in apartmentInfo)
                {
                    var apartmentTax = Math.Round(taxForOnePercent * apartment.IdealParts, 2, MidpointRounding.AwayFromZero);
                    this.fundrepairTax.Add(new KeyValuePair<int, decimal>(apartment.Id, apartmentTax));
                }

                return this.fundrepairTax;
            }
            else
            {
                throw new ArgumentException("PaymentMethod is not corect.");
            }
        }
    }
}

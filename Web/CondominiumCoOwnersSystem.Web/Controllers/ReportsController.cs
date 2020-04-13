namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services;
    using CondominiumCoOwnersSystem.Services.Data;
    using CondominiumCoOwnersSystem.Services.Models;
    using CondominiumCoOwnersSystem.Web.ViewModels.Reports;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class ReportsController : BaseController
    {
        private readonly IReportsService reportsService;
        private readonly IApartmentService apartmentService;
        private readonly IBuildingsService buildingService;
        private readonly ICalculationMonthlyFeesService calculationMonthlyFeesService;
        private readonly UserManager<ApplicationUser> userManager;

        public ReportsController(
            IReportsService reportsService,
            IApartmentService apartmentService,
            IBuildingsService buildingService,
            ICalculationMonthlyFeesService calculationMonthlyFeesService,
            UserManager<ApplicationUser> userManager)
        {
            this.reportsService = reportsService;
            this.apartmentService = apartmentService;
            this.buildingService = buildingService;
            this.calculationMonthlyFeesService = calculationMonthlyFeesService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var buildings = this.buildingService.GetAllBuildingByUserId<BuildingsOfUserViewModel>(user.Id);

            return this.View(buildings);
        }

        public IActionResult BuildingInfo(int buildingId)
        {
            var buildingInfo = this.buildingService.GetBuildingById<InfoViewModel>(buildingId);
            buildingInfo.FundReoairTypeOfDestributionAsString = this.reportsService.ConvertPaymentMethodToString(buildingInfo.FundRepairTypeOfDestribution);
            buildingInfo.ApartmentsCount = this.apartmentService.CountOfApartmentsInBuilding(buildingId);
            buildingInfo.BuildingServiceSubscriptions =
                this.reportsService.GetOldestBuildingServiceSubscriptions<BuildingServiceSubscriptionViewModel>(buildingId);
            buildingInfo.PaymentMethodAsString = this.reportsService.ConvertPaymentMethodToString(buildingInfo.PaymentMethod);

            var uniqueUtility = buildingInfo.BuildingUtilityBills
                            .Select(x => x.UtilityName).Distinct<string>().ToList();
            buildingInfo.BuildingUtilityBills.Clear();

            foreach (var utility in uniqueUtility)
            {
                buildingInfo.BuildingUtilityBills.Add(new BuildingUtilityBillsViewModel { UtilityName = utility });
            }

            return this.View(buildingInfo);
        }

        public IActionResult Report(int buildingId, int? month = null)
        {
            if (!month.HasValue)
            {
                month = DateTime.UtcNow.Month;
            }

            // Colect data from DB.
            var reportModel = this.reportsService.GetDistributionReportForBuilding<BuildingDistributionReportViewModel>(buildingId);
            reportModel.UtilityBills = this.reportsService.GetFiltrateUtilityBillsForReport<BuildingUtilityBillsViewModel>(buildingId, (int)month);
            reportModel.AdditionalRepairsBills = this.reportsService.GetFiltrateAdditionalRepairsForReport<BuildingAdditionalRepairsViewModel>(buildingId, (int)month);
            reportModel.SubscriptionBills = this.reportsService.GetFiltrateSubscriptionBillsForReport<BuildingServiceSubscriptionViewModel>(buildingId, (int)month);
            reportModel.PaymentMethodAsString = this.reportsService.ConvertPaymentMethodToString(reportModel.PaymentMethod);

            // Calculate each tax.
            var apartmentModel = new List<ApartmentsCalculationModel>();
            foreach (var apartment in reportModel.Apartments)
            {
                var model = new ApartmentsCalculationModel
                {
                    Id = apartment.Id,
                    Inhabitants = apartment.Inhabitants,
                    IdealParts = apartment.IdealParts,
                };
                apartmentModel.Add(model);
            }

            // -------FundRepair tax.
            reportModel.FundRepairTypeOfDestributionAsString = this.reportsService.ConvertPaymentMethodToString(reportModel.FundRepairTypeOfDestribution);
            var paymentMethod = reportModel.FundRepairTypeOfDestributionAsString;
            var currentTax = reportModel.FundRepairFee;

            reportModel.ApartmentsFundRepairTax = this.calculationMonthlyFeesService.CalculateFundRepair(paymentMethod, currentTax, apartmentModel);

            // --------UtilityTax.
            paymentMethod = reportModel.PaymentMethodAsString;
            foreach (var utility in reportModel.UtilityBills)
            {
                currentTax = utility.Cost;
                reportModel.ApartmentsUtilityTax.Add(this.calculationMonthlyFeesService.CalculateFundRepair(paymentMethod, currentTax, apartmentModel));
            }

            // --------SubscriptionTax
            foreach (var subscription in reportModel.SubscriptionBills)
            {
                currentTax = subscription.Fee;
                reportModel.ApartmentsSubscriptionTax.Add(this.calculationMonthlyFeesService.CalculateFundRepair(paymentMethod, currentTax, apartmentModel));
            }

            // -------AdditionalTax
            foreach (var additionalRepair in reportModel.AdditionalRepairsBills)
            {
                currentTax = additionalRepair.Cost;
                reportModel.ApartmentsAdditionalTax.Add(this.calculationMonthlyFeesService.CalculateFundRepair(paymentMethod, currentTax, apartmentModel));
            }

            return this.View(reportModel);
        }

        public IActionResult Obligations()
        {
            return this.View();
        }
    }
}

namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Data.Models.Enums;
    using CondominiumCoOwnersSystem.Services.Data;
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
        private readonly UserManager<ApplicationUser> userManager;

        public ReportsController(
            IReportsService reportsService,
            IApartmentService apartmentService,
            IBuildingsService buildingService,
            UserManager<ApplicationUser> userManager)
        {
            this.reportsService = reportsService;
            this.apartmentService = apartmentService;
            this.buildingService = buildingService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var buildings = this.buildingService.GetAllBuildingByUserId<BuildingsOfUserViewModel>(user.Id);

            return this.View(buildings);
        }

        // TODO: Refoctoring of this Action.
        public IActionResult BuildingInfo(int buildingId)
        {
            var buildingInfo = this.buildingService.GetBuildingById<InfoViewModel>(buildingId);
            buildingInfo.ApartmentsCount = this.apartmentService.CountOfApartmentsInBuilding(buildingId);
            buildingInfo.BuildingServiceSubscriptions =
                this.reportsService.GetOldestBuildingServiceSubscriptions<BuildingServiceSubscriptionViewModel>(buildingId);
            buildingInfo.PaymentMethodAsString = buildingInfo.PaymentMethod switch
            {
                PaymentMethod.CountOfApartment => "Според броя на апартаменти",
                PaymentMethod.CountOfPeople => "Според брой хора живеещи в апартамента",
                PaymentMethod.IdealParts => "Според идеалните части на апартамента",
                _ => "Не е решено",
            };

            var uniqueUtility = buildingInfo.BuildingUtilityBills
                            .Select(x => x.UtilityName).Distinct<string>().ToList();
            buildingInfo.BuildingUtilityBills.Clear();

            foreach (var utility in uniqueUtility)
            {
                buildingInfo.BuildingUtilityBills.Add(new BuildingUtilityBillsViewModel { UtilityName = utility });
            }

            return this.View(buildingInfo);
        }

        public IActionResult Obligations()
        {
            return this.View();
        }

        public IActionResult CompanyInfo(int companyId)
        {
            var companyInfo = this.reportsService.GetCompanyInfoById<CompanyInfoViewModel>(companyId);
            return this.PartialView("_CompanyInfoPartial", companyInfo);
        }
    }
}

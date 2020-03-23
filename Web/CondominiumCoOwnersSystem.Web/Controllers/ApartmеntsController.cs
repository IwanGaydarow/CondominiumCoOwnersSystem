namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Data;
    using CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class ApartmеntsController : BaseController
    {
        private readonly IApartmentService apartmentService;
        private readonly ICitiesService citiesService;
        private readonly IBuildingsService buildingService;
        private readonly UserManager<ApplicationUser> userManager;

        public ApartmеntsController(
            IApartmentService apartmentService,
            ICitiesService citiesService,
            IBuildingsService buildingService,
            UserManager<ApplicationUser> userManager)
        {
            this.apartmentService = apartmentService;
            this.citiesService = citiesService;
            this.buildingService = buildingService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            var apartments = this.apartmentService
                .GetAllApartments<ApartmentViewModel>(user.Id);

            var model = new AllApartmentViewModel { Apartments = apartments };

            return this.View(model);
        }

        public async Task<IActionResult> RemoveApartment(int apartmentId)
        {
            await this.apartmentService.RemoveApartment(apartmentId);

            return this.RedirectToAction("Index");
        }

        public IActionResult Details(int apartmentId)
        {
            var details = this.apartmentService
                .GetDetails<ApartmentDetailsViewModel>(apartmentId);

            return this.View(details);
        }

        public IActionResult AddApartmentToUser()
        {
            var cities = this.citiesService.AllCities<AllCityViewModel>();
            var viewModel = new AddApartmentToUserInputModel { Cities = cities };
            return this.View(viewModel);
        }

        public IActionResult BuildingToAddApartment(int cityId)
        {
            var buildings = this.buildingService
                .GetAllBuildingsByCity<BuildingDropDownViewModel>(cityId);
            var view = new AddApartmentToUserInputModel { CityId = cityId, Buildings = buildings };

            return this.PartialView("_PartialBuildings", view);
        }

        public IActionResult FreeApartmentsToAdd(int buildingId, int cityId)
        {
            var apartments = this.apartmentService.GetAllFreeApartments<ApartmentDropDownViewModel>(buildingId);
            var view = new AddApartmentToUserInputModel { CityId = cityId, BuildingId = buildingId, Apartments = apartments };

            return this.PartialView("_PartialApartments", view);
        }

        [HttpPost]
        public async Task<IActionResult> AddApartmentToUser(AddApartmentToUserInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Json(new { success = false, errors = this.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList() });
            }

            var userId = this.userManager.GetUserId(this.User);
            await this.apartmentService.AddApartmentAsync(
                input.ApartmentId,
                input.Floor,
                input.Inhabitant,
                userId);

            return this.RedirectToAction("Index");
        }
    }
}

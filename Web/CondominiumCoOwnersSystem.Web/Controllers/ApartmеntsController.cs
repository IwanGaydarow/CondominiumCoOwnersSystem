namespace CondominiumCoOwnersSystem.Web.Controllers
{
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
                .GetAllApartmentsOfUser<ApartmentViewModel>(user.Id);

            var model = new AllApartmentViewModel { Apartments = apartments };

            return this.View(model);
        }

        public async Task<IActionResult> RemoveApartment(int apartmentId)
        {
            await this.apartmentService.RemoveApartmentFromUser(apartmentId);

            return this.RedirectToAction("Index");
        }

        public IActionResult Details(int apartmentId)
        {
            var details = this.apartmentService
                .GetApartmentDetails<ApartmentDetailsViewModel>(apartmentId);

            return this.View(details);
        }

        public IActionResult EditApartment(int apartmentId)
        {
            var apartment =
                this.apartmentService.GetApartmentById<EditApartmentInfoInputModel>(apartmentId);

            return this.PartialView("_PartialEditApartment", apartment);
        }

        [HttpPost]
        public async Task<IActionResult> EditApartment(EditApartmentInfoInputModel apartmentToEdit)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(apartmentToEdit);
            }

            await this.apartmentService.EditApartment(apartmentToEdit.Id, apartmentToEdit.Floor, apartmentToEdit.Inhabitants);

            return this.RedirectToAction("Index");
        }

        public IActionResult AddApartmentToUser()
        {
            var cities = this.citiesService.AllCities<AllCityViewModel>();
            var viewModel = new AddApartmentToUserInputModel { Cities = cities };

            return this.View(viewModel);
        }

        // TODO: Change model for AJAX request of buildings and apartments.
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
            var view = new AddApartmentToUserInputModel
            {
                CityId = cityId,
                BuildingId = buildingId,
                Apartments = apartments,
            };

            return this.PartialView("_PartialApartments", view);
        }

        // TODO: After changing model for apartments and buildings, change ModelState not valid return.
        [HttpPost]
        public async Task<IActionResult> AddApartmentToUser(AddApartmentToUserInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                var cities = this.citiesService.AllCities<AllCityViewModel>();
                var buildings = this.buildingService
                .GetAllBuildingsByCity<BuildingDropDownViewModel>(input.CityId);
                var apartments = this.apartmentService.GetAllFreeApartments<ApartmentDropDownViewModel>(input.BuildingId);

                input.Cities = cities;
                input.Buildings = buildings;
                input.Apartments = apartments;

                return this.View("AddApartmentToUser", input);
            }

            var userId = this.userManager.GetUserId(this.User);
            await this.apartmentService.AddApartmentToUserAsync(
                input.ApartmentId,
                input.Floor,
                input.Inhabitants,
                userId);

            return this.RedirectToAction("Index");
        }
    }
}

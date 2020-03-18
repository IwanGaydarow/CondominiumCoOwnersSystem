namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using System.Threading.Tasks;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Data;
    using CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class ApartmеntsController : BaseController
    {
        private readonly IApartmentService apartmentService;
        private readonly UserManager<ApplicationUser> userManager;

        public ApartmеntsController(
            IApartmentService apartmentService,
            UserManager<ApplicationUser> userManager)
        {
            this.apartmentService = apartmentService;
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
            return this.View();
        }
    }
}

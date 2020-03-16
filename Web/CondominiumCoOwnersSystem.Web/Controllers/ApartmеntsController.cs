namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using CondominiumCoOwnersSystem.Services.Data;
    using CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts;
    using Microsoft.AspNetCore.Mvc;

    public class ApartmеntsController : BaseController
    {
        private readonly IApartmentService apartmentService;

        public ApartmеntsController(IApartmentService apartmentService)
        {
            this.apartmentService = apartmentService;
        }

        public IActionResult Index()
        {
            var apartments = this.apartmentService
                .GetAllApartments<ApartmentViewModel>(this.User.Identity.Name);

            var model = new AllApartmentViewModel { Apartments = apartments };

            return this.View(model);
        }

        public IActionResult Details(int apartmentId)
        {
            var details = this.apartmentService
                .GetDetails<ApartmentDetailsViewModel>(apartmentId);

            return this.View(details);
        }
    }
}

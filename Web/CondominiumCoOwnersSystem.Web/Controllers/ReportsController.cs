namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ReportsController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Obligations()
        {
            return this.View();
        }

        public IActionResult Companies()
        {
            var buildingId = this.User.Identity.Name;

            return this.View();
        }
    }
}

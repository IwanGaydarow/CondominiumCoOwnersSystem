namespace CondominiumCoOwnersSystem.Web.Areas.Administration.Controllers
{
    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}

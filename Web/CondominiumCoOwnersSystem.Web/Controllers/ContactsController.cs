namespace CondominiumCoOwnersSystem.Web.Controllers
{
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Common;
    using CondominiumCoOwnersSystem.Services.Data.ContactServices;
    using CondominiumCoOwnersSystem.Services.Messaging;
    using CondominiumCoOwnersSystem.Web.ViewModels.Contacts;
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        private readonly IEmailSender emailSender;
        private readonly IContactService contactService;

        public ContactsController(IEmailSender emailSender, IContactService contactService)
        {
            this.emailSender = emailSender;
            this.contactService = contactService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactFormViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var ip = this.HttpContext.Connection.RemoteIpAddress.ToString();

            await this.contactService.CreateContactEntryAsync(model, ip);

            await this.emailSender.SendEmailAsync(
                model.Name,
                model.Email,
                GlobalConstants.SystemEmail,
                model.Title,
                model.Content);

            return this.RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou()
        {
            return this.View();
        }
    }
}

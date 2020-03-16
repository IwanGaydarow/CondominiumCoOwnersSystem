namespace CondominiumCoOwnersSystem.Services.Data.ContactServices
{
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Web.ViewModels.Contacts;

    public interface IContactService
    {
        Task CreateContactEntryAsync(ContactFormViewModel model, string ip);
    }
}

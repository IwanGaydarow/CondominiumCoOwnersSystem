namespace CondominiumCoOwnersSystem.Services.Data.ContactServices
{
    using CondominiumCoOwnersSystem.Web.ViewModels.Contacts;
    using System.Threading.Tasks;

    public interface IContactService
    {
        Task CreateContactEntry(ContactFormViewModel model, string ip);
    }
}

namespace CondominiumCoOwnersSystem.Services.Data.ContactServices
{
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Common.Repositories;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Web.ViewModels.Contacts;

    public class ContactService : IContactService
    {
        private readonly IRepository<ContactFormEntry> contactsRepository;

        public ContactService(IRepository<ContactFormEntry> repository)
        {
            this.contactsRepository = repository;
        }

        public async Task CreateContactEntryAsync(ContactFormViewModel model, string ip)
        {
            var contactForm = new ContactFormEntry
            {
                Name = model.Name,
                Email = model.Email,
                Title = model.Title,
                Content = model.Content,
                Ip = ip,
            };

            await this.contactsRepository.AddAsync(contactForm);
            await this.contactsRepository.SaveChangesAsync();
        }
    }
}

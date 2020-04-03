namespace CondominiumCoOwnersSystem.Web.ViewModels.CompanyInfo
{
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class CompanyInfoViewModel : IMapFrom<Company>
    {
        public string Name { get; set; }

        public string CompanyTypeTypeOfServices { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}

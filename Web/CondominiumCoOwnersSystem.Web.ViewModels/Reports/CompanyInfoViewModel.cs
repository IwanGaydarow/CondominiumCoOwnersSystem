using CondominiumCoOwnersSystem.Data.Models;
using CondominiumCoOwnersSystem.Services.Mapping;

namespace CondominiumCoOwnersSystem.Web.ViewModels.Reports
{
    public class CompanyInfoViewModel : IMapFrom<Company>
    {
        public string Name { get; set; }

        public string CompanyTypeTypeOfServices { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}

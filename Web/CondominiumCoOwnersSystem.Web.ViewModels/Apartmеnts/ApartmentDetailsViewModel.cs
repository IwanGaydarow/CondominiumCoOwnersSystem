namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ApartmentDetailsViewModel : IMapFrom<Apartment>, IHaveCustomMappings
    {
        public int Number { get; set; }

        public int Floor { get; set; }

        [IgnoreMap]
        public decimal DueAmount =>
            this.Obligations.Where(x => x.Payed == "Не").Sum(x => x.MontlyObligation);

        public IEnumerable<ObligationsViewModel> Obligations { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Apartment, ApartmentDetailsViewModel>()
                .ForMember(
                a => a.Obligations,
                o => o.MapFrom(x => x.MontlyObligations));
        }
    }
}

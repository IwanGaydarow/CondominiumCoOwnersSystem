namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ApartmentViewModel : IMapFrom<Apartment>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int Number { get; set; }

        public int Floor { get; set; }

        public string Address { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Apartment, ApartmentViewModel>().ForMember(
                am => am.Address,
                a => a.MapFrom(x => x.Building.Street));
        }
    }
}

namespace CondominiumCoOwnersSystem.Web.ViewModels.Apartmеnts
{
    using System;

    using AutoMapper;
    using CondominiumCoOwnersSystem.Data.Models;
    using CondominiumCoOwnersSystem.Services.Mapping;

    public class ObligationsViewModel : IMapFrom<ApartmentMontlyObligation>, IHaveCustomMappings
    {
        public decimal MontlyObligation { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Inhabitants { get; set; }

        public string Payed { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<ApartmentMontlyObligation, ObligationsViewModel>()
                .ForMember(
                om => om.Payed,
                ao => ao.MapFrom(x => x.IsDeleted == false ? "Не" : "Да"));
        }
    }
}

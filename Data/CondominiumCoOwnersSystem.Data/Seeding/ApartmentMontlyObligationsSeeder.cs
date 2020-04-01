namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class ApartmentMontlyObligationsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            //if (dbContext.ApartmentMontlyObligations.Any())
            //{
            //    return;
            //}

            //var obligations =
            //    new List<ApartmentMontlyObligation>()
            //    {
            //        new ApartmentMontlyObligation { ApartmentId = 1, MontlyObligation = 15.85M },
            //        new ApartmentMontlyObligation { ApartmentId = 1, MontlyObligation = 14M },
            //        new ApartmentMontlyObligation { ApartmentId = 1, MontlyObligation = 16M },
            //    };

            //foreach (var obligation in obligations)
            //{
            //    await dbContext.ApartmentMontlyObligations.AddAsync(obligation);
            //}

            await Task.CompletedTask;
        }
    }
}

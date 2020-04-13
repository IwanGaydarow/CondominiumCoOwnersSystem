namespace CondominiumCoOwnersSystem.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CondominiumCoOwnersSystem.Data.Models;

    public class ApartmentSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Apartments.Any())
            {
                return;
            }

            var apartments =
                new List<Apartment>()
                {
                    new Apartment { BuildingId = 1, Floor = 1, Number = 1, IdealParts = 2.66M, Inhabitants = 2, },
                    new Apartment { BuildingId = 1, Floor = 1, Number = 2, IdealParts = 8M, Inhabitants = 3, },
                    new Apartment { BuildingId = 1, Floor = 1, Number = 3, IdealParts = 6.007M, Inhabitants = 2, },
                    new Apartment { BuildingId = 1, Floor = 2, Number = 4, IdealParts = 2.66M, Inhabitants = 1, },
                    new Apartment { BuildingId = 1, Floor = 2, Number = 5, IdealParts = 8M, Inhabitants = 4, },
                    new Apartment { BuildingId = 1, Floor = 2, Number = 6, IdealParts = 6.007M, Inhabitants = 2, },
                    new Apartment { BuildingId = 1, Floor = 3, Number = 7, IdealParts = 2.66M, Inhabitants = 1, },
                    new Apartment { BuildingId = 1, Floor = 3, Number = 8, IdealParts = 8M, Inhabitants = 3, },
                    new Apartment { BuildingId = 1, Floor = 3, Number = 9, IdealParts = 6.007M, Inhabitants = 3, },
                    new Apartment { BuildingId = 1, Floor = 4, Number = 10, IdealParts = 2.66M, Inhabitants = 2, },
                    new Apartment { BuildingId = 1, Floor = 4, Number = 11, IdealParts = 8M, Inhabitants = 4, },
                    new Apartment { BuildingId = 1, Floor = 4, Number = 12, IdealParts = 6.007M, Inhabitants = 2, },
                    new Apartment { BuildingId = 1, Floor = 5, Number = 13, IdealParts = 2.66M, Inhabitants = 1, },
                    new Apartment { BuildingId = 1, Floor = 5, Number = 14, IdealParts = 8M, Inhabitants = 5, },
                    new Apartment { BuildingId = 1, Floor = 5, Number = 15, IdealParts = 6.007M, Inhabitants = 3, },
                    new Apartment { BuildingId = 1, Floor = 6, Number = 16, IdealParts = 2.66M, Inhabitants = 0, },
                    new Apartment { BuildingId = 1, Floor = 6, Number = 17, IdealParts = 8M, Inhabitants = 4, },
                    new Apartment { BuildingId = 1, Floor = 6, Number = 18, IdealParts = 6.007M, Inhabitants = 3, },

                    new Apartment { BuildingId = 2, Floor = 1, Number = 1, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 1, Number = 2, IdealParts = 2.48716M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 1, Number = 3, IdealParts = 2.48716M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 1, Number = 4, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 2, Number = 5, IdealParts = 4.655697M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 2, Number = 6, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 2, Number = 7, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 2, Number = 8, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 3, Number = 9, IdealParts = 4.655697M, Inhabitants = 4, },
                    new Apartment { BuildingId = 2, Floor = 3, Number = 10, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 3, Number = 11, IdealParts = 2.48716M, Inhabitants = 0, },
                    new Apartment { BuildingId = 2, Floor = 3, Number = 12, IdealParts = 4.655697M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 4, Number = 13, IdealParts = 4.655697M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 4, Number = 14, IdealParts = 2.48716M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 4, Number = 15, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 4, Number = 16, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 5, Number = 17, IdealParts = 4.655697M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 5, Number = 18, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 5, Number = 19, IdealParts = 2.48716M, Inhabitants = 2, },
                    new Apartment { BuildingId = 2, Floor = 5, Number = 20, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 6, Number = 21, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 6, Number = 22, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 6, Number = 23, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 6, Number = 24, IdealParts = 4.655697M, Inhabitants = 4, },
                    new Apartment { BuildingId = 2, Floor = 7, Number = 25, IdealParts = 4.655697M, Inhabitants = 3, },
                    new Apartment { BuildingId = 2, Floor = 7, Number = 26, IdealParts = 2.48716M, Inhabitants = 0, },
                    new Apartment { BuildingId = 2, Floor = 7, Number = 27, IdealParts = 2.48716M, Inhabitants = 1, },
                    new Apartment { BuildingId = 2, Floor = 7, Number = 28, IdealParts = 4.655697M, Inhabitants = 2, },

                    new Apartment { BuildingId = 3, Floor = 0, Number = 1, IdealParts = 9.96M, Inhabitants = 3, },
                    new Apartment { BuildingId = 3, Floor = 0, Number = 2, IdealParts = 8.4M, Inhabitants = 2, },
                    new Apartment { BuildingId = 3, Floor = 1, Number = 3, IdealParts = 19.04M, Inhabitants = 4, },
                    new Apartment { BuildingId = 3, Floor = 1, Number = 4, IdealParts = 10.57M, Inhabitants = 2, },
                    new Apartment { BuildingId = 3, Floor = 1, Number = 5, IdealParts = 8.09M, Inhabitants = 2, },
                    new Apartment { BuildingId = 3, Floor = 2, Number = 6, IdealParts = 8.33M, Inhabitants = 1, },
                    new Apartment { BuildingId = 3, Floor = 2, Number = 7, IdealParts = 6.86M, Inhabitants = 2, },
                    new Apartment { BuildingId = 3, Floor = 2, Number = 8, IdealParts = 4.9M, Inhabitants = 0, },
                    new Apartment { BuildingId = 3, Floor = 4, Number = 9, IdealParts = 23.85M, Inhabitants = 4, },
                    new Apartment { BuildingId = 3, Floor = 4, Number = 9, IdealParts = 23.85M, Inhabitants = 4, },

                    new Apartment { BuildingId = 4, Floor = 1, Number = 1, IdealParts = 4.469235M, Inhabitants = 3, },
                    new Apartment { BuildingId = 4, Floor = 1, Number = 2, IdealParts = 2.05528M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 1, Number = 3, IdealParts = 4.504623M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 2, Number = 4, IdealParts = 5.136402M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 2, Number = 5, IdealParts = 2.495726M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 2, Number = 6, IdealParts = 5.28395M, Inhabitants = 3, },
                    new Apartment { BuildingId = 4, Floor = 3, Number = 7, IdealParts = 5.098215M, Inhabitants = 1, },
                    new Apartment { BuildingId = 4, Floor = 3, Number = 8, IdealParts = 2.501324M, Inhabitants = 1, },
                    new Apartment { BuildingId = 4, Floor = 3, Number = 9, IdealParts = 5.278152M, Inhabitants = 3, },
                    new Apartment { BuildingId = 4, Floor = 4, Number = 10, IdealParts = 5.122007M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 4, Number = 11, IdealParts = 2.495726M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 4, Number = 12, IdealParts = 5.330934M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 5, Number = 13, IdealParts = 5.17079M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 5, Number = 14, IdealParts = 2.495726M, Inhabitants = 1, },
                    new Apartment { BuildingId = 4, Floor = 5, Number = 15, IdealParts = 5.237366M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 6, Number = 16, IdealParts = 5.149597M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 6, Number = 17, IdealParts = 2.476933M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 6, Number = 18, IdealParts = 5.243564M, Inhabitants = 4, },
                    new Apartment { BuildingId = 4, Floor = 7, Number = 19, IdealParts = 5.195781M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 7, Number = 20, IdealParts = 2.48373M, Inhabitants = 0, },
                    new Apartment { BuildingId = 4, Floor = 7, Number = 21, IdealParts = 5.375118M, Inhabitants = 3, },
                    new Apartment { BuildingId = 4, Floor = 8, Number = 22, IdealParts = 4.539811M, Inhabitants = 2, },
                    new Apartment { BuildingId = 4, Floor = 8, Number = 23, IdealParts = 2.211226M, Inhabitants = 1, },
                    new Apartment { BuildingId = 4, Floor = 8, Number = 24, IdealParts = 4.645374M, Inhabitants = 2, },

                    new Apartment { BuildingId = 5, Floor = 1, Number = 1, IdealParts = 3.2645M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 1, Number = 2, IdealParts = 2.724M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 1, Number = 3, IdealParts = 3.0531M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 1, Number = 4, IdealParts = 3.3381M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 2, Number = 5, IdealParts = 2.76M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 2, Number = 6, IdealParts = 3.2865M, Inhabitants = 3, },
                    new Apartment { BuildingId = 5, Floor = 2, Number = 7, IdealParts = 3.3761M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 2, Number = 8, IdealParts = 2.76M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 3, Number = 9, IdealParts = 3.1114M, Inhabitants = 3, },
                    new Apartment { BuildingId = 5, Floor = 3, Number = 10, IdealParts = 3.33M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 3, Number = 11, IdealParts = 2.73M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 3, Number = 12, IdealParts = 3.1114M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 4, Number = 13, IdealParts = 3.3332M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 4, Number = 14, IdealParts = 2.724M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 4, Number = 15, IdealParts = 3.1114M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 4, Number = 16, IdealParts = 3.3671M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 5, Number = 17, IdealParts = 2.76M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 5, Number = 18, IdealParts = 3.313M, Inhabitants = 4, },
                    new Apartment { BuildingId = 5, Floor = 5, Number = 19, IdealParts = 3.368M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 5, Number = 20, IdealParts = 2.8M, Inhabitants = 0, },
                    new Apartment { BuildingId = 5, Floor = 6, Number = 21, IdealParts = 3.3138M, Inhabitants = 3, },
                    new Apartment { BuildingId = 5, Floor = 6, Number = 22, IdealParts = 3.396M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 6, Number = 23, IdealParts = 2.787M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 6, Number = 24, IdealParts = 3.313M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 7, Number = 25, IdealParts = 3.39M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 7, Number = 26, IdealParts = 2.724M, Inhabitants = 4, },
                    new Apartment { BuildingId = 5, Floor = 7, Number = 27, IdealParts = 3.39M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 7, Number = 28, IdealParts = 3.33M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 8, Number = 29, IdealParts = 2.8M, Inhabitants = 3, },
                    new Apartment { BuildingId = 5, Floor = 8, Number = 30, IdealParts = 3.313M, Inhabitants = 2, },
                    new Apartment { BuildingId = 5, Floor = 8, Number = 31, IdealParts = 3.495M, Inhabitants = 1, },
                    new Apartment { BuildingId = 5, Floor = 8, Number = 32, IdealParts = 3.2724M, Inhabitants = 2, },

                    new Apartment { BuildingId = 6, Floor = 0, Number = 1, IdealParts = 6.578382M, Inhabitants = 1, },
                    new Apartment { BuildingId = 6, Floor = 1, Number = 2, IdealParts = 8.018969M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 1, Number = 3, IdealParts = 7.318361M, Inhabitants = 1, },
                    new Apartment { BuildingId = 6, Floor = 1, Number = 4, IdealParts = 7.318361M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 2, Number = 5, IdealParts = 7.318361M, Inhabitants = 1, },
                    new Apartment { BuildingId = 6, Floor = 2, Number = 6, IdealParts = 7.318361M, Inhabitants = 3, },
                    new Apartment { BuildingId = 6, Floor = 2, Number = 7, IdealParts = 7.318361M, Inhabitants = 1, },
                    new Apartment { BuildingId = 6, Floor = 3, Number = 8, IdealParts = 7.318361M, Inhabitants = 1, },
                    new Apartment { BuildingId = 6, Floor = 3, Number = 9, IdealParts = 7.318361M, Inhabitants = 3, },
                    new Apartment { BuildingId = 6, Floor = 3, Number = 10, IdealParts = 7.318361M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 4, Number = 11, IdealParts = 7.318361M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 4, Number = 12, IdealParts = 7.318361M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 4, Number = 13, IdealParts = 6.10952M, Inhabitants = 2, },
                    new Apartment { BuildingId = 6, Floor = 5, Number = 14, IdealParts = 6.10952M, Inhabitants = 1, },

                    new Apartment { BuildingId = 7, Floor = 1, Number = 1, IdealParts = 6.292446M, Inhabitants = 1, },
                    new Apartment { BuildingId = 7, Floor = 1, Number = 2, IdealParts = 6.292446M, Inhabitants = 2, },
                    new Apartment { BuildingId = 7, Floor = 1, Number = 3, IdealParts = 6.292446M, Inhabitants = 1, },
                    new Apartment { BuildingId = 7, Floor = 2, Number = 4, IdealParts = 6.292446M, Inhabitants = 2, },
                    new Apartment { BuildingId = 7, Floor = 2, Number = 5, IdealParts = 6.292446M, Inhabitants = 1, },
                    new Apartment { BuildingId = 7, Floor = 2, Number = 6, IdealParts = 5.234842M, Inhabitants = 3, },
                    new Apartment { BuildingId = 7, Floor = 3, Number = 7, IdealParts = 5.234842M, Inhabitants = 0, },
                    new Apartment { BuildingId = 7, Floor = 3, Number = 8, IdealParts = 5.234842M, Inhabitants = 1, },
                    new Apartment { BuildingId = 7, Floor = 3, Number = 9, IdealParts = 5.234842M, Inhabitants = 3, },
                    new Apartment { BuildingId = 7, Floor = 4, Number = 10, IdealParts = 5.234842M, Inhabitants = 2, },
                    new Apartment { BuildingId = 7, Floor = 4, Number = 11, IdealParts = 8.472646M, Inhabitants = 3, },
                    new Apartment { BuildingId = 7, Floor = 4, Number = 12, IdealParts = 8.472646M, Inhabitants = 2, },
                    new Apartment { BuildingId = 7, Floor = 5, Number = 13, IdealParts = 8.472646M, Inhabitants = 2, },
                    new Apartment { BuildingId = 7, Floor = 5, Number = 14, IdealParts = 8.472646M, Inhabitants = 1, },
                    new Apartment { BuildingId = 7, Floor = 5, Number = 14, IdealParts = 8.472646M, Inhabitants = 1, },

                    new Apartment { BuildingId = 8, Floor = 1, Number = 1, IdealParts = 9.6597M, Inhabitants = 1, },
                    new Apartment { BuildingId = 8, Floor = 1, Number = 2, IdealParts = 6.4828M, Inhabitants = 2, },
                    new Apartment { BuildingId = 8, Floor = 1, Number = 3, IdealParts = 8.7223M, Inhabitants = 1, },
                    new Apartment { BuildingId = 8, Floor = 2, Number = 4, IdealParts = 8.873M, Inhabitants = 2, },
                    new Apartment { BuildingId = 8, Floor = 2, Number = 5, IdealParts = 10.865M, Inhabitants = 3, },
                    new Apartment { BuildingId = 8, Floor = 2, Number = 6, IdealParts = 6.4806M, Inhabitants = 2, },
                    new Apartment { BuildingId = 8, Floor = 3, Number = 7, IdealParts = 9.965M, Inhabitants = 0, },
                    new Apartment { BuildingId = 8, Floor = 3, Number = 8, IdealParts = 7.8638M, Inhabitants = 1, },
                    new Apartment { BuildingId = 8, Floor = 3, Number = 9, IdealParts = 9.9904M, Inhabitants = 3, },
                    new Apartment { BuildingId = 8, Floor = 4, Number = 10, IdealParts = 7.1495M, Inhabitants = 2, },
                    new Apartment { BuildingId = 8, Floor = 4, Number = 11, IdealParts = 6.8423M, Inhabitants = 2, },
                    new Apartment { BuildingId = 8, Floor = 4, Number = 12, IdealParts = 3.9109M, Inhabitants = 2, },

                    new Apartment { BuildingId = 9, Floor = 1, Number = 1, IdealParts = 14.42953M, Inhabitants = 1, },
                    new Apartment { BuildingId = 9, Floor = 1, Number = 2, IdealParts = 17.44966M, Inhabitants = 2, },
                    new Apartment { BuildingId = 9, Floor = 2, Number = 3, IdealParts = 14.42953M, Inhabitants = 1, },
                    new Apartment { BuildingId = 9, Floor = 2, Number = 4, IdealParts = 15.77181M, Inhabitants = 2, },
                    new Apartment { BuildingId = 9, Floor = 3, Number = 5, IdealParts = 17.44966M, Inhabitants = 3, },
                    new Apartment { BuildingId = 9, Floor = 3, Number = 6, IdealParts = 20.4698M, Inhabitants = 2, },
                };

            apartments = apartments.Reverse<Apartment>().ToList();

            foreach (var apartment in apartments)
            {
                await dbContext.AddAsync(apartment);
            }
        }
    }
}

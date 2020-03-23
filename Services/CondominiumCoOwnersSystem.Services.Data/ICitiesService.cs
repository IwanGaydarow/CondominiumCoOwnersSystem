namespace CondominiumCoOwnersSystem.Services.Data
{
    using System.Collections.Generic;

    public interface ICitiesService
    {
        IEnumerable<T> AllCities<T>();
    }
}

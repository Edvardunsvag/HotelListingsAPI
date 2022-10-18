using HotelListing.API.Interfaces;
using HotelListingAPI.data;

namespace HotelListing.API.Interfaces
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);

    }
}
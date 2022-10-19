using System;
using HotelListing.API.Interfaces;
using HotelListingAPI.data;
using HotelListingAPI.Interfaces;

namespace HotelListingAPI.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}


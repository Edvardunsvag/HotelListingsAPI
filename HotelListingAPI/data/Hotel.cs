using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.data
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Address { get; set; } = String.Empty;

        public double Rating { get; set; }



        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country? Country { get; set; }



    }
}


﻿using System;
using AutoMapper;
using HotelListingAPI.data;
using HotelListingAPI.Models.Country;
using HotelListingAPI.Models.Hotel;

namespace HotelListingAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();


        }

    }
}

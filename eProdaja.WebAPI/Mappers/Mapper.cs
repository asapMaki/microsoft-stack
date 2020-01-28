using System;
using AutoMapper;
using eProdaja.Model.Requests;

namespace eProdaja.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Databases.Korisnici, Model.Korisnici>();
            CreateMap<Databases.Korisnici, KorisniciInsertRequest>().ReverseMap();
        }
    }
}

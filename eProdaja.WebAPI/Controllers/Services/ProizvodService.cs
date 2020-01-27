using System;
using System.Collections.Generic;
using eProdaja.Model;

namespace eProdaja.WebAPI.Controllers.Services
{
    public class ProizvodService : IProizvodService
    {
        public ProizvodService()
        {
        }

        public IList<Proizvod> Get()
        {
            var list = new List<Proizvod>()
            {
                new Proizvod() {
                    ProizvodID = 1,
                    Naziv = "Laptop"
                },
                new Proizvod() {
                    ProizvodID = 2,
                    Naziv = "Monitor"
                }
            };
            return list;
            //throw new NotImplementedException();
        }

        public Proizvod Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using eProdaja.Model;

namespace eProdaja.WebAPI.Controllers.Services
{
    public interface IProizvodService
    {
        IList<Proizvod> Get();
        Proizvod Get(int id);
    }
}

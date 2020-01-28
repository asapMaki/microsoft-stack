using System;
using System.Collections.Generic;
using eProdaja.Model;
using eProdaja.Model.Requests;

namespace eProdaja.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Korisnici> Get();
        Korisnici Insert(KorisniciInsertRequest korisniciInsertRequest);
    }
}

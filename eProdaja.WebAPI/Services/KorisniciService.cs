using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Databases;

namespace eProdaja.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eProdaja2Context _context;
        private readonly IMapper _mapper;
        public KorisniciService(eProdaja2Context context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get()
        {
            var list = _context.Korisnici.ToList();
            
            return _mapper.Map<List<Model.Korisnici>>(list); 
        }

        public Model.Korisnici Insert(KorisniciInsertRequest korisniciInsertRequest)
        {
            var entity = _mapper.Map<Databases.Korisnici>(korisniciInsertRequest);

            if (korisniciInsertRequest.Password != korisniciInsertRequest.PasswordConfirmation)
                throw new Exception("Passwordi se ne slazu");

            entity.LozinkaHash = "test";
            entity.LozinkaSalt = "test1";

            _context.Korisnici.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}

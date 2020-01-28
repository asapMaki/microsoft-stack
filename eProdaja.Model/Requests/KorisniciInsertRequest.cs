using System;
using System.ComponentModel.DataAnnotations;

namespace eProdaja.Model.Requests
{
    public class KorisniciInsertRequest
    {
        public int KorisnikId { get; set; }
        [MinLength(3)]
        public string Ime { get; set; }
        [MinLength(3)]
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }

        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}

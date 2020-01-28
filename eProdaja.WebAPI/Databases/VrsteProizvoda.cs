using System;
using System.Collections.Generic;

namespace eProdaja.WebAPI.Databases
{
    public partial class VrsteProizvoda
    {
        public VrsteProizvoda()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int VrstaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}

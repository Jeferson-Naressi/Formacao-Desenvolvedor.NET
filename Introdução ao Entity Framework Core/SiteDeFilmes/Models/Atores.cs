using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class Atores
    {
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public string Geneno { get; set;}

        public ICollection<ElencoFilme> ElencoFilmes{ get; set; }

    }
}
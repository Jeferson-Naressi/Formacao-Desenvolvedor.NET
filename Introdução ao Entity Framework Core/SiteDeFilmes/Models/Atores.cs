using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class Atores
    {
        [Key]
        public int Id { get; set; }

        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }

        public string Genero { get; set;}

        public ICollection<ElencoFilmes> ElencoFilmes{ get; set; }

    }
}
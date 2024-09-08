using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set;} 
        public string Nome { get; set;}
        public int Ano { get; set;}
        public int Duracao { get; set;}
        public ICollection<ElencoFilme> ElencoFilmes{ get; set; }

        public ICollection<FilmesGenero> FilmesGeneros{ get; set; }


    }
}
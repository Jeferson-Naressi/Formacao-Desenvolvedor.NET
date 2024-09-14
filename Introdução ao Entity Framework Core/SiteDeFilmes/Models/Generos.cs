using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class Generos
    {
        public int Id { get; set; } 

        public string Genero { get; set; }

        public ICollection<FilmesGeneros> FilmesGeneros{ get; set; }

    }
}
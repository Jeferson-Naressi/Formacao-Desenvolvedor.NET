using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class FilmesGenero
    {
        public int Id { get; set; }

        public int IdGenero { get; set; }

        public Generos Genero{ get; set; }

        public int IdFilmes { get; set; }

        public Filmes Filmes { get; set; }

    }
}
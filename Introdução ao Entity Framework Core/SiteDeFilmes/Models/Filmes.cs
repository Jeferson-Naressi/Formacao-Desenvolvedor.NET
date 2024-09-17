using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteDeFilmes.Models
{
    public class Filmes
    {
        [Key]
        public int Id { get; set;} 
        public string Nome { get; set;}
        public int Ano { get; set;}
        public int Duracao { get; set;}
        public ICollection<ElencoFilmes> ElencoFilmes{ get; set; }

        public ICollection<FilmesGeneros> FilmesGeneros{ get; set; }


    }
}
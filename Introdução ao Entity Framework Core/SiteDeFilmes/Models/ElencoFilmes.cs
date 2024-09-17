using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Identity.Client;


namespace SiteDeFilmes.Models
{
    public class ElencoFilmes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IdAtor { get; set; }
        
        public Atores Atores { get; set; }
        
        public int IdFilmes { get; set; }

        
        public Filmes Filme{ get; set; } 

        public string Papel { get; set; } 

    }
}
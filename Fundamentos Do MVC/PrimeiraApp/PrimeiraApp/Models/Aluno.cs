// Para obter as DataAnnotations precisa importar a biblioteca;
// Expressões regulares
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraApp.Models
{
    public class Aluno
    {
        [Key] // Chave para o banco de dados
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} precisa ter entre {1} e {2} caracteres")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "O campo {0} precisa ter entre {1} e {2} caracteres")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$",ErrorMessage = "O campo {0} está em formato inválido")]
        //[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são indenticos")]
        [NotMapped] //Não mapeie esse campo, isso para o banco de dados
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(1,5, ErrorMessage = " O campo {0} Deve estar entre {1} e {2}")]
        public int Avaliacao { get; set; }

        public bool Ativo {  get; set; }

    }
}

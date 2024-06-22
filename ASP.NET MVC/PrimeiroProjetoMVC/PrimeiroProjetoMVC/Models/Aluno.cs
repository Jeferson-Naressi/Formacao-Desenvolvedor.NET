using System.ComponentModel.DataAnnotations;

namespace PrimeiroProjetoMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
/// Criamos na pasta model um objeto Aluno, com suas propriedades para o banco de dados
/// Após isso vamos na pasta controlles Add, New Scanffolded item, vamos adicionar nossa RM de banco de dados, selecionar nossa classe aluno.
/// Logo em seguida será criado nossa controller de aluno, vamos em console de gerenciador de pacotes e adicionar nossa migration
/// PM> add-migration Aluno  //e depois vamos atualizar as inforamações PM> update-data base

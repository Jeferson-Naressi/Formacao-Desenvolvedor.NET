//Console.WriteLine("Primeiro programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            //AulaClasses();
            //AulaPropriedadeSomenteLeitura();
            //AulaHeranca();
            //AulaClasseSelada();
            //AulaClasseAbstrata(); 
            //AulaRecord();
            //AulaInterface();
            //Conversores();
            //TrabalhandoComStrings();
            //TrabalhandoComDatas();
            //TrabalhandoComExcecoes();
            //TrabalhandoComArquivos();
            TrabalhandoComLinq();
        }  


        private static void TrabalhandoComLinq()
         {
              var linq = new Modulo14.TrabalhandoComLinq();
              //linq.AulaWhere();
              //linq.AulaOrdenacao();
              //linq.AulaTake();
              //linq.AulaCount();
              linq.AulaFirstEFirstOrDefault();
         }

         private static void TrabalhandoComArquivos()
         {
                var trabalhandoComArquivos = new Modulo13.TrabalhandoComArquivos();
                //trabalhandoComArquivos.AulaCriandoArquivo();
                //trabalhandoComArquivos.AulaLendoArquivo();
                trabalhandoComArquivos.AulaExcluindoArquivo();
         }

         private static void TrabalhandoComExcecoes()
         {
                var trabalhandoComExcecoes = new Modulo12.TrabalhandoComExcecoes();
                //trabalhandoComExcecoes.AulaGerandoException();
                trabalhandoComExcecoes.AulaTratandoException();
         }

        private static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new Modulo11.TrabalhandoComDatas();
            //trabalhandoComDatas.AulaDateTime();
            //trabalhandoComDatas.AulaSubtraindoDatas();
            //trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            //trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            //trabalhandoComDatas.AulaDiaDaSemana();
            //trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterParaLetrasMinusculas();
            //trabalhandoComStrings.AulaSubstring();
            ///trabalhandoComStrings.AulaRange();
            //trabalhandoComStrings.AulaContains();
            //trabalhandoComStrings.AulaTrim();
            //trabalhandoComStrings.AulaStartWithEndsWith();
            //trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
           // conversores.ConvertAndParse();
           conversores.AulaTryParse();
        }

         private static void AulaInterface()
         {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
            
         }

         private static void AulaRecord()
         {
            //var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};
            //var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso"};

            var curso1 = new Cadastro.Curso (1,"Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo"}; 

            //var curso1 = new Cadastro.CursoTeste  { Id = 1, Descricao = "Curso"};
            //var curso2 = curso1;
            //curso2.Descricao = "TESTE TESTE";
            //var curso2 = new Cadastro.CursoTeste(); 
            //curso2.Id = curso1.Id;
            //curso2.Descricao = "Nova descricao";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
            //Console.WriteLine(curso1.Equals(curso2));
            //Console.WriteLine(curso1 == curso2);
         }

         private static void AulaClasseAbstrata()
         {
             var cachorro = new Cadastro.Cachorro(); 
             cachorro.Nome = "Dog"; 
             cachorro.ImprimirDados();
         }

         private static void AulaClasseSelada()
         {
               /*var configuracao = new Cadastro.Configuracao();
               configuracao.Host = "localhost";
               */
               var configuracao = new Cadastro.Configuracao
               {
                  Host = "localhost"
               };

               Console.WriteLine(configuracao.Host);

         }

         private static void AulaHeranca()
         {
            /*var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.Id = 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Cidade Teste";
            pessoaFisica.Cep = "12345612";
            pessoaFisica.CPF = "12345678912";
            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCpf();
            */

            var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "General Syzeno";
            funcionario.Cidade = "Sao paulo";
            funcionario.Cep = "05366220";
            funcionario.CPF = "12345678912";
            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
         }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2,3);
            Console.WriteLine(resultado);
            /*
            var produto = new Cadastro.Produto();
            produto.SetId(1);   
            
            produto.Descricao = "Teclado";

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            */
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
      
            var produto = new Cadastro.Produto();
            produto.Descricao = "teclado";
            //produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);

        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {
    }

    public class Funcionario
    {
    } 
}


namespace Financeiro
{
    public class ContasReceber
    {
    }

    public class Funcionario
    {
    }
}*/
/*Console.WriteLine("Primeiro programa");

int idade = 30;
Console.WriteLine(idade);
string nomePessoa = "Jeferson Naressi";
Console.WriteLine(nomePessoa);
decimal valor = 200.99m;
double valorDouble = 200.99;
float valorFloat = 200.99f;
Console.WriteLine(valor);
Console.WriteLine(valorDouble);
Console.WriteLine(valorFloat);
var idadeNova = 25;
char flag = 'Y';
Console.WriteLine(flag);
bool ativo = true;
ativo = false;
Console.WriteLine(ativo);


const string descricao = "Curso CSHARP";


Console.WriteLine(descricao);
*/


/*
int soma = numero1 + numero2;
Console.WriteLine(soma);

int subtracao = numero2 - numero1;
Console.WriteLine(subtracao);

int multiplicacao = (numero2 * numero1) * 10;
Console.WriteLine(multiplicacao);

int divisao = numero2 / numero1;
Console.WriteLine(divisao);
*/

/*
int numero1 = 1;
var numero2 = 2;

bool igual = numero1 == numero2;
Console.WriteLine(igual);


bool maior = numero2 > numero1;
Console.WriteLine(maior);

bool menor = numero2 < numero1;
Console.WriteLine(menor);

bool menorOuIgual = numero2 <= numero1;
Console.WriteLine(menorOuIgual);

bool maiorOuIgual = numero2 >= numero1;
Console.WriteLine(maiorOuIgual);

bool diferente = numero2 != numero1;
Console.WriteLine(diferente);
 */

//int numero1 = 1;
//var numero2 = 2;

/*bool valido = numero2 > numero1 && 6 > 7;
Console.WriteLine(valido);


bool valido2 = numero2 > 10 || 6 > 7;
Console.WriteLine(valido2);

bool valido3 = !(numero2 > 3);
Console.WriteLine(valido3);
*/
/*
bool ativo = false;
string status = ativo ? "Cadastro Ativo" : "Cadastro inativo";
Console.WriteLine(status);
*/

/*
EscreverNome();


void EscreverNome()
{
   var nome = NomeCompleto();
   var soma = SomaValores();

   Console.WriteLine(nome);
   Console.WriteLine(soma);
}

string NomeCompleto()
{
   string primeiroNome = "Jeferson";
   string segundoNome = "Naressi";

   return primeiroNome + " " + segundoNome;
}

int SomaValores()
{
   return 8 + 2;
}
*/

/*
var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Rafael", 33);
Console.WriteLine(nome);

int SomaValores(int a, int b)
{
   return a + b;
}

string NomeEIdade(string nome, int idade)
{
   return "Meu nome é " + nome + " e tenho " + idade + " anos";
}
*/

using System.Collections;
/*
var arrayList = new ArrayList();
arrayList.Add(1); // 0
arrayList.Add("Rafael"); //1
arrayList.Add(true); // 2

//Console.WriteLine(arrayList[1]); // acesso por indice

arrayList.RemoveAt(1);

//arrayList =new ArrayList();
arrayList.Clear();

foreach(var item in arrayList)
{
   Console.WriteLine(item);
}*/
/*
//var arrayTipadoNumero = new int[3] {1, 2, 3};
var arrayTipadoNumero = new int[3];
arrayTipadoNumero[0] = 5;
arrayTipadoNumero[1] = 5;
arrayTipadoNumero[2] = 10;

//Array.Resize(ref arrayTipadoNumero, 100);
//arrayTipadoNumero[10] = 100;

foreach(var item in arrayTipadoNumero)
{
   Console.WriteLine(item);
}


//var arrayTipadoString = new string[2] {"Jeferson", "Naressi"};
var arrayTipadoString = new string[2];
arrayTipadoString[0] = "Jeferson";
arrayTipadoString[1] = "Naressi";

foreach(var item in arrayTipadoString)
{
   Console.WriteLine(item);
}
*/

/*
var lista = new List<string>(10)
{
   "Jeferson",
   "Naressi",
};
*/
/*lista.Add("Jeferson");
lista.Add("Naressi");
lista.Add("Curso");
*/
/*
var nome = lista[0];
Console.WriteLine(nome);

lista.RemoveAt(1);

foreach(var item in lista)
{
   Console.WriteLine(item);
}
*/

/*
var dicionario = new Dictionary<string, string>()
{
   {"teste", "Teste"},
   {"teste6", "Teste 6"},
};

dicionario.Add("nome", "Jeferson");

dicionario["curso"] = "Curso";

var nome = dicionario["curso"];
//Console.WriteLine(nome);

foreach(var item in dicionario)
{
   Console.WriteLine(item.Value);
} */

/*
var queue = new Queue<string>();
queue.Enqueue("Jeferson");
queue.Enqueue("Naressi");

//var nome = queue.Peek();
//var nome1 = queue.Peek();

var nome = queue.Dequeue(); // Primeira execucao
var nome1 = queue.Dequeue(); // Segunda execucao

Console.WriteLine(nome);
Console.WriteLine(nome1);
*/


/*
foreach(var item in queue)
{
   Console.WriteLine(item);
} 
*/

/*
var stack = new Stack<string>();
stack.Push("Jeferson");
stack.Push("Naressi");

var nome = stack.Pop();
var nome1 = stack.Pop();
Console.WriteLine(nome);
Console.WriteLine(nome1);
*/
/*
foreach(var item in stack)
{
   Console.WriteLine(item);
}
*/

// MODULO 7 - Aula 1

/*
var diaDaSemana = 0;
var diaDeTrabalho = false;

if(diaDaSemana == 0 && diaDeTrabalho == true)
{
   Console.WriteLine("Hoje é domingo");
}
else if(diaDaSemana == 0 && diaDeTrabalho == false)
{
   Console.WriteLine("Hoje é domingo, mas nao é dia de trabalho");
}
else
{
   Console.WriteLine("Hoje não é domingo");
}
*/
/*
var diaDaSemana = 10;
if(diaDaSemana == 0)
{
   Console.WriteLine("Hoje é domingo");
}
else if(diaDaSemana == 1)
{
   Console.WriteLine("Hoje é Segunda");
}
else if(diaDaSemana == 2)
{
   Console.WriteLine("Hoje é Terça");
}
else if(diaDaSemana == 3)
{
   Console.WriteLine("Hoje é Quarta");
}
else if(diaDaSemana == 4)
{
   Console.WriteLine("Hoje é Quinta");
}
else if(diaDaSemana == 5)
{
   Console.WriteLine("Hoje é Sexta");
}
else if(diaDaSemana == 6)
{
   Console.WriteLine("Hoje é Sábado");
}
else
{
   Console.WriteLine("Dia da semana inválido");
}
*/

// MODULO 7 - Aula 2
/*
var diaDaSemana = 3;
switch(diaDaSemana)
{
   case 0:
   {
      Console.WriteLine("Hoje é domingo");
      break;
   }
   case 1:
      Console.WriteLine("Hoje é segunda");
      break;
   case 2:
      Console.WriteLine("Hoje é terça");
      break;
   case 3:
      Console.WriteLine("Hoje é quarta");
      break;
   case 4:
      Console.WriteLine("Hoje é quinta");
      break;
   case 5:
      Console.WriteLine("Hoje é sexta");
      break;
   case 6:
      Console.WriteLine("Hoje é sábado");
      break;   
   default:      
      Console.WriteLine("Dia da semana inválido");      
      break;
}*/

/*
var diaDaSemana = 0;
if(diaDaSemana < 1)
{
      Console.WriteLine("Hoje é domingo");
}
else
{
     Console.WriteLine("Dia da semana inválido");      
}
*/

// MODULO 7 - Aula 3
/*var lista = new List<string>() { "Jeferson", "Curso", "Csharp"};
var count = lista.Count;

for(var i=0; i < count; i++)
{
   var nome = lista[i];

   Console.WriteLine(nome);
}*/


// MODULO 7 - Aula 4
//var lista = new List<string>() { "Jeferson", "Curso", "Csharp"};

/*
foreach(string item in lista)
{
   Console.WriteLine(item);
}
*/
/*
foreach(var letra in "Jeferson Naressi")
{
   Console.WriteLine(letra);
}*/

// MODULO 7 - Aula 5
/*
var i = 0;
while(i < 2)
{
   Console.WriteLine("var i = " + i);
   //i += 1;
   i++;
}

var j = 0;
do 
{
   Console.WriteLine("var j = " + j);
   j++;
} while (j < 2);
*/

// MODULO 7 - Aula 6
/*
var i = 0;
while(i < 5)
{

   if(i < 2)
   {
      Console.WriteLine("Continuando...");
      i++;
      continue;
   }

   Console.WriteLine("var i = " + i);
   i++;

   if(i == 2)
   {
      Console.WriteLine("Valor de i é igual a 2 (dois)");
      break;
   }
}*/
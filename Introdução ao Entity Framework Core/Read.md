# 1: Título
## Sistema de Gerenciamento de Filmes

<i>Uma solução completa para cadastro e consulta de filmes, atores e gêneros.</i>

# 2: Objetivos do Sistema
<li><b>Gerenciar</b> informações sobre filmes, atores e gêneros.</li>

<li><b>Facilitar</b> o acesso a dados relacionados.</li>

<li><b>Implementar</b> um repositório genérico para operações de CRUD.</li>

# 3: Estrutura do Banco de Dados

<li><b>Filmes</b></li>
<ul>ID, Nome, Ano, Duração</ul>

<li><b>Atores</b></li>
<ul>ID, Primeiro Nome, Último Nome, Gênero</ul>

<li><b>Gêneros</b></li>
<ul>ID, Nome do Gênero</ul>

<li><b>Elenco de Filmes</b></li>
<ul>ID, ID do Ator, ID do Filme, Papel</ul>

<li><b>Filmes e Gêneros</b></li>
<ul>ID, ID do Filme, ID do Gênero</ul>

# 4: Repositório Genérico
<li><b>Operações de CRUD:</b></li>
<ul>Adicionar, Consultar, Atualizar, Deletar</ul>

<li><b>Flexibilidade:</b></li>
<ul>Pode ser usado para qualquer entidade do sistema.</ul>

<li><b>Implementação:</b></li>
<ul>Uso do Entity Framework para interação com o banco de dados.</ul>

# 5: Funcionalidades Principais

1. <b>Adicionar Atores:</b>
<ul>Cadastro de novos atores no sistema.</ul>

2. <b>Consultar Atores:</b>
<ul>Listagem de todos os atores cadastrados.</ul>

3. <b>Adicionar Filmes:</b>
<ul>Cadastro de novos filmes.</ul>

4. <b>Consultar Filmes:</b>
<ul>Listagem de todos os filmes cadastrados.</ul>

5. <b>Gerenciar Gêneros e Elencos:</b>
<ul>Adição e consulta de gêneros e elencos.</ul>

# 6: Exemplo de Uso

### Exemplo de Uso
- **Adicionar Atores**:
  ```csharp
  private static void AdicionarAtor() {
      using var repo = new RepositorioGenerico<Atores>();
      var novoAtor = new Atores { ... };
      repo.Adicionar(novoAtor);
      Console.WriteLine("Ator adicionado com sucesso!");
  }

# 7: Conclusão

<b><li>Sistema Funcional:</b> Permite gerenciar eficientemente dados sobre filmes e atores.</li>

<b><li>Escalabilidade:</b> Pode ser expandido para incluir mais funcionalidades.</li>

<b><li>Próximos Passos:</b> Implementar interface gráfica ou API para interação.</li>

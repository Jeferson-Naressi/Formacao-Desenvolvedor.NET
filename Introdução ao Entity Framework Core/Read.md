Apresentação: Modelo de Dados do Sistema de Filmes

1. Introdução
Objetivo: Apresentar o modelo de dados para o sistema de gerenciamento de filmes.
Tecnologia: Utilizando Entity Framework Core para o mapeamento objeto-relacional (ORM) e SQL para a definição das tabelas.

2. Entidades e Relacionamentos

2.1 Entidades
Atores
Descrição: Representa os atores no sistema.
Propriedades:
Id: Identificador único do ator.
PrimeiroNome: Primeiro nome do ator.
UltimoNome: Último nome do ator.
Genero: Gênero do ator.
Filmes

Descrição: Representa os filmes disponíveis.
Propriedades:
Id: Identificador único do filme.
Nome: Nome do filme.
Ano: Ano de lançamento do filme.
Duracao: Duração do filme em minutos.
ElencoFilmes

Descrição: Representa a relação entre atores e filmes.
Propriedades:
Id: Identificador único da relação.
IdAtor: Chave estrangeira referenciando o ator.
IdFilmes: Chave estrangeira referenciando o filme.
FilmesGenero

Descrição: Representa a relação entre filmes e gêneros.
Propriedades:
Id: Identificador único da relação.
IdGenero: Chave estrangeira referenciando o gênero.
IdFilmes: Chave estrangeira referenciando o filme.
Generos

Descrição: Representa os gêneros de filmes.
Propriedades:
Id: Identificador único do gênero.
Genero: Nome do gênero.

3. Relacionamentos

3.1 Atores e ElencoFilmes
Relação: Um para Muitos.
Descrição: Um ator pode estar em vários filmes, enquanto cada filme pode ter vários atores.

3.2 Filmes e ElencoFilmes
Relação: Um para Muitos.
Descrição: Um filme pode ter vários atores, e cada ator pode estar em vários filmes.

3.3 Generos e FilmesGenero
Relação: Um para Muitos.
Descrição: Um gênero pode ser associado a vários filmes, e cada filme pode ter vários gêneros.

3.4 Filmes e FilmesGenero
Relação: Um para Muitos.
Descrição: Um filme pode ter vários gêneros, e um gênero pode ser associado a vários filmes.

5. Diagramas

5.1 Diagrama de Entidades
Atores —1
— ElencoFilmes —N:1— Filmes

Filmes —1
— ElencoFilmes

Generos —1
— FilmesGenero —N:1— Filmes

6. Conclusão
Resumo: O modelo de dados permite a gestão eficiente de atores, filmes e gêneros, estabelecendo relações claras entre eles.
Próximos Passos: Implementar as configurações no código e criar as tabelas no banco de dados. Validar o modelo com testes e ajustar conforme necessário.
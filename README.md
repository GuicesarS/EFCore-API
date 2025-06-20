# Fusca Filmes API

Este repositório contém uma API desenvolvida em .NET 8 utilizando Entity Framework Core e Minimal API, com arquitetura em camadas. Este projeto foi criado como base de estudo, com foco em entender na prática como estruturar uma API REST, trabalhar com banco de dados relacional, relações entre entidades e boas práticas no desenvolvimento.

## Qual é a proposta desse projeto?

Embora seja um projeto de estudo, ele foi pensado para simular uma aplicação real, com funcionalidades úteis e que podem ser facilmente adaptadas para outras necessidades.

Através desse projeto, é possível:

- Praticar e entender na prática o uso do Entity Framework Core.
- Explorar como funciona a criação de APIs RESTful com .NET.
- Implementar consultas, filtros e relacionamento entre entidades.
- Aprender sobre organização de projetos em camadas.

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

1. **API**  
Descrição: Contém os endpoints da aplicação, configurações gerais, documentação Swagger e o arquivo Program.cs.  
Objetivo: Gerenciar as rotas e configurações da API.

2. **Domínio**  
Descrição: Contém as entidades do sistema, como Filme, Diretor e DiretorFilme (tabela de relacionamento N:N).  
Objetivo: Definir a estrutura dos dados.

3. **Repositório**  
Descrição: Contém o DbContext, Migrations, Interfaces e Implementações dos Repositórios.  
Objetivo: Gerenciar o acesso ao banco de dados, migrations e regras de persistência.

## Funcionalidades

- **Diretores**  
  - Criar, editar, listar (todos ou por ID) e excluir.

- **Filmes**  
  - Criar, editar, listar (todos, por ID ou por título), atualizar parcialmente (PATCH) e excluir.

- **Relacionamento N:N**  
  - Gerenciamento da relação entre Filmes e Diretores.

- **Consultas otimizadas**  
  - Filtros por título (`Contains`) e métodos assíncronos.

## Como Usar
1. **Clone o repositório**:
   ```bash
   git clone https://github.com/GuicesarS/FuscaFilmesAPI.git

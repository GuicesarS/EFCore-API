# 🎬 Fusca Filmes API

Este repositório contém uma API desenvolvida com **.NET 8**, utilizando **Entity Framework Core** e **Minimal APIs**, com uma arquitetura em camadas.  
Este projeto foi criado como base de estudo, com o objetivo de entender na prática como estruturar uma API REST, trabalhar com bancos de dados relacionais, gerenciar relacionamentos entre entidades e aplicar boas práticas de desenvolvimento.

---

## 🎯 Propósito do Projeto

Apesar de ser um projeto de estudo, ele foi pensado para simular uma aplicação real, com funcionalidades úteis que podem ser facilmente adaptadas para outros cenários.

Com este projeto, é possível:

- Praticar e entender o uso do **Entity Framework Core** em cenários reais  
- Explorar como criar **APIs RESTful com .NET**  
- Implementar consultas, filtros e relacionamentos entre entidades  
- Aprender sobre **organização de projetos em camadas**  

---

## 🧱 Estrutura do Projeto

O projeto está organizado da seguinte forma:

1. **API**  
   **Descrição**: Contém os endpoints da aplicação, configurações gerais, documentação Swagger e o arquivo `Program.cs`.  
   **Objetivo**: Gerenciar as rotas e configurações gerais da API.

2. **Domínio**  
   **Descrição**: Contém as entidades do sistema, como `Filme`, `Diretor` e `DiretorFilme` (tabela de relacionamento N:N).  
   **Objetivo**: Definir a estrutura dos dados.

3. **Repositório**  
   **Descrição**: Contém o `DbContext`, Migrations, Interfaces e Implementações dos Repositórios.  
   **Objetivo**: Gerenciar o acesso aos dados, migrations e regras de persistência.

---

## ⚙️ Funcionalidades

- **Diretores**  
  - Criar, editar, listar (todos ou por ID) e excluir.

- **Filmes**  
  - Criar, editar, listar (todos, por ID ou por título), atualizar parcialmente (PATCH) e excluir.

- **Relacionamento N:N**  
  - Gerenciar a relação entre Filmes e Diretores.

- **Consultas Otimizadas**  
  - Filtros por título com `Contains` e métodos assíncronos.

---

## 💻 Como Usar

1. **Clone o repositório**:
```bash
git clone https://github.com/GuicesarS/EFCore-API.git
````

---

📄 Disponível em: [Inglês](README.md) 

```

Se quiser que eu já te envie os dois arquivos prontos para colar no GitHub (em `.md`), é só me avisar.
```

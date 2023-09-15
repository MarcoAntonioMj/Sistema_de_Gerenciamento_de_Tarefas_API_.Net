# Sistema de Gerenciamento de Tarefas

Este é um Sistema de Gerenciamento de Tarefas simples desenvolvido em C# usando ASP.NET Core.

## Descrição

Este projeto é uma aplicação de exemplo de um Sistema de Gerenciamento de Tarefas. Ele permite que os usuários criem, visualizem, atualizem e excluam tarefas. Cada tarefa possui um título, descrição, data de vencimento e status (concluída ou pendente).

## Recursos

- Cadastro de usuários
- Autenticação de usuários
- Gerenciamento de tarefas
- Listagem de tarefas pendentes ou concluídas
- Filtros e ordenação de tarefas
- Documentação da API (usando Swagger)

## Tecnologias Utilizadas

- C# / ASP.NET Core
- Banco de Dados SQL (SQL Server, PostgreSQL, etc.)
- Entity Framework Core
- Autenticação JWT (JSON Web Tokens)
- Swagger para documentação da API

## Pré-requisitos

- .NET SDK (versão X.XX)
- Banco de Dados SQL (instância local ou remota)
- IDE (Visual Studio Code, Visual Studio, etc.)

## Configuração do Banco de Dados

1. Clone o repositório: `git clone https://github.com/seu-usuario/seu-projeto.git`
2. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.
3. Execute as migrações para criar o esquema do banco de dados: `dotnet ef database update`.

## Execução do Projeto

1. Navegue até a pasta do projeto no terminal.
2. Execute o comando: `dotnet run`.

## Documentação da API

Acesse a documentação da API em: `http://localhost:5000/swagger`

## Contribuição

Sinta-se à vontade para contribuir para este projeto aberto. Você pode abrir issues, propor melhorias ou enviar pull requests.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

---

Feito c por [ Marco Antônio- contato : marcotonho38@gmail.com


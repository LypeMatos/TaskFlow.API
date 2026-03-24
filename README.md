# 📌 TaskFlow API

API REST para gerenciamento de tarefas, desenvolvida com ASP.NET Core (.NET 8), utilizando Entity Framework Core e SQL Server.

## 🚀 Tecnologias utilizadas

- C#
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger

## 📂 Estrutura do projeto

- Controllers → Camada de entrada da API
- Services → Regras de negócio
- Data → Contexto do banco de dados
- Models → Entidades do sistema
- DTOs → Objetos de transferência de dados

## ⚙️ Funcionalidades

- Criar tarefa
- Listar tarefas
- Buscar tarefa por ID
- Atualizar tarefa
- Deletar tarefa
- Marcar tarefa como concluída

## 🔗 Endpoints

| Método | Rota | Descrição |
|------|------|----------|
| POST | /api/tasks | Criar tarefa |
| GET | /api/tasks | Listar tarefas |
| GET | /api/tasks/{id} | Buscar por ID |
| PUT | /api/tasks/{id} | Atualizar tarefa |
| DELETE | /api/tasks/{id} | Remover tarefa |
| PATCH | /api/tasks/{id}/complete | Marcar como concluída |

## 🧪 Como executar o projeto

```bash
# Clonar o repositório
git clone https://github.com/seu-usuario/taskflow.api.git

# Entrar na pasta
cd taskflow.api

# Restaurar dependências
dotnet restore

# Rodar a aplicação
dotnet run
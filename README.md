# 📍 Mapeamento Inteligente do Pátio - Mottu

Este projeto foi desenvolvido como parte do CP2 da disciplina **Advanced Business Development with .NET** (FIAP - 2025), com o objetivo de entregar uma API funcional baseada nos princípios de **Clean Architecture** e **Domain-Driven Design (DDD)**.

## 🎯 Objetivo

Desenvolver uma API RESTful para realizar o mapeamento e a gestão de motos nos pátios das filiais da empresa **Mottu**, permitindo o cadastro, atualização e visualização da localização e status de motos em tempo real.

---

## 🧱 Arquitetura do Projeto

O projeto está dividido em quatro camadas:

- **Domain**: Contém as entidades e regras de negócio
- **Application**: Interfaces, DTOs e serviços
- **Infrastructure**: Banco de dados e persistência com EF Core
- **API (Presentation)**: Camada de exposição da aplicação (Controllers, Swagger)

---

## 🗂️ Estrutura de Pastas

```
CP2/
├── MapeamentoInteligentePatio.Domain/
├── MapeamentoInteligentePatio.Application/
├── MapeamentoInteligentePatio.Infrastructure/
└── MapeamentoInteligentePatio.API/
```

---

## 🧪 Funcionalidades da API

### 📦 Motos (`/api/moto`)
- `GET /api/moto` – Listar todas as motos
- `GET /api/moto/{id}` – Detalhar moto por ID
- `POST /api/moto` – Criar nova moto
- `PUT /api/moto/{id}` – Atualizar moto existente
- `DELETE /api/moto/{id}` – Remover moto

### 🏢 Filiais (`/api/filial`)
- `GET /api/filial` – Listar todas as filiais
- `GET /api/filial/{id}` – Detalhar filial
- `POST /api/filial` – Criar nova filial

---

## 🔗 Tecnologias Utilizadas

- ASP.NET Core 8
- Entity Framework Core (SQL Server)
- AutoMapper
- Swagger / Swashbuckle
- Docker
- Azure CLI (deploy)

---

## ⚙️ Configuração do Projeto

### 1. Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server Local (ou Docker)
- Visual Studio 2022 ou VSCode

### 2. String de Conexão

Edite o arquivo `appsettings.json` com suas credenciais:

```json
"ConnectionStrings": {
  "SqlServerConnection": "Server=localhost;Database=MapeamentoPatioDB;User Id=sa;Password=SuaSenhaForte123;"
}
```

### 3. Aplicar Migrations

Execute os comandos:

```bash
dotnet ef migrations add InitialCreate -p MapeamentoInteligentePatio.Infrastructure -s MapeamentoInteligentePatio.API
dotnet ef database update -p MapeamentoInteligentePatio.Infrastructure -s MapeamentoInteligentePatio.API
```

### 4. Rodar a Aplicação

```bash
cd MapeamentoInteligentePatio.API
dotnet run
```

Acesse o Swagger em: `https://localhost:5001/swagger`

---

## 🐳 Docker

Para executar via Docker:

```bash
docker build -t mapeamentoapi .
docker run -p 5000:80 mapeamentoapi
```

---

## ☁️ Deploy no Azure

Consulte o arquivo `Azure_Deploy_Commands.sh` para deploy completo em App Service Linux Container via Azure CLI.

---

## 📮 Testes com Postman

Arquivo: `Postman_Collection.json`

Importe no Postman para testar as rotas principais da API.

---

## Integrantes
- RM555161 - Lucas Miranda Leite 
- RM555873 - Guilherme Damasio Roselli
- RM554681 - Gusthavo Daniel 



## 📅 Entrega

CP2 – 1º Semestre 2025  

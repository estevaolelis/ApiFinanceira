# 💰 ApiFinanceira

API desenvolvida em .NET Core para gerenciamento financeiro, utilizando **Supabase** como backend as a service (BaaS).

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge)

## 🚀 Tecnologias Utilizadas

* **[C# / .NET](https://dotnet.microsoft.com/)**: Plataforma de desenvolvimento.
* **[Supabase](https://supabase.com/)**: Banco de dados (PostgreSQL) e autenticação.
* **[Supabase-csharp](https://github.com/supabase-community/supabase-csharp)**: Biblioteca cliente para conexão.
* **Newtonsoft.Json**: Para serialização correta dos objetos do Supabase.
* **Swagger**: Para documentação interativa da API.

## 📂 Arquitetura

O projeto segue uma arquitetura em camadas para desacoplamento e organização:

* **Controllers**: Pontos de entrada da API.
* **Services**: Regras de negócio e comunicação com o Supabase.
* **DTOs (Data Transfer Objects)**: Objetos simples para entrada e saída de dados, evitando exposição direta dos Models do banco.
* **Models**: Mapeamento das tabelas do Supabase (`BaseModel`).

## ⚙️ Configuração

Antes de rodar, você precisa configurar as credenciais do Supabase.

1. Clone o repositório.
2. Localize o arquivo `appsettings.json`.
3. Adicione suas credenciais (Url e Key) conforme abaixo:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "Supabase": {
    "Url": "SUA_URL_DO_SUPABASE_AQUI",
    "Key": "SUA_KEY_ANON_DO_SUPABASE_AQUI"
  },
  "AllowedHosts": "*"
}

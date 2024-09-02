# CheckPoint4_dotNET

Este projeto é uma aplicação Web API desenvolvida em .NET 8.0, que fornece a cotação atual do dólar americano (USD) em reais (BRL) utilizando a API de câmbio ExchangeRate-API. 
A API é configurada para retornar a taxa de câmbio mais recente, e a documentação é gerada e disponibilizada através do Swagger UI.

## Tecnologias Utilizadas 
Linguagem: C# 
Framework: .NET 8.0 
Bibliotecas: Swashbuckle.AspNetCore: Para geração de documentação Swagger. 
HttpClient: Para chamadas HTTP à API de câmbio. 
Arquitetura: ASP.NET Core Web API 

## Funcionalidades 
Consultas de Taxa de Câmbio: Obtém a taxa de câmbio atual do USD para BRL. 

## Documentação 
Swagger: Fornece uma interface interativa para explorar e testar os endpoints da API. 
Injeção de Dependência: Configuração e uso de serviços de forma eficiente e modular. 

## Estrutura do Projeto 
Business: Contém a lógica de negócios para processar e manipular dados. 
Models: Define as classes de modelo para dados de entrada e saída. 
Services: Contém serviços para chamar APIs externas e realizar operações específicas. 
WebAPI: Contém a configuração da API, controle de endpoints e configuração Swagger.

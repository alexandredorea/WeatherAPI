## Introdução

Este projeto reflete um dos desafios realizados como parte de um processo seletivo para uma empresa na cidade de Blumenau-SC.

Buscou-se atender os requisitos solicitados, além de terem sido **adicionados por mim artefatos concernentes a gestão de projetos, gerência de configuração, entre outros**.



## Desafio: Cadastro de Notícias

[![GitHub issues][ImagemProblema]][Problemas] [![GitHub license][ImagemLicenca]][Licenca]


## Cenário

Você trabalha em uma agência de meteorologia de grande importância para muitos em todo o país. O responsável pela área decidiu que chegou a hora de implementar uma nova funcionalidade que permita cadastrar cidades e exibir a previsão do tempo delas.

Sua função é programar uma página de “Cadastro de Cidade”, onde o usuário irá preencher um campo para o nome da cidade e listar todas as cidades cadastradas, contendo links para visualizar os detalhes da previsão da cidade cadastrada.


## Especificações

A documentação deste projeto encontram-se dividida em:

1. [Cadastro de Cidade][CadastroCidade]
2. [Detalhe de Previsão][DetalhePrevisao]

## Observação

1. O problema foi resolvido utilizando plataforma web, considerando as tecnologias básicas como HTML, CSS e Javascript, observando as boas práticas de desenvolvimento web;
2. O código “server-side” foi desenvolvido obrigatoriamente em ASP.NET MVC e seguindo convenções REST (preferencialmente);
3. O Layout/Design da página web não era o principal fator de analise para este problema, mas isso não significava que devê-se fazer uma página sem quaisquer critérios para uma boa apresentação visual;
4. Para persistência dos dados foram utilizados Entity Framework Core 2.0 com SQL Server 2017.
5. Foram ainda aplicado para este problema, conceitos de Metodologia Ágil [Kanban e Scrum][ProjetoWeatherAPI], os quais foram definidas as *tasks* para uma melhor organização.


## Recursos utilizados no desenvolvimento da aplicação:

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|Linguagem C#                              |[Guia][GuiaCSharp]                |N/A               |
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Repositório de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |


## Andamento do Projeto

Para se ter uma ideia do andamento do projeto [clique aqui][ProjetoWeatherAPI] e tenha acesso ao **Quadro Atividades** para ver as *Tasks*.


## Ainda tem perguntas ou sugestão de melhoria?

Sinta-se à vontade em abrir um [issue][DefeitoWeatherAPI] ou [Pull Request][PullRequest].



[//]: # (Links de referências para os badges deste repositório)

[ImagemProblema]: <https://img.shields.io/github/issues/alexandredorea/WeatherAPI.svg?style=flat-square>
[Problemas]: <https://github.com/alexandredorea/WeatherAPI/issues>
[ImagemLicenca]: <https://img.shields.io/github/license/alexandredorea/WeatherAPI.svg?style=flat-square>
[Licenca]: <https://github.com/alexandredorea/WeatherAPI/blob/master/LICENSE>



[//]: # (Links de referências para os requisitos do sistema)

[CadastroCidade]: <>
[DetalhePrevisao]: <>



[//]: # (Links de referências para o quadro de recursos utilizados)

[GuiaVS2017]: <https://docs.microsoft.com/pt-br/visualstudio/ide/>
[IDEVS2017]: <https://www.visualstudio.com/pt-br/downloads/>
[GuiaCSharp]: <https://docs.microsoft.com/pt-br/dotnet/csharp/>
[GuiaDDD]: <http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/>
[GuiaASPNetCore]: <https://docs.microsoft.com/pt-br/dotnet/core/>
[GuiaEntityCore]: <https://docs.microsoft.com/pt-br/dotnet/framework/>
[GuiaRepositoryPattern]: <https://code.msdn.microsoft.com/windowsdesktop/Implementando-Repositrio-aabcdbce>
[GuiaMigrations]: <https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/>
[GuiaSQL2017]: <https://docs.microsoft.com/pt-br/sql/sql-server/sql-server-technical-documentation>
[IDESQL2017]: <https://www.microsoft.com/pt-br/sql-server/sql-server-downloads>



[//]: # (Links de referências o quadro Kanban do projeto)

[ProjetoWeatherAPI]: <https://github.com/alexandredorea/WeatherAPI/projects/1>



[//]: # (Links de referências aos problemas neste projeto)

[DefeitoWeatherAPI]: <https://github.com/alexandredorea/WeatherAPI/issues>
[PullRequest]: <https://github.com/alexandredorea/WeatherAPI/pulls>

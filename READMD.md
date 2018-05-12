## Introdu��o

Este projeto reflete um dos desafios realizados como parte de um processo seletivo para uma empresa na cidade de Blumenau-SC.

Buscou-se atender os requisitos solicitados, al�m de terem sido **adicionados por mim artefatos concernentes a gest�o de projetos, ger�ncia de configura��o, entre outros**.



## Desafio: Cadastro de Not�cias

[![GitHub issues][ImagemProblema]][Problemas] [![GitHub license][ImagemLicenca]][Licenca]


## Cen�rio

Voc� trabalha em uma ag�ncia de meteorologia de grande import�ncia para muitos em todo o pa�s. O respons�vel pela �rea decidiu que chegou a hora de implementar uma nova funcionalidade que permita cadastrar cidades e exibir a previs�o do tempo delas.

Sua fun��o � programar uma p�gina de �Cadastro de Cidade�, onde o usu�rio ir� preencher um campo para o nome da cidade e listar todas as cidades cadastradas, contendo links para visualizar os detalhes da previs�o da cidade cadastrada.


## Especifica��es

A documenta��o deste projeto encontram-se dividida em:

1. [Cadastro de Cidade][CadastroCidade]
2. [Detalhe de Previs�o][DetalhePrevisao]

## Observa��o

1. O problema foi resolvido utilizando plataforma web, considerando as tecnologias b�sicas como HTML, CSS e Javascript, observando as boas pr�ticas de desenvolvimento web;
2. O c�digo �server-side� foi desenvolvido obrigatoriamente em ASP.NET MVC e seguindo conven��es REST (preferencialmente);
3. O Layout/Design da p�gina web n�o era o principal fator de analise para este problema, mas isso n�o significava que dev�-se fazer uma p�gina sem quaisquer crit�rios para uma boa apresenta��o visual;
4. Para persist�ncia dos dados foram utilizados Entity Framework Core 2.0 com SQL Server 2017.
5. Foram ainda aplicado para este problema, conceitos de Metodologia �gil [Kanban e Scrum][ProjetoWeatherAPI], os quais foram definidas as *tasks* para uma melhor organiza��o.


## Recursos utilizados no desenvolvimento da aplica��o:

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|Linguagem C#                              |[Guia][GuiaCSharp]                |N/A               |
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Reposit�rio de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |


## Andamento do Projeto

Para se ter uma ideia do andamento do projeto [clique aqui][ProjetoWeatherAPI] e tenha acesso ao **Quadro Atividades** para ver as *Tasks*.


## Ainda tem perguntas ou sugest�o de melhoria?

Sinta-se � vontade em abrir um [issue][DefeitoWeatherAPI] ou [Pull Request][PullRequest].



[//]: # (Links de refer�ncias para os badges deste reposit�rio)

[ImagemProblema]: <https://img.shields.io/github/issues/alexandredorea/WeatherAPI.svg?style=flat-square>
[Problemas]: <https://github.com/alexandredorea/WeatherAPI/issues>
[ImagemLicenca]: <https://img.shields.io/github/license/alexandredorea/WeatherAPI.svg?style=flat-square>
[Licenca]: <https://github.com/alexandredorea/WeatherAPI/blob/master/LICENSE>



[//]: # (Links de refer�ncias para os requisitos do sistema)

[CadastroCidade]: <>
[DetalhePrevisao]: <>



[//]: # (Links de refer�ncias para o quadro de recursos utilizados)

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



[//]: # (Links de refer�ncias o quadro Kanban do projeto)

[ProjetoWeatherAPI]: <https://github.com/alexandredorea/WeatherAPI/projects/1>



[//]: # (Links de refer�ncias aos problemas neste projeto)

[DefeitoWeatherAPI]: <https://github.com/alexandredorea/WeatherAPI/issues>
[PullRequest]: <https://github.com/alexandredorea/WeatherAPI/pulls>
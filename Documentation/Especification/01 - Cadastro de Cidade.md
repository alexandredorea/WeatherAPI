# Especifica��o

## Tela: Cadastro de cidade

A tela de cadastro de cidade deve permitir o usu�rio inserir somente cidades que foram validadas pela API p�blica do [Open Weather Map][OpenWeatherMap] - ou seja - cidades que foram retornadas pela API e, s� ent�o gravar a informa��o no Banco de Dados.

## Prot�tipo

![Cadastro de Cidade][CadastroCidade]

1. Campo de �Cidade� (Preenchimento obrigat�rio pelo usu�rio)
2. Gridview com lista das cidades cadastradas

**Observa��o**

* Caso o usu�rio n�o preencha os campos corretamente ou o mesmo n�o seja validado pela API, a p�gina deve exibir indica��es visuais ou atrav�s de textos informando o motivo do erro e o que o usu�rio tem que preencher corretamente para que a not�cia seja enviada.
* Caso o usu�rio preencha o formul�rio corretamente e eles sejam validados corretamente deve ser exibida uma listagem com as cidades inseridas contendo um link para visualizar os detalhes da previs�o do tempo, na [Tela de Detalhe das Previs�es][DetalhePrevisao].

[//]: # (Links de refer�ncias)

[OpenWeatherMap]: <http://openweathermap.org/api>
[CadastroCidade]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Mockup/Imagens/Cadastro%20de%20Cidade.png>
[DetalhePrevisao]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Especification/02%20-%20Previsao%20do%20Tempo%20da%20Cidade.md>
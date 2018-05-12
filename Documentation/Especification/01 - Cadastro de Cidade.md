# Especificação

## Tela: Cadastro de cidade

A tela de cadastro de cidade deve permitir o usuário inserir somente cidades que foram validadas pela API pública do [Open Weather Map][OpenWeatherMap] - ou seja - cidades que foram retornadas pela API e, só então gravar a informação no Banco de Dados.

## Protótipo

![Cadastro de Cidade][CadastroCidade]

1. Campo de “Cidade” (Preenchimento obrigatório pelo usuário)
2. Gridview com lista das cidades cadastradas

**Observação**

* Caso o usuário não preencha os campos corretamente ou o mesmo não seja validado pela API, a página deve exibir indicações visuais ou através de textos informando o motivo do erro e o que o usuário tem que preencher corretamente para que a notícia seja enviada.
* Caso o usuário preencha o formulário corretamente e eles sejam validados corretamente deve ser exibida uma listagem com as cidades inseridas contendo um link para visualizar os detalhes da previsão do tempo, na [Tela de Detalhe das Previsões][DetalhePrevisao].

[//]: # (Links de referências)

[OpenWeatherMap]: <http://openweathermap.org/api>
[CadastroCidade]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Mockup/Imagens/Cadastro%20de%20Cidade.png>
[DetalhePrevisao]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Especification/02%20-%20Previsao%20do%20Tempo%20da%20Cidade.md>
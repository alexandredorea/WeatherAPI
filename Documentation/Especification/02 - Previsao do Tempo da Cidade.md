# Especificação

## Tela: Previsão do tempo da cidade

A tela com detalhe da previsão do tempo deve exibe um “forecast” de 5 dias ao usuário para a cidade selecionada por meio da listagem na [Tela de Cadastro da Cidade][CadastroCidade].

## Protótipo

![Preisao do Tempo][PrevisaoTempo]

1. Campo "Cidade, Estado, País" deve exibir as informações pertinentes à cidade selecionada na listagem da [Tela de Cadastro da Cidade][CadastroCidade];
2. Campo "Dia da semana, hora" deve exibir o dia da semana que usuário esta acessando no momento, com a hora pertinento a previsão mais próxima daquele horário;
3. Campo "Status do Clima" deve exibir o status do momento em que o usuário selecionou a cidade;
4. Campo "Imagem do Status do Clima" deve exibir o ícone visual que representa a situação do item 3;
5. Campo "Temperatura" deve ser exibido em Graus Celcius e sempre a máxima medida para o dia;
6. Campo "Velocidade", deve exibir a velocidade dos ventos;
7. Campo "Umidade" deve exibir a umidade relativa do ar em percentual;
8. Devem conter ainda um “forecast” de 5 dias com os seguintes campos:
8. 1. Campo "Dia da Semana";
8. 2. Campo "Imagem do Status do Clima";
8. 3. Campo "Temperatura Máxima";
8. 4. Campo "Temperatura Mínima";


**Observação**

* Para melhor entendimento do funcionamento desta página, é necessário primeiro a construção da Tela de Cadastro de Cidade primeiro, conforme descrito [aqui][CadastroCidade].

[//]: # (Links de referências)

[CadastroCidade]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Especification/01%20-%20Cadastro%20de%20Cidade.md>
[PrevisaoTempo]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Mockup/Imagens/Detalhe%20da%20Previsão%20do%20Tempo.png>
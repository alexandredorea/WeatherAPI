# Especifica��o

## Tela: Previs�o do tempo da cidade

A tela com detalhe da previs�o do tempo deve exibe um �forecast� de 5 dias ao usu�rio para a cidade selecionada por meio da listagem na [Tela de Cadastro da Cidade][CadastroCidade].

## Prot�tipo

![Preisao do Tempo][PrevisaoTempo]

1. Campo "Cidade, Estado, Pa�s" deve exibir as informa��es pertinentes � cidade selecionada na listagem da [Tela de Cadastro da Cidade][CadastroCidade];
2. Campo "Dia da semana, hora" deve exibir o dia da semana que usu�rio esta acessando no momento, com a hora pertinento a previs�o mais pr�xima daquele hor�rio;
3. Campo "Status do Clima" deve exibir o status do momento em que o usu�rio selecionou a cidade;
4. Campo "Imagem do Status do Clima" deve exibir o �cone visual que representa a situa��o do item 3;
5. Campo "Temperatura" deve ser exibido em Graus Celcius e sempre a m�xima medida para o dia;
6. Campo "Velocidade", deve exibir a velocidade dos ventos;
7. Campo "Umidade" deve exibir a umidade relativa do ar em percentual;
8. Devem conter ainda um �forecast� de 5 dias com os seguintes campos:
8. 1. Campo "Dia da Semana";
8. 2. Campo "Imagem do Status do Clima";
8. 3. Campo "Temperatura M�xima";
8. 4. Campo "Temperatura M�nima";


**Observa��o**

* Para melhor entendimento do funcionamento desta p�gina, � necess�rio primeiro a constru��o da Tela de Cadastro de Cidade primeiro, conforme descrito [aqui][CadastroCidade].

[//]: # (Links de refer�ncias)

[CadastroCidade]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Especification/01%20-%20Cadastro%20de%20Cidade.md>
[PrevisaoTempo]: <https://github.com/alexandredorea/WeatherAPI/blob/master/Documentation/Mockup/Imagens/Detalhe%20da%20Previs�o%20do%20Tempo.png>
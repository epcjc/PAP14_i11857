----
-- phpLiteAdmin database dump (http://phpliteadmin.googlecode.com)
-- phpLiteAdmin version: 1.9.3
-- Exported on Dec 6th, 2012, 09:27:51PM
-- Database file: ./database.db
----
BEGIN TRANSACTION;

----
-- Drop table for news
----
DROP TABLE "news";

----
-- Table structure for news
----
CREATE TABLE news (
	news_id INTEGER PRIMARY KEY AUTOINCREMENT,
	title VARCHAR,
	text VARCHAR,
	user_id INTEGER REFERENCES users,
	username VARCHAR,
	url VARCHAR,
	t DATETIME
);

----
-- Data dump for news, a total of 22 rows
----
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('1','Vídeo mostra Breivik a estacionar carrinha armadilhada antes do ataque','A televisão pública norueguesa divulgou esta segunda-feira, pela primeira vez, um vídeo que mostra o extremista Anders Behring Breivik a estacionar a carrinha armadilhada que provocou uma explosão e matou oito pessoas, em Oslo, em julho de 2011.

As imagens divulgadas pelo canal estatal NRK, que foram captadas pelas câmaras de videovigilância, mostram uma camioneta branca a ser estacionada junto dos serviços do Governo norueguês. Instantes depois, o condutor, envergando um uniforme, sai do veículo e afasta-se do local.

O vídeo, narrado por um elemento das forças de segurança que estava de serviço no dia do atentado, 22 de julho de 2011, mostra igualmente diferentes ângulos da explosão, que também feriu cerca de 30 pessoas.

É ainda possível ver Breivik a sair do local num segundo veículo, um Fiat cinzento. O extremista de direita seguiu depois para a ilha de Utoya, perto da capital norueguesa, onde abriu fogo contra jovens que participavam num acampamento da Juventude Trabalhista.

O ataque fez 69 mortos e Breivik foi preso no local do tiroteio.','7',NULL,NULL,'2012-11-26 18:42:00');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('2','Três presos fogem da cadeia junto à PJ','Três reclusos conseguiram evadir-se, na madrugada desta segunda-feira, do estabelecimento prisional anexo à Polícia Judiciária do Porto.

Segundo confirmou a Direção-Geral dos Serviços Prisionais (DGSP), encontram-se em fuga dois indivíduos de nacionalidade espanhola, que estavam em prisão preventiva a aguardar julgamento por roubos e furtos qualificados, e um cidadão venezuelano que foi condenado recentemente a seis anos de prisão, por tráfico de droga.

A DGSP não precisou as circunstâncias da evasão, adiantando apenas que foi dado o alerta às várias forças policiais (PJ, PSP e GNR) e que estão a ser desenvolvidos \"todos os esforços\" para a captura dos três indivíduos, com idades entre os 25 e os 37 anos.

Entretanto, foi mandado instaurar um inquérito para apurar os factos.             ','7',NULL,NULL,'2012-11-26 18:43:24');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('3','PSD e CDS-PP aprovam corte a metade do subsídio por morte','A maioria parlamentar PSD e CDS-PP aprovou, esta segunda-feira, o corte para metade do subsídio por morte, que é atribuído às pessoas de família a cargo dos aposentados por morte destes, com os votos contra da oposição.

Na votação na especialidade do Orçamento do Estado para 2013 que termina esta segunda-feira no Parlamento, os deputados aprovaram a limitação a 1.257,66 euros do valor de subsídio por morte atribuído à família a cargo dos aposentados.

Para isto, o Governo acrescenta uma limitação ao artigo 83 do Estatuto da Aposentação.

Anteriormente, a lei diz que \"as pessoas de família a cargo dos aposentados terão direito a receber, por morte destes, um subsídio correspondente a um número de pensões igual ao dos meses de vencimento que a lei concede por morte dos servidores no ativo\".

No orçamento é agora acrescentada a esta norma uma alteração ao valor máximo que corresponde ao \"limite máximo de três vezes o indexante dos apoios sociais\", que é o equivalente a 1.257,66 euros.

A lei atualmente define o subsidio por morte como \"uma prestação de atribuição única igual a seis vezes o valor da pensão mensal ilíquida com o limite máximo de seis vezes o IAS (2.515,32 euros)\".      ','7',NULL,NULL,'2012-11-26 18:45:04');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('4','F.C. Porto é única equipa invicta na Europa','O F.C. Porto é a única equipa invicta na Europa, depois de somar domingo, no reduto do Sporting de Braga (2-0), na 10.ª jornada da I Liga de futebol, o 18.º encontro sem perder em 2012/2013. 

O \"onze\" de Vítor Pereira soma 15 triunfos e três empates, dois para o campeonato, ambos fora (0-0 com o Gil Vicente e 2-2 com o Rio Ave), e um para a Liga dos Campeões (0-0 no reduto do Dínamo de Kiev), com 40-8 em golos. 

Entre os clubes dos campeonatos principais dos 53 países que integram o \"ranking\" da UEFA, o FC Porto é o único sem derrotas em 2012/2013, depois dos recentes desaires do Murata (São Marino) e do AEK Larnaca (Chipre), equipas que, esta época, não participaram nas competições europeias. 

Os \"dragões\" já eram, há muito, os resistentes sem desaires entre as equipas que estiveram ou estão ainda na Liga dos Campeões ou na Liga Europa, sendo que também ostentam o estatuto de melhor equipa da \"Champions\". 

A uma jornada do final da fase de grupos, o FC Porto é a única equipa com 13 pontos, face a cinco triunfos e apenas um empate (9-2 em golos), quando ainda tem de jogar no reduto do Paris Saint-Germain, a 04 de dezembro. 

Na Taça de Portugal, a equipa \"azul e branca\" também está nos oitavos de final, defrontando sexta-feira o Sporting de Braga, novamente na \"Pedreira\", depois de ter afastado Santa Eulália (1-0) e Nacional (3-0), com triunfos fora. 

A arrancar a temporada, o FC Porto venceu ainda a Académica por 1-0 e conquistou a Supertaça Cândido de Oliveira, graças a um golo do colombiano Jackson Martinez, que tem sido uma das grandes figuras da equipa, a par do compatriota James Rodriguez. 

No que respeita em exclusivo aos campeonatos dos diversos países europeus, os \"dragões\" ainda repartem o estatuto de invictos com mais oito equipas, entre as quais o Benfica, que só perdeu na Liga dos Campeões (0-2 com o FC Barcelona e 1-2 no reduto do Spartak de Moscovo). 

Na I Liga portuguesa, os \"dragões\" são líderes, mas apenas com um tento de vantagem sobre os \"encarnados\" (26-6 contra 25-6), numa altura em que as duas formações somam os mesmos oito triunfos e dois empates, para um total de 26 pontos. 

FC Barcelona (Espanha), Manchester City (Inglaterra), Olympiacos (Grécia), de Leonardo Jardim, Anorthosis e AEL Limassol (ambos do Chipre), Skënderbeu Korçë (Albânia) e Murata (São Marino) são as outras equipas sem derrotas nos respetivos campeonatos nacionais.

Entre estas sete equipas, o \"Barça\" e o City são os que disputaram mais jornadas (13), sendo que os catalães só cederam uma igualdade (2-2 com o Real Madrid), enquanto o conjunto de Manchester já empatou cinco vezes.','7',NULL,NULL,'2012-11-26 18:46:32');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('5','FEUP recebe especialista português em Neurociências','Fernando Lopes da Silva, especialista português de renome mundial em Neurociências, estará na FEUP no próximo dia 5 de dezembro, para apresentar a palestra \"Extracting information from brain rhythms: analytical tools and models\". A sessão vai decorrer no âmbito dos Seminários em Engenharia Biomédica do Mestrado em Engenharia (MEB), do Programa Doutoral em Engenharia Biomédica (PRODEB) e do ramo de Engenharia Biomédica do Mestrado Integrado em Bioengenharia (MIB). A sessão é aberta a todos os interessados. 

Fernando Lopes da Silva é especialista em Neurociências, centrando a sua investigação nos aspectos biofísicos da atividade elétrica do cérebro e na organização funcional das redes neuronais, nomeadamente do córtex e do sistema límbico, com grande enfoque nas atividades rítmicas do cérebro. O estudo do surgimento dos fenómenos epiléticos a nível celular, molecular e neuronal é também outro foco importante da sua investigação. 

De 1962 a 64 recebeu uma bolsa da Fundação Calouste Gulbenkian, para desenvolver investigação na área de Fisiologia e Farmacologia, no National Institute of Medical Research, em Londres. Especializou-se mais tarde em Engenharia e Física no Imperial College de Londres e, em seguida, aprofundou os seus conhecimentos em Nerurofisiologia, no Department of Brain Research of the Institute of Medical Physics (TNO), em Utrecht. Nesta instituição, integrou a equipa Brain Research Group, em 1965, e doutorou-se, em 1970. 

Em 1980, começou a lecionar a disciplina de fisiologia geral na Universidade de Amsterdão. Nesta mesma universidade assumiu a direção do Instituto de Neurobiologia de 1993 a 2000, altura em que se tornou professor emérito, aos 65 anos. Em 2002, tornou-se membro do Swammerdam Institute for Life Sciences. 

Ao longo da sua trajetória profissional, Fernando Lopes da Silva foi distinguido com vários prémios e títulos internacionais. Em Portugal, recebeu o grau de Doutor \"Honoris Causa\" pela Universidade de Lisboa (1997) e do Porto (2002).           ','7',NULL,NULL,'2012-11-26 18:48:06');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('6','BE e PCP voltam a exigir renegociação dos juros da dívida, Governo diz que juros são baixos','As bancadas mais à esquerda no Parlamento voltaram, esta segunda-feira, a exigir a renegociação dos juros da dívida com a \"troika\", enquanto o Governo diz que esta deve ser a taxa de juro mais baixa dos últimos 15 anos.

O Bloco de Esquerda iniciou mais um dia de debate na especialidade do Orçamento do Estado para 2013 com uma avocação da sua proposta para dar ao Governo uma autorização para renegociar os juros da dívida pública com o Banco Central Europeu, acusando o BCE de ter dois pesos e duas medidas, no que toca ao tratamento entre a banca comercial e os Estados da Europa.

O BE considera que a taxa de juro que a \"troika\" empresta a Portugal como \"usura e agiotagem\" e aquela que pratica na cedência de liquidez à banca comercial como uma política de \"favor e amiguismo\", acusando ainda o Governo de \"cair sempre para o lado dos juros cortando nos salários e nas pensões\".

Pelo PCP, Honório Novo disse que \"o que era importante é que houvesse vontade política\" e que \"de facto não há vontade\" para renegociar os juros da dívida, e que prefere gastar mais que o paga com a educação no país e que \"prefere espoliar os portugueses, as PME, os reformados e os trabalhadores, em vez de procurar de facto uma renegociação da dívida.

O secretário de Estado do Orçamento, Luís Morais Sarmento, explicou por sua vez que a taxa de juro que está a ser paga \"é a taxa de juro mais baixa provavelmente dos últimos 15 anos\".

\"Não vejo como chamar juros agiotas a quem nos concede empréstimos, a quem nos ajuda, nesta momento difícil que atravessamos? Parece-me me excessivo e não parece que possa resultar daqui uma ideia de agiotismo\", afirmou.    ','8',NULL,NULL,'2012-11-26 18:54:32');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('7','JN transmite este sábado homenagem a Saramago','Os mil bilhetes disponíveis para a 12.ª sessão de \"Porto de encontro\", dedicada a José Saramago, este sábado, pelas 21.30 horas, na Casa da Música, no Porto, esgotaram em apenas um quarto de hora, mas quem perdeu a oportunidade pode assistir à transmissão do evento em direto a partir do site do \"Jornal de Notícias\".

Ao longo de mais de duas horas, o percurso do escritor será evocado através do testemunho de figuras que lidaram de perto com ele. Mas haverá ainda espaço para várias manifestações artísticas, como a música, o teatro e as artes plásticas.

Pilar del Rio, Mário Cláudio, Álvaro Siza Vieira, Pedro Abrunhosa e Valter Hugo Mãe vão ser os oradores do debate, moderado pelo jornalista Sérgio Almeida.

Durante a sessão, vão ser ainda projetadas imagens de largas dezenas de trabalhos do artista plástico Agostinho Santos inspirados na obra de Saramago.

Os \"diseurs\" José Carlos Tinoco, Ana Celeste Ferreira, Emília Silvestre e Filipa Leal vão ler excertos dos romances \"Ensaio sobre a cegueira\", \"As intermitências da morte\", \"Memorial do convento\" e \"O Evangelho segundo Jesus Cristo\", selecionados por Pilar del Rio.

A componente performativa será assegurada através da participação da companhia penafidelense O Andaime e não faltará a música.','8',NULL,NULL,'2012-11-26 18:56:07');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('8','Israel e Hamas iniciam conversações no Cairo','Israel e os grupos palestinianos da Faixa de Gaza iniciaram esta terça-feira conversações indiretas no Cairo sobre a aplicação do acordo de cessar-fogo alcançado na semana passada.

Yasser Othman, principal responsável diplomático egípcio na Cisjordânia, confirmou o início das conversações.

Os contactos são os primeiros desde o acordo de cessar-fogo que na quarta-feira pôs termo a oito dias de confrontos entre as forças israelitas e os grupos palestinianos.

Nas negociações agora iniciadas, o Hamas e a Jihad Islâmica pretendem um alívio do bloqueio ao território, nomeadamente às restrições de movimentos impostas por Israel e pelo Egito. Do lado israelita, a principal exigência é o fim do tráfico de armas para a Faixa de Gaza.

O \"número dois\" do Hamas, Mussa Abu Marzuk, disse à imprensa, no Cairo, que as conversações estavam previstas no acordo concluído na quarta-feira.

Israel começou a restringir a entrada de bens na Faixa de Gaza, depois do sequestro de um soldado israelita por grupos palestinianos, em 2006, e impôs o atual bloqueio em 2007, quando o Hamas tomou o território à Fatah.','8',NULL,NULL,'2012-11-26 18:57:12');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('9','Empresário costa-riquenho faz proposta para adquirir o Valência','O empresário costa-riquenho Mário Alvarado Orozco anunciou, em comunicado de imprensa, o interesse na aquisição do Valência, da liga espanhola de futebol, tendo já apresentado uma oferta nesse sentido.

Orozco apresentou uma \"oferta condicionada de caráter vinculativo\", com o objetivo de \"poder resolver a situação económica do clube [Valência] e assim dar estabilidade financeira para as próximas décadas\", conforme indica o comunicado.

O clube \"che\" tem atualmente uma dívida de 370 milhões de euros e um estádio cujas obras estão paradas há três anos, com a necessidade de injetar 150 milhões para serem finalizadas.

\"O nosso projeto, dirigido por valencianos, leva meses a preparar com absoluta discrição e profissionalismo para não pôr em risco a viabilidade da operação\", reitera o comunicado difundido por Alvarado Orozco.

Para o investidor, este projeto tem em vista \"tranquilizar a sociedade valenciana e em especial os adeptos do Valência acerca dos interesses\" do mesmo.

O comunicado acrescenta que os três grandes objetivos do programa são de libertar o clube de qualquer tipo de tensão económica, preservar o seu património adquirido e oferecer um projeto desportivo e social que marque \"uma nova era\" para o clube.','8',NULL,NULL,'2012-11-26 19:01:12');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('10','Metade dos alunos detêm o mirandês como disciplina de opção','\"Este ano ultrapassámos os 450 alunos matriculados na disciplina de língua e cultura mirandesa, sendo que este número representa mais de metade da população estudantil do AEMD\", explicou António Santos.  Em relação ao anterior ano lectivo, verifica-se um aumento de mais de duas dezenas de alunos.
\"Fico satisfeito com o aumento do interesse demonstrado pelos alunos para estudarem língua e cultura mirandesa, mesmo sendo uma disciplina de opção\", frisou o responsável. Este aumento crescente dos alunos pela disciplina reflecte-se em diversos trabalhos elaborados no âmbito das actividades extracurriculares, como é caso de uma revista e de um jornal escritos em língua mirandesa pelos alunos.
\"Eu creio que há uma nova vitalidade em torno da língua mirandesa e estou muito optimista em relação ao seu futuro. Mas preciso criar melhores condições para o ensino do mirandês no meio escolar para se continuar no bom caminho \", acrescentou António Santos.
Já Thibaut Ferreira, um aluno que deixou o AEMD para continuar os estudos em outras paragens, disse que aprender mirandês foi importante na sua vida. \"Os meus pais sempre me incentivaram a aprender a língua mirandesa, coisa que faço desde os cinco anos e logo que comecei a escrever as primeiras palavras\", recordou o antigo aluno.              ','8',NULL,NULL,'2012-11-26 19:02:54');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('11','JRC activities|Cooperation and job opportunities for young researchers at the Joint Research Centre','A sessão de 30 de novembro visa fomentar a presença de investigadores nacionais no JRC, informando sobre oportunidades para estadias e trabalho de cooperação científica nos laboratórios e Institutos do JRC. 

O Joint Research Centre (JRC) é a entidade de investigação da Comissão Europeia cuja missão é contribuir para a formulação de políticas europeias numa gama alargada de setores. Engloba um conjunto de centros e laboratórios \"state of the art\", organizados em Institutos, onde trabalha um vasto conjunto de cientistas e especialistas numa gama alargada de temas. No âmbito da sua missão, o JRC colabora com um leque alargado de entidades, públicas e privadas, colaborando em projetos, no desenvolvimento de produtos e na resolução de problemas complexos. 

Para mais informações sobre os eventos e inscrições on-line, consultar a página do GPPQ.','8',NULL,NULL,'2012-11-26 19:04:40');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('12','Governo não cede e receita do IVA da restauração aumentou 106%','No debate da especialidade do Orçamento do Estado para 2013, na Assembleia da República, Governo e maioria PSD/CDS não deram quaisquer sinais de abertura em relação às propostas das bancadas da oposição para que o IVA da restauração seja reposto nos 13%, em vez dos 23%.

Neste ponto, o secretário de Estado Paulo Núncio centrou o seu discurso na necessidade de intensificar o combate à fraude e evasão fiscais para que haja \"equidade\" e existência de condições de \"concorrência saudável\" no setor.

O secretário de Estado dos Assuntos Fiscais contrariou também a tese comum à oposição, segundo a qual o aumento do IVA de 13 para 23%, no âmbito do Orçamento deste ano, gerou menor receita fiscal para o Estado, aumentando em contrapartida as falências e o desemprego.

\"O IVA da restauração entregue ao Estado até agosto passado ultrapassa em 106% o IVA entregue por este mesmo setor em período homólogo de 2011. No regime mensal, o IVA entregue ao Estado aumentou 122% relativamente a período homólogo do ano passado\", disse.

Numa linha de discurso distinta, o deputado do PSD Virgílio Macedo falou na criação de um grupo de trabalho para a prazo equacionar-se \"um regime fiscal mais justo e equitativo\" no setor da restauração.','9',NULL,NULL,'2012-11-26 19:06:04');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('13','Portugal e EUA em contacto sobre minimização de impacto da saída da Base das Lajes','Os governos de Portugal e dos Estados Unidos estão a negociar medidas de minimização do impacto da retirada da Força Aérea norte-americana da Base das Lajes, Açores.

A forte redução da presença militar norte-americana nas Lajes, comunicada pelo Departamento de Defesa norte-americano ao governo português na semana passada, é \"basicamente definitiva\", mas ainda há \"sérias discussões sobre o processo\" que estão em curso, disse à Lusa o major Robert Firman.

De acordo com a mesma fonte, cabe a Lisboa apresentar ao Departamento de Defesa as suas questões sobre o processo, dizendo respeito à redução do impacto económico e laboral, e Washington procurará atender a estas.

Segundo Firman, nos próximos dias o governo português deverá fazer um anúncio formal do resultado do processo negocial, que foi lançado no início deste ano durante uma visita do ministro da Defesa Aguiar Branco a Washington, onde se avistou com o secretário da Defesa, Leon Panetta.

A mesma fonte remete mais esclarecimentos para o governo português.

Sábado passado, o ministro de Estado e dos Negócios Estrangeiros, Paulo Portas, afirmou que Portugal vai tomar \"em breve\" uma posição sobre a redução da presença norte-americana nas Lajes.  ','9',NULL,NULL,'2012-11-26 19:07:08');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('14','Museu alemão admite ter quadros roubados pelos nazis','O museu de Arte da Renânia do Norte-Westefalia comunicou que não consegue determinar a origem de 33 obras e admite que podem tratar-se de quadros roubados pelos nazis durante a Segunda Guerra Mundial.

Marion Ackerman, diretora da coleção, referiu-se em concreto aos pedidos de restituição formulados pelos herdeiros do conhecido galerista Alfred Electhheim (1878-1938), que, segundo alguns historiadores, foi o primeiro judeu a ser expropriado pelos nazis após a subida de Hitler ao poder em 1933.

Até ao momento, não foi possível dar resposta aos pedidos da família do galerista que reclamam os quadros \"Federpflanze\", de Paul Klee, e uma natureza morta do cubista Juan Gris. 

Por isso, Ackermann pediu ao Governo alemão para interceder junto da França, ao mais alto nível, com o objetivo de conseguir autorização para investigar o arquivo da Galeria Daniel-Henry Kahnweiler (atualmente Galeria Louise Leiris), de acesso interdito para que se possam \"conseguir resultados\" sobre a origem e percurso dos quadros. 

Segundo a diretora do museu alemão, caso a investigação não consiga resultados, vão ter de ser os políticos a decidir pela possível devolução dos quadros à família do galerista, como ato de \"pagamento moral\". ','9',NULL,NULL,'2012-11-26 19:08:15');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('15','Corpo encontrado no rio Tejo junto ao terminal fluvial do Barreiro','O corpo de um homem foi esta segunda-feira encontrado no rio Tejo, junto ao antigo terminal fluvial do Barreiro.

\"Tomámos conhecimento, cerca das 12 horas, de um corpo no rio Tejo junto ao terminal do Barreiro. Trata-se de um homem na casa dos 60 a 70 anos, mas ainda não foi possível identificar e saber as causas da ocorrência\", referiu à Lusa fonte da Polícia Marítima.

Segundo a mesma fonte, o corpo não estava na água há mais de 24 horas e não existe nas autoridades registo de nenhum desaparecimento.

Fonte dos Bombeiros de Salvação Pública do Barreiro disse à Lusa que a primeira informação apontava para uma queda ao rio, o que acabou por não se confirmar.

\"Recebemos a informação de uma queda ao rio na zona do terminal antigo, mas quando chegámos ao local constatámos que se tratava de um corpo que apareceu a boiar na água, tendo sido chamada a Polícia Marítima para tomar conta da ocorrência\", afirmou.       ','9',NULL,NULL,'2012-11-26 19:10:15');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('16','Samsung nega trabalho infantil em fornecedores chineses','A Samsung Electronics negou, esta segunda-feira, a existência de trabalho infantil nas fábricas de 105 dos seus mais de 250 fornecedores na China, apesar terem sido detetadas praticas laborais \"inadequadas\" como horas extraordinárias em excesso e multas por ausências ou atrasos.

A Samsung revelou, esta segunda-feira, em Seul os resultados de uma primeira auditoria realizada em setembro em 105 fornecedores que empregam mais de 65 mil pessoas na fabricação de alguns dos seus produtos na China, depois de uma organização não-governamental norte-americana ter acusado um desses fornecedores de empregar crianças.

A empresa sul-coreana investiga agora outros 144 fornecedores chineses, numa segunda auditoria que prevê estar concluída no final do ano.

\"A Samsung não identificou nenhum caso de trabalho infantil depois de rever nos registos de recursos humanos de todos os trabalhadores menores de 18 anos e levar a cabo controlos pessoais de identidade\", explica a empresa num comunicado.         ','9',NULL,NULL,'2012-11-26 19:11:07');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('17','Chave do Totoloto','O primeiro prémio do concurso 94/2012 do Totoloto é um \"jackpot\" de cerca de qutroto milhões de euros.

A chave vencedora do concurso Totoloto, sorteada este sábado, é composta pelos números 01 - 02 - 33 - 46 - 48.

O número da sorte é o 05.   ','9',NULL,NULL,'2012-11-26 19:12:43');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('18','As manifestações não são um problema de segurança, são um exercício de cidadania, diz ministro','                As manifestações são um exercício de direitos cívicos das pessoas em  democracia. Não há nenhum problema com as manifestações. Uma manifestação  não é um problema de segurança interna, é um problema de exercício de cidadania  e portanto quero enfatizar isso", disse Miguel Macedo. 

O ministro, que falava aos jornalistas à margem da apresentação de um  projeto sobre desastres naturais em Portugal, que se realizou hoje em Cascais,  lembrou ainda que os acontecimentos do passado dia 14 de novembro, junto à Assembleia da República, traduziram-se numa "manifestação que, a certa  altura, degenerou num problema de ordem pública". ','1',NULL,NULL,'2012-11-26 20:18:51');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('19','Submarinos: Miguel Horta e Costa admite contrapartidas fictícias justificadas com facturas','                O consultor da ESCOM Miguel Horta e Costa admitiu hoje em tribunal que houve contrapartidas fictícias justificadas e cobertas por facturas no caso dos dois submarinos alemães vendidos a Portugal em 2004.
A inquirição da testemunha Miguel Horta e Costa, à data dos factos consultor da ESCOM (então uma empresa do grupo Grupo Espírito Santo), revelou-se bastante atribulada, com a testemunha a esquivar-se às perguntas do procurador Vítor Pinto e a ser advertido pela juíza Judite Fonseca de que tinha que responder directamente e com verdade às perguntas.','1',NULL,NULL,'2012-11-26 20:19:36');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('20','Cardozo e Luisão dão vitória ao Benfica (2-0)','                O Benfica venceu esta noite o Olhanense na Luz, num jogo a contar para a 10ª jornada do campeonato. Os encarnados ganham por 2-0 e conquistaram mais 3 pontos. Seguem na liderança provisória do campeonato.
O primeiro golo da partida surgiu aos 26 minutos, na conversão de um penálti assinalado contra o Olhanense. Cardozo remata para o lado direito e Bracali não consegue evitar o golo.','7',NULL,NULL,'2012-11-26 20:20:46');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('42','Lorem2','Cras sit amet sem erat, non condimentum massa. Sed dapibus luctus viverra. Donec faucibus porttitor rutrum. Quisque blandit felis vitae purus ullamcorper venenatis. Fusce hendrerit ornare egestas. Sed dapibus ultrices augue.',NULL,'Mario Rocha','http://paginas.fe.up.pt/~ei10087/News/show_news.php?newsid=10','2012-12-02 12:40:44');
INSERT INTO "news" ("news_id","title","text","user_id","username","url","t") VALUES ('43','Lorem1','Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur facilisis sodales velit ornare fermentum. Donec sit amet sapien vel leo interdum tincidunt. Proin non sem est. Duis rutrum felis a orci dictum scelerisque. Integer urna lacus, vulputate eget porttitor id, pharetra vel est. Aliquam nec vehicula turpis.',NULL,'Mario Rocha','http://paginas.fe.up.pt/~ei10087/News/show_news.php?newsid=9','2012-12-02 12:40:44');

----
-- Drop table for comments
----
DROP TABLE "comments";

----
-- Table structure for comments
----
CREATE TABLE comments (
	comments_id INTEGER PRIMARY KEY AUTOINCREMENT,
	news_id INTEGER REFERENCES news,
	autor INTEGER REFERENCES users,
	text VARCHAR
);

----
-- Data dump for comments, a total of 17 rows
----
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('1','20','3',' Não gosto nada do benfica, deviam de perder sempre');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('2','20','10',' Olha que eu sou benfiquista e sou o administrador, bloqueio-te já a conta');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('3','20','3',' Força, eu criou outra');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('4','20','10',' Asério -.-');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('5','17','3',' Estou milionário :P');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('6','17','4',' Eu também estou :O');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('7','17','3',' Isso quer dizer que temos de dividir o prémio (oh God)');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('8','19','4','Paulo Portas, força Paulinho estou contigo, operação tridente sorridente');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('9','19','3',' Eu continuo a gostar mais de coelho no forno');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('10','19','4',' Para mim so moelinhas');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('11','18','3',' Eu vou estar na próxima manifestação no Porto');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('12','18','4',' Naquela que vai ocorrer nos Aliados?');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('13','18','3','Sim');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('14','18','4','Encontramo-nos lá');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('15','16','3',' Acho um escandalo, isto acontecer');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('16','16','4',' Principalmente numa marca tão grande como a Samsung');
INSERT INTO "comments" ("comments_id","news_id","autor","text") VALUES ('17','16','3','Eu Não acreditava se não visse aqui');

----
-- Drop table for users
----
DROP TABLE "users";

----
-- Table structure for users
----
CREATE TABLE users (
	user_id INTEGER PRIMARY KEY AUTOINCREMENT,
	username VARCHAR,
	fullname VARCHAR,
	password VARCHAR,
	type INTEGER,
	status VARCHAR
);

----
-- Data dump for users, a total of 9 rows
----
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('1','admin002','Nelson Mendes','1234','1','active');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('3','utilizador1','Afonso Alves Maria Alves','1234','3','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('4','utilizador2','João Carvalho','1234','3','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('5','utilizador3','Maria Silva','1234','3','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('6','utilizador4','Eduardo Costa','1234','3','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('7','editor01','Marco Rocha','1234','2','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('8','editor02','António Garcez','1234','2','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('9','editor03','Pedro Barbosa','1234','2','');
INSERT INTO "users" ("user_id","username","fullname","password","type","status") VALUES ('10','admin001','Marco Joel','1234','1','');

----
-- Drop table for favoritos
----
DROP TABLE "favoritos";

----
-- Table structure for favoritos
----
CREATE TABLE favoritos(
	favoritos_id INTEGER PRIMARY KEY AUTOINCREMENT,
	user_id INTEGER REFERENCES users,
	news_id INTEGER REFERENCES news
);

----
-- Data dump for favoritos, a total of 0 rows
----

----
-- Drop table for tags
----
DROP TABLE "tags";

----
-- Table structure for tags
----
CREATE TABLE tags(
	tags_id INTEGER PRIMARY KEY AUTOINCREMENT,
	news_id INTEGER REFERENCES news,
	tag VARCHAR
);

----
-- Data dump for tags, a total of 56 rows
----
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('1','1','internacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('2','1','sociedade');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('3','2','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('4','2','vida');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('5','3','economia');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('6','3','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('7','4','desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('8','5','feup');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('9','5','vida');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('10','6','politica');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('11','7','cultura');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('12','7','sociedade');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('13','8','internacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('14','8','politica');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('15','9','desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('16','10','ensino');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('17','10','cultura');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('18','11','feup');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('19','11','ensino');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('20','12','economia');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('21','13','politica');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('22','14','cultura');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('23','14','internacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('24','15','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('25','15','sociedade');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('26','16','internacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('27','16','vida');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('28','16','sociedade');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('29','17','sociedade');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('30','','economia');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('31','','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('32','','economia');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('33','','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('34','','economia');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('35','','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('36','18','politica');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('37','19','politica');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('38','19','nacional');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('39','20','desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('40','21','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('41','22','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('42','23','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('43','24','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('44','25','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('45','28','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('46','30','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('47','32','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('48','33','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('49','34','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('50','35','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('51','37','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('52','39','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('53','40','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('54','41','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('55','42','Desporto');
INSERT INTO "tags" ("tags_id","news_id","tag") VALUES ('56','43','Desporto');

----
-- Drop table for servers
----
DROP TABLE "servers";

----
-- Table structure for servers
----
CREATE TABLE servers(
	servers_id INTEGER PRIMARY KEY AUTOINCREMENT,
	name VARCHAR,
	url VARCHAR
);

----
-- Data dump for servers, a total of 0 rows
----
COMMIT;

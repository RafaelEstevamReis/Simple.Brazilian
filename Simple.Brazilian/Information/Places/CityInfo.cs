﻿namespace Simple.Brazilian.Information.Places;

/// <summary>
/// Dados sobre a cidade
/// </summary>
public class CityInfo
{
    /// <summary>
    /// Código IBGE do estado
    /// </summary>
    public int IdState { get; set; }
    /// <summary>
    /// Código IBGE da cidade
    /// </summary>
    public int IdCity { get; set; }
    /// <summary>
    /// Nome da Cidade
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Código completo da cidade no IBGE
    /// </summary>
    public string CompleteId { get; set; }
    /// <summary>
    /// Representação textual da cidade
    /// </summary>
    public override string ToString() => $"{IdState} {IdCity} {Name}";

    internal static readonly string rawCityData =
@"11	00015	Alta Floresta D'Oeste
11	00379	Alto Alegre dos Parecis
11	00403	Alto Paraíso
11	00346	Alvorada D'Oeste
11	00023	Ariquemes
11	00452	Buritis
11	00031	Cabixi
11	00601	Cacaulândia
11	00049	Cacoal
11	00700	Campo Novo de Rondônia
11	00809	Candeias do Jamari
11	00908	Castanheiras
11	00056	Cerejeiras
11	00924	Chupinguaia
11	00064	Colorado do Oeste
11	00072	Corumbiara
11	00080	Costa Marques
11	00940	Cujubim
11	00098	Espigão D'Oeste
11	01005	Governador Jorge Teixeira
11	00106	Guajará-Mirim
11	01104	Itapuã do Oeste
11	00114	Jaru
11	00122	Ji-Paraná
11	00130	Machadinho D'Oeste
11	01203	Ministro Andreazza
11	01302	Mirante da Serra
11	01401	Monte Negro
11	00148	Nova Brasilândia D'Oeste
11	00338	Nova Mamoré
11	01435	Nova União
11	00502	Novo Horizonte do Oeste
11	00155	Ouro Preto do Oeste
11	01450	Parecis
11	00189	Pimenta Bueno
11	01468	Pimenteiras do Oeste
11	00205	Porto Velho
11	00254	Presidente Médici
11	01476	Primavera de Rondônia
11	00262	Rio Crespo
11	00288	Rolim de Moura
11	00296	Santa Luzia D'Oeste
11	01484	São Felipe D'Oeste
11	01492	São Francisco do Guaporé
11	00320	São Miguel do Guaporé
11	01500	Seringueiras
11	01559	Teixeirópolis
11	01609	Theobroma
11	01708	Urupá
11	01757	Vale do Anari
11	01807	Vale do Paraíso
11	00304	Vilhena
12	00013	Acrelândia
12	00054	Assis Brasil
12	00104	Brasiléia
12	00138	Bujari
12	00179	Capixaba
12	00203	Cruzeiro do Sul
12	00252	Epitaciolândia
12	00302	Feijó
12	00328	Jordão
12	00336	Mâncio Lima
12	00344	Manoel Urbano
12	00351	Marechal Thaumaturgo
12	00385	Plácido de Castro
12	00807	Porto Acre
12	00393	Porto Walter
12	00401	Rio Branco
12	00427	Rodrigues Alves
12	00435	Santa Rosa do Purus
12	00500	Sena Madureira
12	00450	Senador Guiomard
12	00609	Tarauacá
12	00708	Xapuri
13	00029	Alvarães
13	00060	Amaturá
13	00086	Anamã
13	00102	Anori
13	00144	Apuí
13	00201	Atalaia do Norte
13	00300	Autazes
13	00409	Barcelos
13	00508	Barreirinha
13	00607	Benjamin Constant
13	00631	Beruri
13	00680	Boa Vista do Ramos
13	00706	Boca do Acre
13	00805	Borba
13	00839	Caapiranga
13	00904	Canutama
13	01001	Carauari
13	01100	Careiro
13	01159	Careiro da Várzea
13	01209	Coari
13	01308	Codajás
13	01407	Eirunepé
13	01506	Envira
13	01605	Fonte Boa
13	01654	Guajará
13	01704	Humaitá
13	01803	Ipixuna
13	01852	Iranduba
13	01902	Itacoatiara
13	01951	Itamarati
13	02009	Itapiranga
13	02108	Japurá
13	02207	Juruá
13	02306	Jutaí
13	02405	Lábrea
13	02504	Manacapuru
13	02553	Manaquiri
13	02603	Manaus
13	02702	Manicoré
13	02801	Maraã
13	02900	Maués
13	03007	Nhamundá
13	03106	Nova Olinda do Norte
13	03205	Novo Airão
13	03304	Novo Aripuanã
13	03403	Parintins
13	03502	Pauini
13	03536	Presidente Figueiredo
13	03569	Rio Preto da Eva
13	03601	Santa Isabel do Rio Negro
13	03700	Santo Antônio do Içá
13	03809	São Gabriel da Cachoeira
13	03908	São Paulo de Olivença
13	03957	São Sebastião do Uatumã
13	04005	Silves
13	04062	Tabatinga
13	04104	Tapauá
13	04203	Tefé
13	04237	Tonantins
13	04260	Uarini
13	04302	Urucará
13	04401	Urucurituba
14	00050	Alto Alegre
14	00027	Amajari
14	00100	Boa Vista
14	00159	Bonfim
14	00175	Cantá
14	00209	Caracaraí
14	00233	Caroebe
14	00282	Iracema
14	00308	Mucajaí
14	00407	Normandia
14	00456	Pacaraima
14	00472	Rorainópolis
14	00506	São João da Baliza
14	00605	São Luiz
14	00704	Uiramutã
15	00107	Abaetetuba
15	00131	Abel Figueiredo
15	00206	Acará
15	00305	Afuá
15	00347	Água Azul do Norte
15	00404	Alenquer
15	00503	Almeirim
15	00602	Altamira
15	00701	Anajás
15	00800	Ananindeua
15	00859	Anapu
15	00909	Augusto Corrêa
15	00958	Aurora do Pará
15	01006	Aveiro
15	01105	Bagre
15	01204	Baião
15	01253	Bannach
15	01303	Barcarena
15	01402	Belém
15	01451	Belterra
15	01501	Benevides
15	01576	Bom Jesus do Tocantins
15	01600	Bonito
15	01709	Bragança
15	01725	Brasil Novo
15	01758	Brejo Grande do Araguaia
15	01782	Breu Branco
15	01808	Breves
15	01907	Bujaru
15	02004	Cachoeira do Arari
15	01956	Cachoeira do Piriá
15	02103	Cametá
15	02152	Canaã dos Carajás
15	02202	Capanema
15	02301	Capitão Poço
15	02400	Castanhal
15	02509	Chaves
15	02608	Colares
15	02707	Conceição do Araguaia
15	02756	Concórdia do Pará
15	02764	Cumaru do Norte
15	02772	Curionópolis
15	02806	Curralinho
15	02855	Curuá
15	02905	Curuçá
15	02939	Dom Eliseu
15	02954	Eldorado do Carajás
15	03002	Faro
15	03044	Floresta do Araguaia
15	03077	Garrafão do Norte
15	03093	Goianésia do Pará
15	03101	Gurupá
15	03200	Igarapé-Açu
15	03309	Igarapé-Miri
15	03408	Inhangapi
15	03457	Ipixuna do Pará
15	03507	Irituia
15	03606	Itaituba
15	03705	Itupiranga
15	03754	Jacareacanga
15	03804	Jacundá
15	03903	Juruti
15	04000	Limoeiro do Ajuru
15	04059	Mãe do Rio
15	04109	Magalhães Barata
15	04208	Marabá
15	04307	Maracanã
15	04406	Marapanim
15	04422	Marituba
15	04455	Medicilândia
15	04505	Melgaço
15	04604	Mocajuba
15	04703	Moju
15	04752	Mojuí dos Campos
15	04802	Monte Alegre
15	04901	Muaná
15	04950	Nova Esperança do Piriá
15	04976	Nova Ipixuna
15	05007	Nova Timboteua
15	05031	Novo Progresso
15	05064	Novo Repartimento
15	05106	Óbidos
15	05205	Oeiras do Pará
15	05304	Oriximiná
15	05403	Ourém
15	05437	Ourilândia do Norte
15	05486	Pacajá
15	05494	Palestina do Pará
15	05502	Paragominas
15	05536	Parauapebas
15	05551	Pau D'Arco
15	05601	Peixe-Boi
15	05635	Piçarra
15	05650	Placas
15	05700	Ponta de Pedras
15	05809	Portel
15	05908	Porto de Moz
15	06005	Prainha
15	06104	Primavera
15	06112	Quatipuru
15	06138	Redenção
15	06161	Rio Maria
15	06187	Rondon do Pará
15	06195	Rurópolis
15	06203	Salinópolis
15	06302	Salvaterra
15	06351	Santa Bárbara do Pará
15	06401	Santa Cruz do Arari
15	06500	Santa Izabel do Pará
15	06559	Santa Luzia do Pará
15	06583	Santa Maria das Barreiras
15	06609	Santa Maria do Pará
15	06708	Santana do Araguaia
15	06807	Santarém
15	06906	Santarém Novo
15	07003	Santo Antônio do Tauá
15	07102	São Caetano de Odivelas
15	07151	São Domingos do Araguaia
15	07201	São Domingos do Capim
15	07300	São Félix do Xingu
15	07409	São Francisco do Pará
15	07458	São Geraldo do Araguaia
15	07466	São João da Ponta
15	07474	São João de Pirabas
15	07508	São João do Araguaia
15	07607	São Miguel do Guamá
15	07706	São Sebastião da Boa Vista
15	07755	Sapucaia
15	07805	Senador José Porfírio
15	07904	Soure
15	07953	Tailândia
15	07961	Terra Alta
15	07979	Terra Santa
15	08001	Tomé-Açu
15	08035	Tracuateua
15	08050	Trairão
15	08084	Tucumã
15	08100	Tucuruí
15	08126	Ulianópolis
15	08159	Uruará
15	08209	Vigia
15	08308	Viseu
15	08357	Vitória do Xingu
15	08407	Xinguara
16	00105	Amapá
16	00204	Calçoene
16	00212	Cutias
16	00238	Ferreira Gomes
16	00253	Itaubal
16	00279	Laranjal do Jari
16	00303	Macapá
16	00402	Mazagão
16	00501	Oiapoque
16	00154	Pedra Branca do Amapari
16	00535	Porto Grande
16	00550	Pracuúba
16	00600	Santana
16	00055	Serra do Navio
16	00709	Tartarugalzinho
16	00808	Vitória do Jari
17	00251	Abreulândia
17	00301	Aguiarnópolis
17	00350	Aliança do Tocantins
17	00400	Almas
17	00707	Alvorada
17	01002	Ananás
17	01051	Angico
17	01101	Aparecida do Rio Negro
17	01309	Aragominas
17	01903	Araguacema
17	02000	Araguaçu
17	02109	Araguaína
17	02158	Araguanã
17	02208	Araguatins
17	02307	Arapoema
17	02406	Arraias
17	02554	Augustinópolis
17	02703	Aurora do Tocantins
17	02901	Axixá do Tocantins
17	03008	Babaçulândia
17	03057	Bandeirantes do Tocantins
17	03073	Barra do Ouro
17	03107	Barrolândia
17	03206	Bernardo Sayão
17	03305	Bom Jesus do Tocantins
17	03602	Brasilândia do Tocantins
17	03701	Brejinho de Nazaré
17	03800	Buriti do Tocantins
17	03826	Cachoeirinha
17	03842	Campos Lindos
17	03867	Cariri do Tocantins
17	03883	Carmolândia
17	03891	Carrasco Bonito
17	03909	Caseara
17	04105	Centenário
17	05102	Chapada da Natividade
17	04600	Chapada de Areia
17	05508	Colinas do Tocantins
17	16703	Colméia
17	05557	Combinado
17	05607	Conceição do Tocantins
17	06001	Couto Magalhães
17	06100	Cristalândia
17	06258	Crixás do Tocantins
17	06506	Darcinópolis
17	07009	Dianópolis
17	07108	Divinópolis do Tocantins
17	07207	Dois Irmãos do Tocantins
17	07306	Dueré
17	07405	Esperantina
17	07553	Fátima
17	07652	Figueirópolis
17	07702	Filadélfia
17	08205	Formoso do Araguaia
17	08254	Fortaleza do Tabocão
17	08304	Goianorte
17	09005	Goiatins
17	09302	Guaraí
17	09500	Gurupi
17	09807	Ipueiras
17	10508	Itacajá
17	10706	Itaguatins
17	10904	Itapiratins
17	11100	Itaporã do Tocantins
17	11506	Jaú do Tocantins
17	11803	Juarina
17	11902	Lagoa da Confusão
17	11951	Lagoa do Tocantins
17	12009	Lajeado
17	12157	Lavandeira
17	12405	Lizarda
17	12454	Luzinópolis
17	12504	Marianópolis do Tocantins
17	12702	Mateiros
17	12801	Maurilândia do Tocantins
17	13205	Miracema do Tocantins
17	13304	Miranorte
17	13601	Monte do Carmo
17	13700	Monte Santo do Tocantins
17	13957	Muricilândia
17	14203	Natividade
17	14302	Nazaré
17	14880	Nova Olinda
17	15002	Nova Rosalândia
17	15101	Novo Acordo
17	15150	Novo Alegre
17	15259	Novo Jardim
17	15507	Oliveira de Fátima
17	21000	Palmas
17	15705	Palmeirante
17	13809	Palmeiras do Tocantins
17	15754	Palmeirópolis
17	16109	Paraíso do Tocantins
17	16208	Paranã
17	16307	Pau D'Arco
17	16505	Pedro Afonso
17	16604	Peixe
17	16653	Pequizeiro
17	17008	Pindorama do Tocantins
17	17206	Piraquê
17	17503	Pium
17	17800	Ponte Alta do Bom Jesus
17	17909	Ponte Alta do Tocantins
17	18006	Porto Alegre do Tocantins
17	18204	Porto Nacional
17	18303	Praia Norte
17	18402	Presidente Kennedy
17	18451	Pugmil
17	18501	Recursolândia
17	18550	Riachinho
17	18659	Rio da Conceição
17	18709	Rio dos Bois
17	18758	Rio Sono
17	18808	Sampaio
17	18840	Sandolândia
17	18865	Santa Fé do Araguaia
17	18881	Santa Maria do Tocantins
17	18899	Santa Rita do Tocantins
17	18907	Santa Rosa do Tocantins
17	19004	Santa Tereza do Tocantins
17	20002	Santa Terezinha do Tocantins
17	20101	São Bento do Tocantins
17	20150	São Félix do Tocantins
17	20200	São Miguel do Tocantins
17	20259	São Salvador do Tocantins
17	20309	São Sebastião do Tocantins
17	20499	São Valério
17	20655	Silvanópolis
17	20804	Sítio Novo do Tocantins
17	20853	Sucupira
17	20903	Taguatinga
17	20937	Taipas do Tocantins
17	20978	Talismã
17	21109	Tocantínia
17	21208	Tocantinópolis
17	21257	Tupirama
17	21307	Tupiratins
17	22081	Wanderlândia
17	22107	Xambioá
21	00055	Açailândia
21	00105	Afonso Cunha
21	00154	Água Doce do Maranhão
21	00204	Alcântara
21	00303	Aldeias Altas
21	00402	Altamira do Maranhão
21	00436	Alto Alegre do Maranhão
21	00477	Alto Alegre do Pindaré
21	00501	Alto Parnaíba
21	00550	Amapá do Maranhão
21	00600	Amarante do Maranhão
21	00709	Anajatuba
21	00808	Anapurus
21	00832	Apicum-Açu
21	00873	Araguanã
21	00907	Araioses
21	00956	Arame
21	01004	Arari
21	01103	Axixá
21	01202	Bacabal
21	01251	Bacabeira
21	01301	Bacuri
21	01350	Bacurituba
21	01400	Balsas
21	01509	Barão de Grajaú
21	01608	Barra do Corda
21	01707	Barreirinhas
21	01772	Bela Vista do Maranhão
21	01731	Belágua
21	01806	Benedito Leite
21	01905	Bequimão
21	01939	Bernardo do Mearim
21	01970	Boa Vista do Gurupi
21	02002	Bom Jardim
21	02036	Bom Jesus das Selvas
21	02077	Bom Lugar
21	02101	Brejo
21	02150	Brejo de Areia
21	02200	Buriti
21	02309	Buriti Bravo
21	02325	Buriticupu
21	02358	Buritirana
21	02374	Cachoeira Grande
21	02408	Cajapió
21	02507	Cajari
21	02556	Campestre do Maranhão
21	02606	Cândido Mendes
21	02705	Cantanhede
21	02754	Capinzal do Norte
21	02804	Carolina
21	02903	Carutapera
21	03000	Caxias
21	03109	Cedral
21	03125	Central do Maranhão
21	03158	Centro do Guilherme
21	03174	Centro Novo do Maranhão
21	03208	Chapadinha
21	03257	Cidelândia
21	03307	Codó
21	03406	Coelho Neto
21	03505	Colinas
21	03554	Conceição do Lago-Açu
21	03604	Coroatá
21	03703	Cururupu
21	03752	Davinópolis
21	03802	Dom Pedro
21	03901	Duque Bacelar
21	04008	Esperantinópolis
21	04057	Estreito
21	04073	Feira Nova do Maranhão
21	04081	Fernando Falcão
21	04099	Formosa da Serra Negra
21	04107	Fortaleza dos Nogueiras
21	04206	Fortuna
21	04305	Godofredo Viana
21	04404	Gonçalves Dias
21	04503	Governador Archer
21	04552	Governador Edison Lobão
21	04602	Governador Eugênio Barros
21	04628	Governador Luiz Rocha
21	04651	Governador Newton Bello
21	04677	Governador Nunes Freire
21	04701	Graça Aranha
21	04800	Grajaú
21	04909	Guimarães
21	05005	Humberto de Campos
21	05104	Icatu
21	05153	Igarapé do Meio
21	05203	Igarapé Grande
21	05302	Imperatriz
21	05351	Itaipava do Grajaú
21	05401	Itapecuru Mirim
21	05427	Itinga do Maranhão
21	05450	Jatobá
21	05476	Jenipapo dos Vieiras
21	05500	João Lisboa
21	05609	Joselândia
21	05658	Junco do Maranhão
21	05708	Lago da Pedra
21	05807	Lago do Junco
21	05948	Lago dos Rodrigues
21	05906	Lago Verde
21	05922	Lagoa do Mato
21	05963	Lagoa Grande do Maranhão
21	05989	Lajeado Novo
21	06003	Lima Campos
21	06102	Loreto
21	06201	Luís Domingues
21	06300	Magalhães de Almeida
21	06326	Maracaçumé
21	06359	Marajá do Sena
21	06375	Maranhãozinho
21	06409	Mata Roma
21	06508	Matinha
21	06607	Matões
21	06631	Matões do Norte
21	06672	Milagres do Maranhão
21	06706	Mirador
21	06755	Miranda do Norte
21	06805	Mirinzal
21	06904	Monção
21	07001	Montes Altos
21	07100	Morros
21	07209	Nina Rodrigues
21	07258	Nova Colinas
21	07308	Nova Iorque
21	07357	Nova Olinda do Maranhão
21	07407	Olho d'Água das Cunhãs
21	07456	Olinda Nova do Maranhão
21	07506	Paço do Lumiar
21	07605	Palmeirândia
21	07704	Paraibano
21	07803	Parnarama
21	07902	Passagem Franca
21	08009	Pastos Bons
21	08058	Paulino Neves
21	08108	Paulo Ramos
21	08207	Pedreiras
21	08256	Pedro do Rosário
21	08306	Penalva
21	08405	Peri Mirim
21	08454	Peritoró
21	08504	Pindaré-Mirim
21	08603	Pinheiro
21	08702	Pio XII
21	08801	Pirapemas
21	08900	Poção de Pedras
21	09007	Porto Franco
21	09056	Porto Rico do Maranhão
21	09106	Presidente Dutra
21	09205	Presidente Juscelino
21	09239	Presidente Médici
21	09270	Presidente Sarney
21	09304	Presidente Vargas
21	09403	Primeira Cruz
21	09452	Raposa
21	09502	Riachão
21	09551	Ribamar Fiquene
21	09601	Rosário
21	09700	Sambaíba
21	09759	Santa Filomena do Maranhão
21	09809	Santa Helena
21	09908	Santa Inês
21	10005	Santa Luzia
21	10039	Santa Luzia do Paruá
21	10104	Santa Quitéria do Maranhão
21	10203	Santa Rita
21	10237	Santana do Maranhão
21	10278	Santo Amaro do Maranhão
21	10302	Santo Antônio dos Lopes
21	10401	São Benedito do Rio Preto
21	10500	São Bento
21	10609	São Bernardo
21	10658	São Domingos do Azeitão
21	10708	São Domingos do Maranhão
21	10807	São Félix de Balsas
21	10856	São Francisco do Brejão
21	10906	São Francisco do Maranhão
21	11003	São João Batista
21	11029	São João do Carú
21	11052	São João do Paraíso
21	11078	São João do Soter
21	11102	São João dos Patos
21	11201	São José de Ribamar
21	11250	São José dos Basílios
21	11300	São Luís
21	11409	São Luís Gonzaga do Maranhão
21	11508	São Mateus do Maranhão
21	11532	São Pedro da Água Branca
21	11573	São Pedro dos Crentes
21	11607	São Raimundo das Mangabeiras
21	11631	São Raimundo do Doca Bezerra
21	11672	São Roberto
21	11706	São Vicente Ferrer
21	11722	Satubinha
21	11748	Senador Alexandre Costa
21	11763	Senador La Rocque
21	11789	Serrano do Maranhão
21	11805	Sítio Novo
21	11904	Sucupira do Norte
21	11953	Sucupira do Riachão
21	12001	Tasso Fragoso
21	12100	Timbiras
21	12209	Timon
21	12233	Trizidela do Vale
21	12274	Tufilândia
21	12308	Tuntum
21	12407	Turiaçu
21	12456	Turilândia
21	12506	Tutóia
21	12605	Urbano Santos
21	12704	Vargem Grande
21	12803	Viana
21	12852	Vila Nova dos Martírios
21	12902	Vitória do Mearim
21	13009	Vitorino Freire
21	14007	Zé Doca
22	00053	Acauã
22	00103	Agricolândia
22	00202	Água Branca
22	00251	Alagoinha do Piauí
22	00277	Alegrete do Piauí
22	00301	Alto Longá
22	00400	Altos
22	00459	Alvorada do Gurguéia
22	00509	Amarante
22	00608	Angical do Piauí
22	00707	Anísio de Abreu
22	00806	Antônio Almeida
22	00905	Aroazes
22	00954	Aroeiras do Itaim
22	01002	Arraial
22	01051	Assunção do Piauí
22	01101	Avelino Lopes
22	01150	Baixa Grande do Ribeiro
22	01176	Barra D'Alcântara
22	01200	Barras
22	01309	Barreiras do Piauí
22	01408	Barro Duro
22	01507	Batalha
22	01556	Bela Vista do Piauí
22	01572	Belém do Piauí
22	01606	Beneditinos
22	01705	Bertolínia
22	01739	Betânia do Piauí
22	01770	Boa Hora
22	01804	Bocaina
22	01903	Bom Jesus
22	01919	Bom Princípio do Piauí
22	01929	Bonfim do Piauí
22	01945	Boqueirão do Piauí
22	01960	Brasileira
22	01988	Brejo do Piauí
22	02000	Buriti dos Lopes
22	02026	Buriti dos Montes
22	02059	Cabeceiras do Piauí
22	02075	Cajazeiras do Piauí
22	02083	Cajueiro da Praia
22	02091	Caldeirão Grande do Piauí
22	02109	Campinas do Piauí
22	02117	Campo Alegre do Fidalgo
22	02133	Campo Grande do Piauí
22	02174	Campo Largo do Piauí
22	02208	Campo Maior
22	02251	Canavieira
22	02307	Canto do Buriti
22	02406	Capitão de Campos
22	02455	Capitão Gervásio Oliveira
22	02505	Caracol
22	02539	Caraúbas do Piauí
22	02554	Caridade do Piauí
22	02604	Castelo do Piauí
22	02653	Caxingó
22	02703	Cocal
22	02711	Cocal de Telha
22	02729	Cocal dos Alves
22	02737	Coivaras
22	02752	Colônia do Gurguéia
22	02778	Colônia do Piauí
22	02802	Conceição do Canindé
22	02851	Coronel José Dias
22	02901	Corrente
22	03008	Cristalândia do Piauí
22	03107	Cristino Castro
22	03206	Curimatá
22	03230	Currais
22	03271	Curral Novo do Piauí
22	03255	Curralinhos
22	03305	Demerval Lobão
22	03354	Dirceu Arcoverde
22	03404	Dom Expedito Lopes
22	03453	Dom Inocêncio
22	03420	Domingos Mourão
22	03503	Elesbão Veloso
22	03602	Eliseu Martins
22	03701	Esperantina
22	03750	Fartura do Piauí
22	03800	Flores do Piauí
22	03859	Floresta do Piauí
22	03909	Floriano
22	04006	Francinópolis
22	04105	Francisco Ayres
22	04154	Francisco Macedo
22	04204	Francisco Santos
22	04303	Fronteiras
22	04352	Geminiano
22	04402	Gilbués
22	04501	Guadalupe
22	04550	Guaribas
22	04600	Hugo Napoleão
22	04659	Ilha Grande
22	04709	Inhuma
22	04808	Ipiranga do Piauí
22	04907	Isaías Coelho
22	05003	Itainópolis
22	05102	Itaueira
22	05151	Jacobina do Piauí
22	05201	Jaicós
22	05250	Jardim do Mulato
22	05276	Jatobá do Piauí
22	05300	Jerumenha
22	05359	João Costa
22	05409	Joaquim Pires
22	05458	Joca Marques
22	05508	José de Freitas
22	05516	Juazeiro do Piauí
22	05524	Júlio Borges
22	05532	Jurema
22	05557	Lagoa Alegre
22	05573	Lagoa de São Francisco
22	05565	Lagoa do Barro do Piauí
22	05581	Lagoa do Piauí
22	05599	Lagoa do Sítio
22	05540	Lagoinha do Piauí
22	05607	Landri Sales
22	05706	Luís Correia
22	05805	Luzilândia
22	05854	Madeiro
22	05904	Manoel Emídio
22	05953	Marcolândia
22	06001	Marcos Parente
22	06050	Massapê do Piauí
22	06100	Matias Olímpio
22	06209	Miguel Alves
22	06308	Miguel Leão
22	06357	Milton Brandão
22	06407	Monsenhor Gil
22	06506	Monsenhor Hipólito
22	06605	Monte Alegre do Piauí
22	06654	Morro Cabeça no Tempo
22	06670	Morro do Chapéu do Piauí
22	06696	Murici dos Portelas
22	06704	Nazaré do Piauí
22	06720	Nazária
22	06753	Nossa Senhora de Nazaré
22	06803	Nossa Senhora dos Remédios
22	07959	Nova Santa Rita
22	06902	Novo Oriente do Piauí
22	06951	Novo Santo Antônio
22	07009	Oeiras
22	07108	Olho D'Água do Piauí
22	07207	Padre Marcos
22	07306	Paes Landim
22	07355	Pajeú do Piauí
22	07405	Palmeira do Piauí
22	07504	Palmeirais
22	07553	Paquetá
22	07603	Parnaguá
22	07702	Parnaíba
22	07751	Passagem Franca do Piauí
22	07777	Patos do Piauí
22	07793	Pau D'Arco do Piauí
22	07801	Paulistana
22	07850	Pavussu
22	07900	Pedro II
22	07934	Pedro Laurentino
22	08007	Picos
22	08106	Pimenteiras
22	08205	Pio IX
22	08304	Piracuruca
22	08403	Piripiri
22	08502	Porto
22	08551	Porto Alegre do Piauí
22	08601	Prata do Piauí
22	08650	Queimada Nova
22	08700	Redenção do Gurguéia
22	08809	Regeneração
22	08858	Riacho Frio
22	08874	Ribeira do Piauí
22	08908	Ribeiro Gonçalves
22	09005	Rio Grande do Piauí
22	09104	Santa Cruz do Piauí
22	09153	Santa Cruz dos Milagres
22	09203	Santa Filomena
22	09302	Santa Luz
22	09377	Santa Rosa do Piauí
22	09351	Santana do Piauí
22	09401	Santo Antônio de Lisboa
22	09450	Santo Antônio dos Milagres
22	09500	Santo Inácio do Piauí
22	09559	São Braz do Piauí
22	09609	São Félix do Piauí
22	09658	São Francisco de Assis do Piauí
22	09708	São Francisco do Piauí
22	09757	São Gonçalo do Gurguéia
22	09807	São Gonçalo do Piauí
22	09856	São João da Canabrava
22	09872	São João da Fronteira
22	09906	São João da Serra
22	09955	São João da Varjota
22	09971	São João do Arraial
22	10003	São João do Piauí
22	10052	São José do Divino
22	10102	São José do Peixe
22	10201	São José do Piauí
22	10300	São Julião
22	10359	São Lourenço do Piauí
22	10375	São Luis do Piauí
22	10383	São Miguel da Baixa Grande
22	10391	São Miguel do Fidalgo
22	10409	São Miguel do Tapuio
22	10508	São Pedro do Piauí
22	10607	São Raimundo Nonato
22	10623	Sebastião Barros
22	10631	Sebastião Leal
22	10656	Sigefredo Pacheco
22	10706	Simões
22	10805	Simplício Mendes
22	10904	Socorro do Piauí
22	10938	Sussuapara
22	10953	Tamboril do Piauí
22	10979	Tanque do Piauí
22	11001	Teresina
22	11100	União
22	11209	Uruçuí
22	11308	Valença do Piauí
22	11357	Várzea Branca
22	11407	Várzea Grande
22	11506	Vera Mendes
22	11605	Vila Nova do Piauí
22	11704	Wall Ferraz
23	00101	Abaiara
23	00150	Acarape
23	00200	Acaraú
23	00309	Acopiara
23	00408	Aiuaba
23	00507	Alcântaras
23	00606	Altaneira
23	00705	Alto Santo
23	00754	Amontada
23	00804	Antonina do Norte
23	00903	Apuiarés
23	01000	Aquiraz
23	01109	Aracati
23	01208	Aracoiaba
23	01257	Ararendá
23	01307	Araripe
23	01406	Aratuba
23	01505	Arneiroz
23	01604	Assaré
23	01703	Aurora
23	01802	Baixio
23	01851	Banabuiú
23	01901	Barbalha
23	01950	Barreira
23	02008	Barro
23	02057	Barroquinha
23	02107	Baturité
23	02206	Beberibe
23	02305	Bela Cruz
23	02404	Boa Viagem
23	02503	Brejo Santo
23	02602	Camocim
23	02701	Campos Sales
23	02800	Canindé
23	02909	Capistrano
23	03006	Caridade
23	03105	Cariré
23	03204	Caririaçu
23	03303	Cariús
23	03402	Carnaubal
23	03501	Cascavel
23	03600	Catarina
23	03659	Catunda
23	03709	Caucaia
23	03808	Cedro
23	03907	Chaval
23	03931	Choró
23	03956	Chorozinho
23	04004	Coreaú
23	04103	Crateús
23	04202	Crato
23	04236	Croatá
23	04251	Cruz
23	04269	Deputado Irapuan Pinheiro
23	04277	Ererê
23	04285	Eusébio
23	04301	Farias Brito
23	04350	Forquilha
23	04400	Fortaleza
23	04459	Fortim
23	04509	Frecheirinha
23	04608	General Sampaio
23	04657	Graça
23	04707	Granja
23	04806	Granjeiro
23	04905	Groaíras
23	04954	Guaiúba
23	05001	Guaraciaba do Norte
23	05100	Guaramiranga
23	05209	Hidrolândia
23	05233	Horizonte
23	05266	Ibaretama
23	05308	Ibiapina
23	05332	Ibicuitinga
23	05357	Icapuí
23	05407	Icó
23	05506	Iguatu
23	05605	Independência
23	05654	Ipaporanga
23	05704	Ipaumirim
23	05803	Ipu
23	05902	Ipueiras
23	06009	Iracema
23	06108	Irauçuba
23	06207	Itaiçaba
23	06256	Itaitinga
23	06306	Itapajé
23	06405	Itapipoca
23	06504	Itapiúna
23	06553	Itarema
23	06603	Itatira
23	06702	Jaguaretama
23	06801	Jaguaribara
23	06900	Jaguaribe
23	07007	Jaguaruana
23	07106	Jardim
23	07205	Jati
23	07254	Jijoca de Jericoacoara
23	07304	Juazeiro do Norte
23	07403	Jucás
23	07502	Lavras da Mangabeira
23	07601	Limoeiro do Norte
23	07635	Madalena
23	07650	Maracanaú
23	07700	Maranguape
23	07809	Marco
23	07908	Martinópole
23	08005	Massapê
23	08104	Mauriti
23	08203	Meruoca
23	08302	Milagres
23	08351	Milhã
23	08377	Miraíma
23	08401	Missão Velha
23	08500	Mombaça
23	08609	Monsenhor Tabosa
23	08708	Morada Nova
23	08807	Moraújo
23	08906	Morrinhos
23	09003	Mucambo
23	09102	Mulungu
23	09201	Nova Olinda
23	09300	Nova Russas
23	09409	Novo Oriente
23	09458	Ocara
23	09508	Orós
23	09607	Pacajus
23	09706	Pacatuba
23	09805	Pacoti
23	09904	Pacujá
23	10001	Palhano
23	10100	Palmácia
23	10209	Paracuru
23	10258	Paraipaba
23	10308	Parambu
23	10407	Paramoti
23	10506	Pedra Branca
23	10605	Penaforte
23	10704	Pentecoste
23	10803	Pereiro
23	10852	Pindoretama
23	10902	Piquet Carneiro
23	10951	Pires Ferreira
23	11009	Poranga
23	11108	Porteiras
23	11207	Potengi
23	11231	Potiretama
23	11264	Quiterianópolis
23	11306	Quixadá
23	11355	Quixelô
23	11405	Quixeramobim
23	11504	Quixeré
23	11603	Redenção
23	11702	Reriutaba
23	11801	Russas
23	11900	Saboeiro
23	11959	Salitre
23	12205	Santa Quitéria
23	12007	Santana do Acaraú
23	12106	Santana do Cariri
23	12304	São Benedito
23	12403	São Gonçalo do Amarante
23	12502	São João do Jaguaribe
23	12601	São Luís do Curu
23	12700	Senador Pompeu
23	12809	Senador Sá
23	12908	Sobral
23	13005	Solonópole
23	13104	Tabuleiro do Norte
23	13203	Tamboril
23	13252	Tarrafas
23	13302	Tauá
23	13351	Tejuçuoca
23	13401	Tianguá
23	13500	Trairi
23	13559	Tururu
23	13609	Ubajara
23	13708	Umari
23	13757	Umirim
23	13807	Uruburetama
23	13906	Uruoca
23	13955	Varjota
23	14003	Várzea Alegre
23	14102	Viçosa do Ceará
24	00109	Acari
24	00208	Açu
24	00307	Afonso Bezerra
24	00406	Água Nova
24	00505	Alexandria
24	00604	Almino Afonso
24	00703	Alto do Rodrigues
24	00802	Angicos
24	00901	Antônio Martins
24	01008	Apodi
24	01107	Areia Branca
24	01206	Arês
24	01305	Augusto Severo
24	01404	Baía Formosa
24	01453	Baraúna
24	01503	Barcelona
24	01602	Bento Fernandes
24	01651	Bodó
24	01701	Bom Jesus
24	01800	Brejinho
24	01859	Caiçara do Norte
24	01909	Caiçara do Rio do Vento
24	02006	Caicó
24	02105	Campo Redondo
24	02204	Canguaretama
24	02303	Caraúbas
24	02402	Carnaúba dos Dantas
24	02501	Carnaubais
24	02600	Ceará-Mirim
24	02709	Cerro Corá
24	02808	Coronel Ezequiel
24	02907	Coronel João Pessoa
24	03004	Cruzeta
24	03103	Currais Novos
24	03202	Doutor Severiano
24	03301	Encanto
24	03400	Equador
24	03509	Espírito Santo
24	03608	Extremoz
24	03707	Felipe Guerra
24	03756	Fernando Pedroza
24	03806	Florânia
24	03905	Francisco Dantas
24	04002	Frutuoso Gomes
24	04101	Galinhos
24	04200	Goianinha
24	04309	Governador Dix-Sept Rosado
24	04408	Grossos
24	04507	Guamaré
24	04606	Ielmo Marinho
24	04705	Ipanguaçu
24	04804	Ipueira
24	04853	Itajá
24	04903	Itaú
24	05009	Jaçanã
24	05108	Jandaíra
24	05207	Janduís
24	05306	Januário Cicco
24	05405	Japi
24	05504	Jardim de Angicos
24	05603	Jardim de Piranhas
24	05702	Jardim do Seridó
24	05801	João Câmara
24	05900	João Dias
24	06007	José da Penha
24	06106	Jucurutu
24	06155	Jundiá
24	06205	Lagoa d'Anta
24	06304	Lagoa de Pedras
24	06403	Lagoa de Velhos
24	06502	Lagoa Nova
24	06601	Lagoa Salgada
24	06700	Lajes
24	06809	Lajes Pintadas
24	06908	Lucrécia
24	07005	Luís Gomes
24	07104	Macaíba
24	07203	Macau
24	07252	Major Sales
24	07302	Marcelino Vieira
24	07401	Martins
24	07500	Maxaranguape
24	07609	Messias Targino
24	07708	Montanhas
24	07807	Monte Alegre
24	07906	Monte das Gameleiras
24	08003	Mossoró
24	08102	Natal
24	08201	Nísia Floresta
24	08300	Nova Cruz
24	08409	Olho d'Água do Borges
24	08508	Ouro Branco
24	08607	Paraná
24	08706	Paraú
24	08805	Parazinho
24	08904	Parelhas
24	03251	Parnamirim
24	09100	Passa e Fica
24	09209	Passagem
24	09308	Patu
24	09407	Pau dos Ferros
24	09506	Pedra Grande
24	09605	Pedra Preta
24	09704	Pedro Avelino
24	09803	Pedro Velho
24	09902	Pendências
24	10009	Pilões
24	10108	Poço Branco
24	10207	Portalegre
24	10256	Porto do Mangue
24	10405	Pureza
24	10504	Rafael Fernandes
24	10603	Rafael Godeiro
24	10702	Riacho da Cruz
24	10801	Riacho de Santana
24	10900	Riachuelo
24	08953	Rio do Fogo
24	11007	Rodolfo Fernandes
24	11106	Ruy Barbosa
24	11205	Santa Cruz
24	09332	Santa Maria
24	11403	Santana do Matos
24	11429	Santana do Seridó
24	11502	Santo Antônio
24	11601	São Bento do Norte
24	11700	São Bento do Trairí
24	11809	São Fernando
24	11908	São Francisco do Oeste
24	12005	São Gonçalo do Amarante
24	12104	São João do Sabugi
24	12203	São José de Mipibu
24	12302	São José do Campestre
24	12401	São José do Seridó
24	12500	São Miguel
24	12559	São Miguel do Gostoso
24	12609	São Paulo do Potengi
24	12708	São Pedro
24	12807	São Rafael
24	12906	São Tomé
24	13003	São Vicente
24	13102	Senador Elói de Souza
24	13201	Senador Georgino Avelino
24	10306	Serra Caiada
24	13300	Serra de São Bento
24	13359	Serra do Mel
24	13409	Serra Negra do Norte
24	13508	Serrinha
24	13557	Serrinha dos Pintos
24	13607	Severiano Melo
24	13706	Sítio Novo
24	13805	Taboleiro Grande
24	13904	Taipu
24	14001	Tangará
24	14100	Tenente Ananias
24	14159	Tenente Laurentino Cruz
24	11056	Tibau
24	14209	Tibau do Sul
24	14308	Timbaúba dos Batistas
24	14407	Touros
24	14456	Triunfo Potiguar
24	14506	Umarizal
24	14605	Upanema
24	14704	Várzea
24	14753	Venha-Ver
24	14803	Vera Cruz
24	14902	Viçosa
24	15008	Vila Flor
25	00106	Água Branca
25	00205	Aguiar
25	00304	Alagoa Grande
25	00403	Alagoa Nova
25	00502	Alagoinha
25	00536	Alcantil
25	00577	Algodão de Jandaíra
25	00601	Alhandra
25	00734	Amparo
25	00775	Aparecida
25	00809	Araçagi
25	00908	Arara
25	01005	Araruna
25	01104	Areia
25	01153	Areia de Baraúnas
25	01203	Areial
25	01302	Aroeiras
25	01351	Assunção
25	01401	Baía da Traição
25	01500	Bananeiras
25	01534	Baraúna
25	01609	Barra de Santa Rosa
25	01575	Barra de Santana
25	01708	Barra de São Miguel
25	01807	Bayeux
25	01906	Belém
25	02003	Belém do Brejo do Cruz
25	02052	Bernardino Batista
25	02102	Boa Ventura
25	02151	Boa Vista
25	02201	Bom Jesus
25	02300	Bom Sucesso
25	02409	Bonito de Santa Fé
25	02508	Boqueirão
25	02706	Borborema
25	02805	Brejo do Cruz
25	02904	Brejo dos Santos
25	03001	Caaporã
25	03100	Cabaceiras
25	03209	Cabedelo
25	03308	Cachoeira dos Índios
25	03407	Cacimba de Areia
25	03506	Cacimba de Dentro
25	03555	Cacimbas
25	03605	Caiçara
25	03704	Cajazeiras
25	03753	Cajazeirinhas
25	03803	Caldas Brandão
25	03902	Camalaú
25	04009	Campina Grande
25	04033	Capim
25	04074	Caraúbas
25	04108	Carrapateira
25	04157	Casserengue
25	04207	Catingueira
25	04306	Catolé do Rocha
25	04355	Caturité
25	04405	Conceição
25	04504	Condado
25	04603	Conde
25	04702	Congo
25	04801	Coremas
25	04850	Coxixola
25	04900	Cruz do Espírito Santo
25	05006	Cubati
25	05105	Cuité
25	05238	Cuité de Mamanguape
25	05204	Cuitegi
25	05279	Curral de Cima
25	05303	Curral Velho
25	05352	Damião
25	05402	Desterro
25	05600	Diamante
25	05709	Dona Inês
25	05808	Duas Estradas
25	05907	Emas
25	06004	Esperança
25	06103	Fagundes
25	06202	Frei Martinho
25	06251	Gado Bravo
25	06301	Guarabira
25	06400	Gurinhém
25	06509	Gurjão
25	06608	Ibiara
25	02607	Igaracy
25	06707	Imaculada
25	06806	Ingá
25	06905	Itabaiana
25	07002	Itaporanga
25	07101	Itapororoca
25	07200	Itatuba
25	07309	Jacaraú
25	07408	Jericó
25	07507	João Pessoa
25	13653	Joca Claudino
25	07606	Juarez Távora
25	07705	Juazeirinho
25	07804	Junco do Seridó
25	07903	Juripiranga
25	08000	Juru
25	08109	Lagoa
25	08208	Lagoa de Dentro
25	08307	Lagoa Seca
25	08406	Lastro
25	08505	Livramento
25	08554	Logradouro
25	08604	Lucena
25	08703	Mãe d'Água
25	08802	Malta
25	08901	Mamanguape
25	09008	Manaíra
25	09057	Marcação
25	09107	Mari
25	09156	Marizópolis
25	09206	Massaranduba
25	09305	Mataraca
25	09339	Matinhas
25	09370	Mato Grosso
25	09396	Maturéia
25	09404	Mogeiro
25	09503	Montadas
25	09602	Monte Horebe
25	09701	Monteiro
25	09800	Mulungu
25	09909	Natuba
25	10006	Nazarezinho
25	10105	Nova Floresta
25	10204	Nova Olinda
25	10303	Nova Palmeira
25	10402	Olho d'Água
25	10501	Olivedos
25	10600	Ouro Velho
25	10659	Parari
25	10709	Passagem
25	10808	Patos
25	10907	Paulista
25	11004	Pedra Branca
25	11103	Pedra Lavrada
25	11202	Pedras de Fogo
25	12721	Pedro Régis
25	11301	Piancó
25	11400	Picuí
25	11509	Pilar
25	11608	Pilões
25	11707	Pilõezinhos
25	11806	Pirpirituba
25	11905	Pitimbu
25	12002	Pocinhos
25	12036	Poço Dantas
25	12077	Poço de José de Moura
25	12101	Pombal
25	12200	Prata
25	12309	Princesa Isabel
25	12408	Puxinanã
25	12507	Queimadas
25	12606	Quixaba
25	12705	Remígio
25	12747	Riachão
25	12754	Riachão do Bacamarte
25	12762	Riachão do Poço
25	12788	Riacho de Santo Antônio
25	12804	Riacho dos Cavalos
25	12903	Rio Tinto
25	13000	Salgadinho
25	13109	Salgado de São Félix
25	13158	Santa Cecília
25	13208	Santa Cruz
25	13307	Santa Helena
25	13356	Santa Inês
25	13406	Santa Luzia
25	13703	Santa Rita
25	13802	Santa Teresinha
25	13505	Santana de Mangueira
25	13604	Santana dos Garrotes
25	13851	Santo André
25	13927	São Bentinho
25	13901	São Bento
25	13968	São Domingos
25	13943	São Domingos do Cariri
25	13984	São Francisco
25	14008	São João do Cariri
25	00700	São João do Rio do Peixe
25	14107	São João do Tigre
25	14206	São José da Lagoa Tapada
25	14305	São José de Caiana
25	14404	São José de Espinharas
25	14503	São José de Piranhas
25	14552	São José de Princesa
25	14602	São José do Bonfim
25	14651	São José do Brejo do Cruz
25	14701	São José do Sabugi
25	14800	São José dos Cordeiros
25	14453	São José dos Ramos
25	14909	São Mamede
25	15005	São Miguel de Taipu
25	15104	São Sebastião de Lagoa de Roça
25	15203	São Sebastião do Umbuzeiro
25	15401	São Vicente do Seridó
25	15302	Sapé
25	15500	Serra Branca
25	15609	Serra da Raiz
25	15708	Serra Grande
25	15807	Serra Redonda
25	15906	Serraria
25	15930	Sertãozinho
25	15971	Sobrado
25	16003	Solânea
25	16102	Soledade
25	16151	Sossêgo
25	16201	Sousa
25	16300	Sumé
25	16409	Tacima
25	16508	Taperoá
25	16607	Tavares
25	16706	Teixeira
25	16755	Tenório
25	16805	Triunfo
25	16904	Uiraúna
25	17001	Umbuzeiro
25	17100	Várzea
25	17209	Vieirópolis
25	05501	Vista Serrana
25	17407	Zabelê
26	00054	Abreu e Lima
26	00104	Afogados da Ingazeira
26	00203	Afrânio
26	00302	Agrestina
26	00401	Água Preta
26	00500	Águas Belas
26	00609	Alagoinha
26	00708	Aliança
26	00807	Altinho
26	00906	Amaraji
26	01003	Angelim
26	01052	Araçoiaba
26	01102	Araripina
26	01201	Arcoverde
26	01300	Barra de Guabiraba
26	01409	Barreiros
26	01508	Belém de Maria
26	01607	Belém do São Francisco
26	01706	Belo Jardim
26	01805	Betânia
26	01904	Bezerros
26	02001	Bodocó
26	02100	Bom Conselho
26	02209	Bom Jardim
26	02308	Bonito
26	02407	Brejão
26	02506	Brejinho
26	02605	Brejo da Madre de Deus
26	02704	Buenos Aires
26	02803	Buíque
26	02902	Cabo de Santo Agostinho
26	03009	Cabrobó
26	03108	Cachoeirinha
26	03207	Caetés
26	03306	Calçado
26	03405	Calumbi
26	03454	Camaragibe
26	03504	Camocim de São Félix
26	03603	Camutanga
26	03702	Canhotinho
26	03801	Capoeiras
26	03900	Carnaíba
26	03926	Carnaubeira da Penha
26	04007	Carpina
26	04106	Caruaru
26	04155	Casinhas
26	04205	Catende
26	04304	Cedro
26	04403	Chã de Alegria
26	04502	Chã Grande
26	04601	Condado
26	04700	Correntes
26	04809	Cortês
26	04908	Cumaru
26	05004	Cupira
26	05103	Custódia
26	05152	Dormentes
26	05202	Escada
26	05301	Exu
26	05400	Feira Nova
26	05459	Fernando de Noronha
26	05509	Ferreiros
26	05608	Flores
26	05707	Floresta
26	05806	Frei Miguelinho
26	05905	Gameleira
26	06002	Garanhuns
26	06101	Glória do Goitá
26	06200	Goiana
26	06309	Granito
26	06408	Gravatá
26	06507	Iati
26	06606	Ibimirim
26	06705	Ibirajuba
26	06804	Igarassu
26	06903	Iguaracy
26	07604	Ilha de Itamaracá
26	07000	Inajá
26	07109	Ingazeira
26	07208	Ipojuca
26	07307	Ipubi
26	07406	Itacuruba
26	07505	Itaíba
26	07653	Itambé
26	07703	Itapetim
26	07752	Itapissuma
26	07802	Itaquitinga
26	07901	Jaboatão dos Guararapes
26	07950	Jaqueira
26	08008	Jataúba
26	08057	Jatobá
26	08107	João Alfredo
26	08206	Joaquim Nabuco
26	08255	Jucati
26	08305	Jupi
26	08404	Jurema
26	08503	Lagoa de Itaenga
26	08453	Lagoa do Carro
26	08602	Lagoa do Ouro
26	08701	Lagoa dos Gatos
26	08750	Lagoa Grande
26	08800	Lajedo
26	08909	Limoeiro
26	09006	Macaparana
26	09105	Machados
26	09154	Manari
26	09204	Maraial
26	09303	Mirandiba
26	14303	Moreilândia
26	09402	Moreno
26	09501	Nazaré da Mata
26	09600	Olinda
26	09709	Orobó
26	09808	Orocó
26	09907	Ouricuri
26	10004	Palmares
26	10103	Palmeirina
26	10202	Panelas
26	10301	Paranatama
26	10400	Parnamirim
26	10509	Passira
26	10608	Paudalho
26	10707	Paulista
26	10806	Pedra
26	10905	Pesqueira
26	11002	Petrolândia
26	11101	Petrolina
26	11200	Poção
26	11309	Pombos
26	11408	Primavera
26	11507	Quipapá
26	11533	Quixaba
26	11606	Recife
26	11705	Riacho das Almas
26	11804	Ribeirão
26	11903	Rio Formoso
26	12000	Sairé
26	12109	Salgadinho
26	12208	Salgueiro
26	12307	Saloá
26	12406	Sanharó
26	12455	Santa Cruz
26	12471	Santa Cruz da Baixa Verde
26	12505	Santa Cruz do Capibaribe
26	12554	Santa Filomena
26	12604	Santa Maria da Boa Vista
26	12703	Santa Maria do Cambucá
26	12802	Santa Terezinha
26	12901	São Benedito do Sul
26	13008	São Bento do Una
26	13107	São Caitano
26	13206	São João
26	13305	São Joaquim do Monte
26	13404	São José da Coroa Grande
26	13503	São José do Belmonte
26	13602	São José do Egito
26	13701	São Lourenço da Mata
26	13800	São Vicente Férrer
26	13909	Serra Talhada
26	14006	Serrita
26	14105	Sertânia
26	14204	Sirinhaém
26	14402	Solidão
26	14501	Surubim
26	14600	Tabira
26	14709	Tacaimbó
26	14808	Tacaratu
26	14857	Tamandaré
26	15003	Taquaritinga do Norte
26	15102	Terezinha
26	15201	Terra Nova
26	15300	Timbaúba
26	15409	Toritama
26	15508	Tracunhaém
26	15607	Trindade
26	15706	Triunfo
26	15805	Tupanatinga
26	15904	Tuparetama
26	16001	Venturosa
26	16100	Verdejante
26	16183	Vertente do Lério
26	16209	Vertentes
26	16308	Vicência
26	16407	Vitória de Santo Antão
26	16506	Xexéu
27	00102	Água Branca
27	00201	Anadia
27	00300	Arapiraca
27	00409	Atalaia
27	00508	Barra de Santo Antônio
27	00607	Barra de São Miguel
27	00706	Batalha
27	00805	Belém
27	00904	Belo Monte
27	01001	Boca da Mata
27	01100	Branquinha
27	01209	Cacimbinhas
27	01308	Cajueiro
27	01357	Campestre
27	01407	Campo Alegre
27	01506	Campo Grande
27	01605	Canapi
27	01704	Capela
27	01803	Carneiros
27	01902	Chã Preta
27	02009	Coité do Nóia
27	02108	Colônia Leopoldina
27	02207	Coqueiro Seco
27	02306	Coruripe
27	02355	Craíbas
27	02405	Delmiro Gouveia
27	02504	Dois Riachos
27	02553	Estrela de Alagoas
27	02603	Feira Grande
27	02702	Feliz Deserto
27	02801	Flexeiras
27	02900	Girau do Ponciano
27	03007	Ibateguara
27	03106	Igaci
27	03205	Igreja Nova
27	03304	Inhapi
27	03403	Jacaré dos Homens
27	03502	Jacuípe
27	03601	Japaratinga
27	03700	Jaramataia
27	03759	Jequiá da Praia
27	03809	Joaquim Gomes
27	03908	Jundiá
27	04005	Junqueiro
27	04104	Lagoa da Canoa
27	04203	Limoeiro de Anadia
27	04302	Maceió
27	04401	Major Isidoro
27	04906	Mar Vermelho
27	04500	Maragogi
27	04609	Maravilha
27	04708	Marechal Deodoro
27	04807	Maribondo
27	05002	Mata Grande
27	05101	Matriz de Camaragibe
27	05200	Messias
27	05309	Minador do Negrão
27	05408	Monteirópolis
27	05507	Murici
27	05606	Novo Lino
27	05705	Olho d'Água das Flores
27	05804	Olho d'Água do Casado
27	05903	Olho d'Água Grande
27	06000	Olivença
27	06109	Ouro Branco
27	06208	Palestina
27	06307	Palmeira dos Índios
27	06406	Pão de Açúcar
27	06422	Pariconha
27	06448	Paripueira
27	06505	Passo de Camaragibe
27	06604	Paulo Jacinto
27	06703	Penedo
27	06802	Piaçabuçu
27	06901	Pilar
27	07008	Pindoba
27	07107	Piranhas
27	07206	Poço das Trincheiras
27	07305	Porto Calvo
27	07404	Porto de Pedras
27	07503	Porto Real do Colégio
27	07602	Quebrangulo
27	07701	Rio Largo
27	07800	Roteiro
27	07909	Santa Luzia do Norte
27	08006	Santana do Ipanema
27	08105	Santana do Mundaú
27	08204	São Brás
27	08303	São José da Laje
27	08402	São José da Tapera
27	08501	São Luís do Quitunde
27	08600	São Miguel dos Campos
27	08709	São Miguel dos Milagres
27	08808	São Sebastião
27	08907	Satuba
27	08956	Senador Rui Palmeira
27	09004	Tanque d'Arca
27	09103	Taquarana
27	09152	Teotônio Vilela
27	09202	Traipu
27	09301	União dos Palmares
27	09400	Viçosa
28	00100	Amparo de São Francisco
28	00209	Aquidabã
28	00308	Aracaju
28	00407	Arauá
28	00506	Areia Branca
28	00605	Barra dos Coqueiros
28	00670	Boquim
28	00704	Brejo Grande
28	01009	Campo do Brito
28	01108	Canhoba
28	01207	Canindé de São Francisco
28	01306	Capela
28	01405	Carira
28	01504	Carmópolis
28	01603	Cedro de São João
28	01702	Cristinápolis
28	01900	Cumbe
28	02007	Divina Pastora
28	02106	Estância
28	02205	Feira Nova
28	02304	Frei Paulo
28	02403	Gararu
28	02502	General Maynard
28	02601	Gracho Cardoso
28	02700	Ilha das Flores
28	02809	Indiaroba
28	02908	Itabaiana
28	03005	Itabaianinha
28	03104	Itabi
28	03203	Itaporanga d'Ajuda
28	03302	Japaratuba
28	03401	Japoatã
28	03500	Lagarto
28	03609	Laranjeiras
28	03708	Macambira
28	03807	Malhada dos Bois
28	03906	Malhador
28	04003	Maruim
28	04102	Moita Bonita
28	04201	Monte Alegre de Sergipe
28	04300	Muribeca
28	04409	Neópolis
28	04458	Nossa Senhora Aparecida
28	04508	Nossa Senhora da Glória
28	04607	Nossa Senhora das Dores
28	04706	Nossa Senhora de Lourdes
28	04805	Nossa Senhora do Socorro
28	04904	Pacatuba
28	05000	Pedra Mole
28	05109	Pedrinhas
28	05208	Pinhão
28	05307	Pirambu
28	05406	Poço Redondo
28	05505	Poço Verde
28	05604	Porto da Folha
28	05703	Propriá
28	05802	Riachão do Dantas
28	05901	Riachuelo
28	06008	Ribeirópolis
28	06107	Rosário do Catete
28	06206	Salgado
28	06305	Santa Luzia do Itanhy
28	06503	Santa Rosa de Lima
28	06404	Santana do São Francisco
28	06602	Santo Amaro das Brotas
28	06701	São Cristóvão
28	06800	São Domingos
28	06909	São Francisco
28	07006	São Miguel do Aleixo
28	07105	Simão Dias
28	07204	Siriri
28	07303	Telha
28	07402	Tobias Barreto
28	07501	Tomar do Geru
28	07600	Umbaúba
29	00108	Abaíra
29	00207	Abaré
29	00306	Acajutiba
29	00355	Adustina
29	00405	Água Fria
29	00603	Aiquara
29	00702	Alagoinhas
29	00801	Alcobaça
29	00900	Almadina
29	01007	Amargosa
29	01106	Amélia Rodrigues
29	01155	América Dourada
29	01205	Anagé
29	01304	Andaraí
29	01353	Andorinha
29	01403	Angical
29	01502	Anguera
29	01601	Antas
29	01700	Antônio Cardoso
29	01809	Antônio Gonçalves
29	01908	Aporá
29	01957	Apuarema
29	02054	Araçás
29	02005	Aracatu
29	02104	Araci
29	02203	Aramari
29	02252	Arataca
29	02302	Aratuípe
29	02401	Aurelino Leal
29	02500	Baianópolis
29	02609	Baixa Grande
29	02658	Banzaê
29	02708	Barra
29	02807	Barra da Estiva
29	02906	Barra do Choça
29	03003	Barra do Mendes
29	03102	Barra do Rocha
29	03201	Barreiras
29	03235	Barro Alto
29	03300	Barro Preto
29	03276	Barrocas
29	03409	Belmonte
29	03508	Belo Campo
29	03607	Biritinga
29	03706	Boa Nova
29	03805	Boa Vista do Tupim
29	03904	Bom Jesus da Lapa
29	03953	Bom Jesus da Serra
29	04001	Boninal
29	04050	Bonito
29	04100	Boquira
29	04209	Botuporã
29	04308	Brejões
29	04407	Brejolândia
29	04506	Brotas de Macaúbas
29	04605	Brumado
29	04704	Buerarema
29	04753	Buritirama
29	04803	Caatiba
29	04852	Cabaceiras do Paraguaçu
29	04902	Cachoeira
29	05008	Caculé
29	05107	Caém
29	05156	Caetanos
29	05206	Caetité
29	05305	Cafarnaum
29	05404	Cairu
29	05503	Caldeirão Grande
29	05602	Camacan
29	05701	Camaçari
29	05800	Camamu
29	05909	Campo Alegre de Lourdes
29	06006	Campo Formoso
29	06105	Canápolis
29	06204	Canarana
29	06303	Canavieiras
29	06402	Candeal
29	06501	Candeias
29	06600	Candiba
29	06709	Cândido Sales
29	06808	Cansanção
29	06824	Canudos
29	06857	Capela do Alto Alegre
29	06873	Capim Grosso
29	06899	Caraíbas
29	06907	Caravelas
29	07004	Cardeal da Silva
29	07103	Carinhanha
29	07202	Casa Nova
29	07301	Castro Alves
29	07400	Catolândia
29	07509	Catu
29	07558	Caturama
29	07608	Central
29	07707	Chorrochó
29	07806	Cícero Dantas
29	07905	Cipó
29	08002	Coaraci
29	08101	Cocos
29	08200	Conceição da Feira
29	08309	Conceição do Almeida
29	08408	Conceição do Coité
29	08507	Conceição do Jacuípe
29	08606	Conde
29	08705	Condeúba
29	08804	Contendas do Sincorá
29	08903	Coração de Maria
29	09000	Cordeiros
29	09109	Coribe
29	09208	Coronel João Sá
29	09307	Correntina
29	09406	Cotegipe
29	09505	Cravolândia
29	09604	Crisópolis
29	09703	Cristópolis
29	09802	Cruz das Almas
29	09901	Curaçá
29	10008	Dário Meira
29	10057	Dias d'Ávila
29	10107	Dom Basílio
29	10206	Dom Macedo Costa
29	10305	Elísio Medrado
29	10404	Encruzilhada
29	10503	Entre Rios
29	00504	Érico Cardoso
29	10602	Esplanada
29	10701	Euclides da Cunha
29	10727	Eunápolis
29	10750	Fátima
29	10776	Feira da Mata
29	10800	Feira de Santana
29	10859	Filadélfia
29	10909	Firmino Alves
29	11006	Floresta Azul
29	11105	Formosa do Rio Preto
29	11204	Gandu
29	11253	Gavião
29	11303	Gentio do Ouro
29	11402	Glória
29	11501	Gongogi
29	11600	Governador Mangabeira
29	11659	Guajeru
29	11709	Guanambi
29	11808	Guaratinga
29	11857	Heliópolis
29	11907	Iaçu
29	12004	Ibiassucê
29	12103	Ibicaraí
29	12202	Ibicoara
29	12301	Ibicuí
29	12400	Ibipeba
29	12509	Ibipitanga
29	12608	Ibiquera
29	12707	Ibirapitanga
29	12806	Ibirapuã
29	12905	Ibirataia
29	13002	Ibitiara
29	13101	Ibititá
29	13200	Ibotirama
29	13309	Ichu
29	13408	Igaporã
29	13457	Igrapiúna
29	13507	Iguaí
29	13606	Ilhéus
29	13705	Inhambupe
29	13804	Ipecaetá
29	13903	Ipiaú
29	14000	Ipirá
29	14109	Ipupiara
29	14208	Irajuba
29	14307	Iramaia
29	14406	Iraquara
29	14505	Irará
29	14604	Irecê
29	14653	Itabela
29	14703	Itaberaba
29	14802	Itabuna
29	14901	Itacaré
29	15007	Itaeté
29	15106	Itagi
29	15205	Itagibá
29	15304	Itagimirim
29	15353	Itaguaçu da Bahia
29	15403	Itaju do Colônia
29	15502	Itajuípe
29	15601	Itamaraju
29	15700	Itamari
29	15809	Itambé
29	15908	Itanagra
29	16005	Itanhém
29	16104	Itaparica
29	16203	Itapé
29	16302	Itapebi
29	16401	Itapetinga
29	16500	Itapicuru
29	16609	Itapitanga
29	16708	Itaquara
29	16807	Itarantim
29	16856	Itatim
29	16906	Itiruçu
29	17003	Itiúba
29	17102	Itororó
29	17201	Ituaçu
29	17300	Ituberá
29	17334	Iuiu
29	17359	Jaborandi
29	17409	Jacaraci
29	17508	Jacobina
29	17607	Jaguaquara
29	17706	Jaguarari
29	17805	Jaguaripe
29	17904	Jandaíra
29	18001	Jequié
29	18100	Jeremoabo
29	18209	Jiquiriçá
29	18308	Jitaúna
29	18357	João Dourado
29	18407	Juazeiro
29	18456	Jucuruçu
29	18506	Jussara
29	18555	Jussari
29	18605	Jussiape
29	18704	Lafaiete Coutinho
29	18753	Lagoa Real
29	18803	Laje
29	18902	Lajedão
29	19009	Lajedinho
29	19058	Lajedo do Tabocal
29	19108	Lamarão
29	19157	Lapão
29	19207	Lauro de Freitas
29	19306	Lençóis
29	19405	Licínio de Almeida
29	19504	Livramento de Nossa Senhora
29	19553	Luís Eduardo Magalhães
29	19603	Macajuba
29	19702	Macarani
29	19801	Macaúbas
29	19900	Macururé
29	19926	Madre de Deus
29	19959	Maetinga
29	20007	Maiquinique
29	20106	Mairi
29	20205	Malhada
29	20304	Malhada de Pedras
29	20403	Manoel Vitorino
29	20452	Mansidão
29	20502	Maracás
29	20601	Maragogipe
29	20700	Maraú
29	20809	Marcionílio Souza
29	20908	Mascote
29	21005	Mata de São João
29	21054	Matina
29	21104	Medeiros Neto
29	21203	Miguel Calmon
29	21302	Milagres
29	21401	Mirangaba
29	21450	Mirante
29	21500	Monte Santo
29	21609	Morpará
29	21708	Morro do Chapéu
29	21807	Mortugaba
29	21906	Mucugê
29	22003	Mucuri
29	22052	Mulungu do Morro
29	22102	Mundo Novo
29	22201	Muniz Ferreira
29	22250	Muquém do São Francisco
29	22300	Muritiba
29	22409	Mutuípe
29	22508	Nazaré
29	22607	Nilo Peçanha
29	22656	Nordestina
29	22706	Nova Canaã
29	22730	Nova Fátima
29	22755	Nova Ibiá
29	22805	Nova Itarana
29	22854	Nova Redenção
29	22904	Nova Soure
29	23001	Nova Viçosa
29	23035	Novo Horizonte
29	23050	Novo Triunfo
29	23100	Olindina
29	23209	Oliveira dos Brejinhos
29	23308	Ouriçangas
29	23357	Ourolândia
29	23407	Palmas de Monte Alto
29	23506	Palmeiras
29	23605	Paramirim
29	23704	Paratinga
29	23803	Paripiranga
29	23902	Pau Brasil
29	24009	Paulo Afonso
29	24058	Pé de Serra
29	24108	Pedrão
29	24207	Pedro Alexandre
29	24306	Piatã
29	24405	Pilão Arcado
29	24504	Pindaí
29	24603	Pindobaçu
29	24652	Pintadas
29	24678	Piraí do Norte
29	24702	Piripá
29	24801	Piritiba
29	24900	Planaltino
29	25006	Planalto
29	25105	Poções
29	25204	Pojuca
29	25253	Ponto Novo
29	25303	Porto Seguro
29	25402	Potiraguá
29	25501	Prado
29	25600	Presidente Dutra
29	25709	Presidente Jânio Quadros
29	25758	Presidente Tancredo Neves
29	25808	Queimadas
29	25907	Quijingue
29	25931	Quixabeira
29	25956	Rafael Jambeiro
29	26004	Remanso
29	26103	Retirolândia
29	26202	Riachão das Neves
29	26301	Riachão do Jacuípe
29	26400	Riacho de Santana
29	26509	Ribeira do Amparo
29	26608	Ribeira do Pombal
29	26657	Ribeirão do Largo
29	26707	Rio de Contas
29	26806	Rio do Antônio
29	26905	Rio do Pires
29	27002	Rio Real
29	27101	Rodelas
29	27200	Ruy Barbosa
29	27309	Salinas da Margarida
29	27408	Salvador
29	27507	Santa Bárbara
29	27606	Santa Brígida
29	27705	Santa Cruz Cabrália
29	27804	Santa Cruz da Vitória
29	27903	Santa Inês
29	28059	Santa Luzia
29	28109	Santa Maria da Vitória
29	28406	Santa Rita de Cássia
29	28505	Santa Terezinha
29	28000	Santaluz
29	28208	Santana
29	28307	Santanópolis
29	28604	Santo Amaro
29	28703	Santo Antônio de Jesus
29	28802	Santo Estêvão
29	28901	São Desidério
29	28950	São Domingos
29	29107	São Felipe
29	29008	São Félix
29	29057	São Félix do Coribe
29	29206	São Francisco do Conde
29	29255	São Gabriel
29	29305	São Gonçalo dos Campos
29	29354	São José da Vitória
29	29370	São José do Jacuípe
29	29404	São Miguel das Matas
29	29503	São Sebastião do Passé
29	29602	Sapeaçu
29	29701	Sátiro Dias
29	29750	Saubara
29	29800	Saúde
29	29909	Seabra
29	30006	Sebastião Laranjeiras
29	30105	Senhor do Bonfim
29	30204	Sento Sé
29	30154	Serra do Ramalho
29	30303	Serra Dourada
29	30402	Serra Preta
29	30501	Serrinha
29	30600	Serrolândia
29	30709	Simões Filho
29	30758	Sítio do Mato
29	30766	Sítio do Quinto
29	30774	Sobradinho
29	30808	Souto Soares
29	30907	Tabocas do Brejo Velho
29	31004	Tanhaçu
29	31053	Tanque Novo
29	31103	Tanquinho
29	31202	Taperoá
29	31301	Tapiramutá
29	31350	Teixeira de Freitas
29	31400	Teodoro Sampaio
29	31509	Teofilândia
29	31608	Teolândia
29	31707	Terra Nova
29	31806	Tremedal
29	31905	Tucano
29	32002	Uauá
29	32101	Ubaíra
29	32200	Ubaitaba
29	32309	Ubatã
29	32408	Uibaí
29	32457	Umburanas
29	32507	Una
29	32606	Urandi
29	32705	Uruçuca
29	32804	Utinga
29	32903	Valença
29	33000	Valente
29	33059	Várzea da Roça
29	33109	Várzea do Poço
29	33158	Várzea Nova
29	33174	Varzedo
29	33208	Vera Cruz
29	33257	Vereda
29	33307	Vitória da Conquista
29	33406	Wagner
29	33455	Wanderley
29	33505	Wenceslau Guimarães
29	33604	Xique-Xique
31	00104	Abadia dos Dourados
31	00203	Abaeté
31	00302	Abre Campo
31	00401	Acaiaca
31	00500	Açucena
31	00609	Água Boa
31	00708	Água Comprida
31	00807	Aguanil
31	00906	Águas Formosas
31	01003	Águas Vermelhas
31	01102	Aimorés
31	01201	Aiuruoca
31	01300	Alagoa
31	01409	Albertina
31	01508	Além Paraíba
31	01607	Alfenas
31	01631	Alfredo Vasconcelos
31	01706	Almenara
31	01805	Alpercata
31	01904	Alpinópolis
31	02001	Alterosa
31	02050	Alto Caparaó
31	53509	Alto Jequitibá
31	02100	Alto Rio Doce
31	02209	Alvarenga
31	02308	Alvinópolis
31	02407	Alvorada de Minas
31	02506	Amparo do Serra
31	02605	Andradas
31	02803	Andrelândia
31	02852	Angelândia
31	02902	Antônio Carlos
31	03009	Antônio Dias
31	03108	Antônio Prado de Minas
31	03207	Araçaí
31	03306	Aracitaba
31	03405	Araçuaí
31	03504	Araguari
31	03603	Arantina
31	03702	Araponga
31	03751	Araporã
31	03801	Arapuá
31	03900	Araújos
31	04007	Araxá
31	04106	Arceburgo
31	04205	Arcos
31	04304	Areado
31	04403	Argirita
31	04452	Aricanduva
31	04502	Arinos
31	04601	Astolfo Dutra
31	04700	Ataléia
31	04809	Augusto de Lima
31	04908	Baependi
31	05004	Baldim
31	05103	Bambuí
31	05202	Bandeira
31	05301	Bandeira do Sul
31	05400	Barão de Cocais
31	05509	Barão de Monte Alto
31	05608	Barbacena
31	05707	Barra Longa
31	05905	Barroso
31	06002	Bela Vista de Minas
31	06101	Belmiro Braga
31	06200	Belo Horizonte
31	06309	Belo Oriente
31	06408	Belo Vale
31	06507	Berilo
31	06655	Berizal
31	06606	Bertópolis
31	06705	Betim
31	06804	Bias Fortes
31	06903	Bicas
31	07000	Biquinhas
31	07109	Boa Esperança
31	07208	Bocaina de Minas
31	07307	Bocaiúva
31	07406	Bom Despacho
31	07505	Bom Jardim de Minas
31	07604	Bom Jesus da Penha
31	07703	Bom Jesus do Amparo
31	07802	Bom Jesus do Galho
31	07901	Bom Repouso
31	08008	Bom Sucesso
31	08107	Bonfim
31	08206	Bonfinópolis de Minas
31	08255	Bonito de Minas
31	08305	Borda da Mata
31	08404	Botelhos
31	08503	Botumirim
31	08701	Brás Pires
31	08552	Brasilândia de Minas
31	08602	Brasília de Minas
31	08800	Braúnas
31	08909	Brazópolis
31	09006	Brumadinho
31	09105	Bueno Brandão
31	09204	Buenópolis
31	09253	Bugre
31	09303	Buritis
31	09402	Buritizeiro
31	09451	Cabeceira Grande
31	09501	Cabo Verde
31	09600	Cachoeira da Prata
31	09709	Cachoeira de Minas
31	02704	Cachoeira de Pajeú
31	09808	Cachoeira Dourada
31	09907	Caetanópolis
31	10004	Caeté
31	10103	Caiana
31	10202	Cajuri
31	10301	Caldas
31	10400	Camacho
31	10509	Camanducaia
31	10608	Cambuí
31	10707	Cambuquira
31	10806	Campanário
31	10905	Campanha
31	11002	Campestre
31	11101	Campina Verde
31	11150	Campo Azul
31	11200	Campo Belo
31	11309	Campo do Meio
31	11408	Campo Florido
31	11507	Campos Altos
31	11606	Campos Gerais
31	11903	Cana Verde
31	11705	Canaã
31	11804	Canápolis
31	12000	Candeias
31	12059	Cantagalo
31	12109	Caparaó
31	12208	Capela Nova
31	12307	Capelinha
31	12406	Capetinga
31	12505	Capim Branco
31	12604	Capinópolis
31	12653	Capitão Andrade
31	12703	Capitão Enéas
31	12802	Capitólio
31	12901	Caputira
31	13008	Caraí
31	13107	Caranaíba
31	13206	Carandaí
31	13305	Carangola
31	13404	Caratinga
31	13503	Carbonita
31	13602	Careaçu
31	13701	Carlos Chagas
31	13800	Carmésia
31	13909	Carmo da Cachoeira
31	14006	Carmo da Mata
31	14105	Carmo de Minas
31	14204	Carmo do Cajuru
31	14303	Carmo do Paranaíba
31	14402	Carmo do Rio Claro
31	14501	Carmópolis de Minas
31	14550	Carneirinho
31	14600	Carrancas
31	14709	Carvalhópolis
31	14808	Carvalhos
31	14907	Casa Grande
31	15003	Cascalho Rico
31	15102	Cássia
31	15300	Cataguases
31	15359	Catas Altas
31	15409	Catas Altas da Noruega
31	15458	Catuji
31	15474	Catuti
31	15508	Caxambu
31	15607	Cedro do Abaeté
31	15706	Central de Minas
31	15805	Centralina
31	15904	Chácara
31	16001	Chalé
31	16100	Chapada do Norte
31	16159	Chapada Gaúcha
31	16209	Chiador
31	16308	Cipotânea
31	16407	Claraval
31	16506	Claro dos Poções
31	16605	Cláudio
31	16704	Coimbra
31	16803	Coluna
31	16902	Comendador Gomes
31	17009	Comercinho
31	17108	Conceição da Aparecida
31	15201	Conceição da Barra de Minas
31	17306	Conceição das Alagoas
31	17207	Conceição das Pedras
31	17405	Conceição de Ipanema
31	17504	Conceição do Mato Dentro
31	17603	Conceição do Pará
31	17702	Conceição do Rio Verde
31	17801	Conceição dos Ouros
31	17836	Cônego Marinho
31	17876	Confins
31	17900	Congonhal
31	18007	Congonhas
31	18106	Congonhas do Norte
31	18205	Conquista
31	18304	Conselheiro Lafaiete
31	18403	Conselheiro Pena
31	18502	Consolação
31	18601	Contagem
31	18700	Coqueiral
31	18809	Coração de Jesus
31	18908	Cordisburgo
31	19005	Cordislândia
31	19104	Corinto
31	19203	Coroaci
31	19302	Coromandel
31	19401	Coronel Fabriciano
31	19500	Coronel Murta
31	19609	Coronel Pacheco
31	19708	Coronel Xavier Chaves
31	19807	Córrego Danta
31	19906	Córrego do Bom Jesus
31	19955	Córrego Fundo
31	20003	Córrego Novo
31	20102	Couto de Magalhães de Minas
31	20151	Crisólita
31	20201	Cristais
31	20300	Cristália
31	20409	Cristiano Otoni
31	20508	Cristina
31	20607	Crucilândia
31	20706	Cruzeiro da Fortaleza
31	20805	Cruzília
31	20839	Cuparaque
31	20870	Curral de Dentro
31	20904	Curvelo
31	21001	Datas
31	21100	Delfim Moreira
31	21209	Delfinópolis
31	21258	Delta
31	21308	Descoberto
31	21407	Desterro de Entre Rios
31	21506	Desterro do Melo
31	21605	Diamantina
31	21704	Diogo de Vasconcelos
31	21803	Dionísio
31	21902	Divinésia
31	22009	Divino
31	22108	Divino das Laranjeiras
31	22207	Divinolândia de Minas
31	22306	Divinópolis
31	22355	Divisa Alegre
31	22405	Divisa Nova
31	22454	Divisópolis
31	22470	Dom Bosco
31	22504	Dom Cavati
31	22603	Dom Joaquim
31	22702	Dom Silvério
31	22801	Dom Viçoso
31	22900	Dona Eusébia
31	23007	Dores de Campos
31	23106	Dores de Guanhães
31	23205	Dores do Indaiá
31	23304	Dores do Turvo
31	23403	Doresópolis
31	23502	Douradoquara
31	23528	Durandé
31	23601	Elói Mendes
31	23700	Engenheiro Caldas
31	23809	Engenheiro Navarro
31	23858	Entre Folhas
31	23908	Entre Rios de Minas
31	24005	Ervália
31	24104	Esmeraldas
31	24203	Espera Feliz
31	24302	Espinosa
31	24401	Espírito Santo do Dourado
31	24500	Estiva
31	24609	Estrela Dalva
31	24708	Estrela do Indaiá
31	24807	Estrela do Sul
31	24906	Eugenópolis
31	25002	Ewbank da Câmara
31	25101	Extrema
31	25200	Fama
31	25309	Faria Lemos
31	25408	Felício dos Santos
31	25606	Felisburgo
31	25705	Felixlândia
31	25804	Fernandes Tourinho
31	25903	Ferros
31	25952	Fervedouro
31	26000	Florestal
31	26109	Formiga
31	26208	Formoso
31	26307	Fortaleza de Minas
31	26406	Fortuna de Minas
31	26505	Francisco Badaró
31	26604	Francisco Dumont
31	26703	Francisco Sá
31	26752	Franciscópolis
31	26802	Frei Gaspar
31	26901	Frei Inocêncio
31	26950	Frei Lagonegro
31	27008	Fronteira
31	27057	Fronteira dos Vales
31	27073	Fruta de Leite
31	27107	Frutal
31	27206	Funilândia
31	27305	Galiléia
31	27339	Gameleiras
31	27354	Glaucilândia
31	27370	Goiabeira
31	27388	Goianá
31	27404	Gonçalves
31	27503	Gonzaga
31	27602	Gouveia
31	27701	Governador Valadares
31	27800	Grão Mogol
31	27909	Grupiara
31	28006	Guanhães
31	28105	Guapé
31	28204	Guaraciaba
31	28253	Guaraciama
31	28303	Guaranésia
31	28402	Guarani
31	28501	Guarará
31	28600	Guarda-Mor
31	28709	Guaxupé
31	28808	Guidoval
31	28907	Guimarânia
31	29004	Guiricema
31	29103	Gurinhatã
31	29202	Heliodora
31	29301	Iapu
31	29400	Ibertioga
31	29509	Ibiá
31	29608	Ibiaí
31	29657	Ibiracatu
31	29707	Ibiraci
31	29806	Ibirité
31	29905	Ibitiúra de Minas
31	30002	Ibituruna
31	30051	Icaraí de Minas
31	30101	Igarapé
31	30200	Igaratinga
31	30309	Iguatama
31	30408	Ijaci
31	30507	Ilicínea
31	30556	Imbé de Minas
31	30606	Inconfidentes
31	30655	Indaiabira
31	30705	Indianópolis
31	30804	Ingaí
31	30903	Inhapim
31	31000	Inhaúma
31	31109	Inimutaba
31	31158	Ipaba
31	31208	Ipanema
31	31307	Ipatinga
31	31406	Ipiaçu
31	31505	Ipuiúna
31	31604	Iraí de Minas
31	31703	Itabira
31	31802	Itabirinha
31	31901	Itabirito
31	32008	Itacambira
31	32107	Itacarambi
31	32206	Itaguara
31	32305	Itaipé
31	32404	Itajubá
31	32503	Itamarandiba
31	32602	Itamarati de Minas
31	32701	Itambacuri
31	32800	Itambé do Mato Dentro
31	32909	Itamogi
31	33006	Itamonte
31	33105	Itanhandu
31	33204	Itanhomi
31	33303	Itaobim
31	33402	Itapagipe
31	33501	Itapecerica
31	33600	Itapeva
31	33709	Itatiaiuçu
31	33758	Itaú de Minas
31	33808	Itaúna
31	33907	Itaverava
31	34004	Itinga
31	34103	Itueta
31	34202	Ituiutaba
31	34301	Itumirim
31	34400	Iturama
31	34509	Itutinga
31	34608	Jaboticatubas
31	34707	Jacinto
31	34806	Jacuí
31	34905	Jacutinga
31	35001	Jaguaraçu
31	35050	Jaíba
31	35076	Jampruca
31	35100	Janaúba
31	35209	Januária
31	35308	Japaraíba
31	35357	Japonvar
31	35407	Jeceaba
31	35456	Jenipapo de Minas
31	35506	Jequeri
31	35605	Jequitaí
31	35704	Jequitibá
31	35803	Jequitinhonha
31	35902	Jesuânia
31	36009	Joaíma
31	36108	Joanésia
31	36207	João Monlevade
31	36306	João Pinheiro
31	36405	Joaquim Felício
31	36504	Jordânia
31	36520	José Gonçalves de Minas
31	36553	José Raydan
31	36579	Josenópolis
31	36652	Juatuba
31	36702	Juiz de Fora
31	36801	Juramento
31	36900	Juruaia
31	36959	Juvenília
31	37007	Ladainha
31	37106	Lagamar
31	37205	Lagoa da Prata
31	37304	Lagoa dos Patos
31	37403	Lagoa Dourada
31	37502	Lagoa Formosa
31	37536	Lagoa Grande
31	37601	Lagoa Santa
31	37700	Lajinha
31	37809	Lambari
31	37908	Lamim
31	38005	Laranjal
31	38104	Lassance
31	38203	Lavras
31	38302	Leandro Ferreira
31	38351	Leme do Prado
31	38401	Leopoldina
31	38500	Liberdade
31	38609	Lima Duarte
31	38625	Limeira do Oeste
31	38658	Lontra
31	38674	Luisburgo
31	38682	Luislândia
31	38708	Luminárias
31	38807	Luz
31	38906	Machacalis
31	39003	Machado
31	39102	Madre de Deus de Minas
31	39201	Malacacheta
31	39250	Mamonas
31	39300	Manga
31	39409	Manhuaçu
31	39508	Manhumirim
31	39607	Mantena
31	39805	Mar de Espanha
31	39706	Maravilhas
31	39904	Maria da Fé
31	40001	Mariana
31	40100	Marilac
31	40159	Mário Campos
31	40209	Maripá de Minas
31	40308	Marliéria
31	40407	Marmelópolis
31	40506	Martinho Campos
31	40530	Martins Soares
31	40555	Mata Verde
31	40605	Materlândia
31	40704	Mateus Leme
31	71501	Mathias Lobato
31	40803	Matias Barbosa
31	40852	Matias Cardoso
31	40902	Matipó
31	41009	Mato Verde
31	41108	Matozinhos
31	41207	Matutina
31	41306	Medeiros
31	41405	Medina
31	41504	Mendes Pimentel
31	41603	Mercês
31	41702	Mesquita
31	41801	Minas Novas
31	41900	Minduri
31	42007	Mirabela
31	42106	Miradouro
31	42205	Miraí
31	42254	Miravânia
31	42304	Moeda
31	42403	Moema
31	42502	Monjolos
31	42601	Monsenhor Paulo
31	42700	Montalvânia
31	42809	Monte Alegre de Minas
31	42908	Monte Azul
31	43005	Monte Belo
31	43104	Monte Carmelo
31	43153	Monte Formoso
31	43203	Monte Santo de Minas
31	43401	Monte Sião
31	43302	Montes Claros
31	43450	Montezuma
31	43500	Morada Nova de Minas
31	43609	Morro da Garça
31	43708	Morro do Pilar
31	43807	Munhoz
31	43906	Muriaé
31	44003	Mutum
31	44102	Muzambinho
31	44201	Nacip Raydan
31	44300	Nanuque
31	44359	Naque
31	44375	Natalândia
31	44409	Natércia
31	44508	Nazareno
31	44607	Nepomuceno
31	44656	Ninheira
31	44672	Nova Belém
31	44706	Nova Era
31	44805	Nova Lima
31	44904	Nova Módica
31	45000	Nova Ponte
31	45059	Nova Porteirinha
31	45109	Nova Resende
31	45208	Nova Serrana
31	36603	Nova União
31	45307	Novo Cruzeiro
31	45356	Novo Oriente de Minas
31	45372	Novorizonte
31	45406	Olaria
31	45455	Olhos-d'Água
31	45505	Olímpio Noronha
31	45604	Oliveira
31	45703	Oliveira Fortes
31	45802	Onça de Pitangui
31	45851	Oratórios
31	45877	Orizânia
31	45901	Ouro Branco
31	46008	Ouro Fino
31	46107	Ouro Preto
31	46206	Ouro Verde de Minas
31	46255	Padre Carvalho
31	46305	Padre Paraíso
31	46552	Pai Pedro
31	46404	Paineiras
31	46503	Pains
31	46602	Paiva
31	46701	Palma
31	46750	Palmópolis
31	46909	Papagaios
31	47105	Pará de Minas
31	47006	Paracatu
31	47204	Paraguaçu
31	47303	Paraisópolis
31	47402	Paraopeba
31	47600	Passa Quatro
31	47709	Passa Tempo
31	47808	Passa Vinte
31	47501	Passabém
31	47907	Passos
31	47956	Patis
31	48004	Patos de Minas
31	48103	Patrocínio
31	48202	Patrocínio do Muriaé
31	48301	Paula Cândido
31	48400	Paulistas
31	48509	Pavão
31	48608	Peçanha
31	48707	Pedra Azul
31	48756	Pedra Bonita
31	48806	Pedra do Anta
31	48905	Pedra do Indaiá
31	49002	Pedra Dourada
31	49101	Pedralva
31	49150	Pedras de Maria da Cruz
31	49200	Pedrinópolis
31	49309	Pedro Leopoldo
31	49408	Pedro Teixeira
31	49507	Pequeri
31	49606	Pequi
31	49705	Perdigão
31	49804	Perdizes
31	49903	Perdões
31	49952	Periquito
31	50000	Pescador
31	50109	Piau
31	50158	Piedade de Caratinga
31	50208	Piedade de Ponte Nova
31	50307	Piedade do Rio Grande
31	50406	Piedade dos Gerais
31	50505	Pimenta
31	50539	Pingo d'Água
31	50570	Pintópolis
31	50604	Piracema
31	50703	Pirajuba
31	50802	Piranga
31	50901	Piranguçu
31	51008	Piranguinho
31	51107	Pirapetinga
31	51206	Pirapora
31	51305	Piraúba
31	51404	Pitangui
31	51503	Piumhi
31	51602	Planura
31	51701	Poço Fundo
31	51800	Poços de Caldas
31	51909	Pocrane
31	52006	Pompéu
31	52105	Ponte Nova
31	52131	Ponto Chique
31	52170	Ponto dos Volantes
31	52204	Porteirinha
31	52303	Porto Firme
31	52402	Poté
31	52501	Pouso Alegre
31	52600	Pouso Alto
31	52709	Prados
31	52808	Prata
31	52907	Pratápolis
31	53004	Pratinha
31	53103	Presidente Bernardes
31	53202	Presidente Juscelino
31	53301	Presidente Kubitschek
31	53400	Presidente Olegário
31	53608	Prudente de Morais
31	53707	Quartel Geral
31	53806	Queluzito
31	53905	Raposos
31	54002	Raul Soares
31	54101	Recreio
31	54150	Reduto
31	54200	Resende Costa
31	54309	Resplendor
31	54408	Ressaquinha
31	54457	Riachinho
31	54507	Riacho dos Machados
31	54606	Ribeirão das Neves
31	54705	Ribeirão Vermelho
31	54804	Rio Acima
31	54903	Rio Casca
31	55108	Rio do Prado
31	55009	Rio Doce
31	55207	Rio Espera
31	55306	Rio Manso
31	55405	Rio Novo
31	55504	Rio Paranaíba
31	55603	Rio Pardo de Minas
31	55702	Rio Piracicaba
31	55801	Rio Pomba
31	55900	Rio Preto
31	56007	Rio Vermelho
31	56106	Ritápolis
31	56205	Rochedo de Minas
31	56304	Rodeiro
31	56403	Romaria
31	56452	Rosário da Limeira
31	56502	Rubelita
31	56601	Rubim
31	56700	Sabará
31	56809	Sabinópolis
31	56908	Sacramento
31	57005	Salinas
31	57104	Salto da Divisa
31	57203	Santa Bárbara
31	57252	Santa Bárbara do Leste
31	57278	Santa Bárbara do Monte Verde
31	57302	Santa Bárbara do Tugúrio
31	57336	Santa Cruz de Minas
31	57377	Santa Cruz de Salinas
31	57401	Santa Cruz do Escalvado
31	57500	Santa Efigênia de Minas
31	57609	Santa Fé de Minas
31	57658	Santa Helena de Minas
31	57708	Santa Juliana
31	57807	Santa Luzia
31	57906	Santa Margarida
31	58003	Santa Maria de Itabira
31	58102	Santa Maria do Salto
31	58201	Santa Maria do Suaçuí
31	59209	Santa Rita de Caldas
31	59407	Santa Rita de Ibitipoca
31	59308	Santa Rita de Jacutinga
31	59357	Santa Rita de Minas
31	59506	Santa Rita do Itueto
31	59605	Santa Rita do Sapucaí
31	59704	Santa Rosa da Serra
31	59803	Santa Vitória
31	58300	Santana da Vargem
31	58409	Santana de Cataguases
31	58508	Santana de Pirapama
31	58607	Santana do Deserto
31	58706	Santana do Garambéu
31	58805	Santana do Jacaré
31	58904	Santana do Manhuaçu
31	58953	Santana do Paraíso
31	59001	Santana do Riacho
31	59100	Santana dos Montes
31	59902	Santo Antônio do Amparo
31	60009	Santo Antônio do Aventureiro
31	60108	Santo Antônio do Grama
31	60207	Santo Antônio do Itambé
31	60306	Santo Antônio do Jacinto
31	60405	Santo Antônio do Monte
31	60454	Santo Antônio do Retiro
31	60504	Santo Antônio do Rio Abaixo
31	60603	Santo Hipólito
31	60702	Santos Dumont
31	60801	São Bento Abade
31	60900	São Brás do Suaçuí
31	60959	São Domingos das Dores
31	61007	São Domingos do Prata
31	61056	São Félix de Minas
31	61106	São Francisco
31	61205	São Francisco de Paula
31	61304	São Francisco de Sales
31	61403	São Francisco do Glória
31	61502	São Geraldo
31	61601	São Geraldo da Piedade
31	61650	São Geraldo do Baixio
31	61700	São Gonçalo do Abaeté
31	61809	São Gonçalo do Pará
31	61908	São Gonçalo do Rio Abaixo
31	25507	São Gonçalo do Rio Preto
31	62005	São Gonçalo do Sapucaí
31	62104	São Gotardo
31	62203	São João Batista do Glória
31	62252	São João da Lagoa
31	62302	São João da Mata
31	62401	São João da Ponte
31	62450	São João das Missões
31	62500	São João del Rei
31	62559	São João do Manhuaçu
31	62575	São João do Manteninha
31	62609	São João do Oriente
31	62658	São João do Pacuí
31	62708	São João do Paraíso
31	62807	São João Evangelista
31	62906	São João Nepomuceno
31	62922	São Joaquim de Bicas
31	62948	São José da Barra
31	62955	São José da Lapa
31	63003	São José da Safira
31	63102	São José da Varginha
31	63201	São José do Alegre
31	63300	São José do Divino
31	63409	São José do Goiabal
31	63508	São José do Jacuri
31	63607	São José do Mantimento
31	63706	São Lourenço
31	63805	São Miguel do Anta
31	63904	São Pedro da União
31	64100	São Pedro do Suaçuí
31	64001	São Pedro dos Ferros
31	64209	São Romão
31	64308	São Roque de Minas
31	64407	São Sebastião da Bela Vista
31	64431	São Sebastião da Vargem Alegre
31	64472	São Sebastião do Anta
31	64506	São Sebastião do Maranhão
31	64605	São Sebastião do Oeste
31	64704	São Sebastião do Paraíso
31	64803	São Sebastião do Rio Preto
31	64902	São Sebastião do Rio Verde
31	65206	São Thomé das Letras
31	65008	São Tiago
31	65107	São Tomás de Aquino
31	65305	São Vicente de Minas
31	65404	Sapucaí-Mirim
31	65503	Sardoá
31	65537	Sarzedo
31	65560	Sem-Peixe
31	65578	Senador Amaral
31	65602	Senador Cortes
31	65701	Senador Firmino
31	65800	Senador José Bento
31	65909	Senador Modestino Gonçalves
31	66006	Senhora de Oliveira
31	66105	Senhora do Porto
31	66204	Senhora dos Remédios
31	66303	Sericita
31	66402	Seritinga
31	66501	Serra Azul de Minas
31	66600	Serra da Saudade
31	66808	Serra do Salitre
31	66709	Serra dos Aimorés
31	66907	Serrania
31	66956	Serranópolis de Minas
31	67004	Serranos
31	67103	Serro
31	67202	Sete Lagoas
31	65552	Setubinha
31	67301	Silveirânia
31	67400	Silvianópolis
31	67509	Simão Pereira
31	67608	Simonésia
31	67707	Sobrália
31	67806	Soledade de Minas
31	67905	Tabuleiro
31	68002	Taiobeiras
31	68051	Taparuba
31	68101	Tapira
31	68200	Tapiraí
31	68309	Taquaraçu de Minas
31	68408	Tarumirim
31	68507	Teixeiras
31	68606	Teófilo Otoni
31	68705	Timóteo
31	68804	Tiradentes
31	68903	Tiros
31	69000	Tocantins
31	69059	Tocos do Moji
31	69109	Toledo
31	69208	Tombos
31	69307	Três Corações
31	69356	Três Marias
31	69406	Três Pontas
31	69505	Tumiritinga
31	69604	Tupaciguara
31	69703	Turmalina
31	69802	Turvolândia
31	69901	Ubá
31	70008	Ubaí
31	70057	Ubaporanga
31	70107	Uberaba
31	70206	Uberlândia
31	70305	Umburatiba
31	70404	Unaí
31	70438	União de Minas
31	70479	Uruana de Minas
31	70503	Urucânia
31	70529	Urucuia
31	70578	Vargem Alegre
31	70602	Vargem Bonita
31	70651	Vargem Grande do Rio Pardo
31	70701	Varginha
31	70750	Varjão de Minas
31	70800	Várzea da Palma
31	70909	Varzelândia
31	71006	Vazante
31	71030	Verdelândia
31	71071	Veredinha
31	71105	Veríssimo
31	71154	Vermelho Novo
31	71204	Vespasiano
31	71303	Viçosa
31	71402	Vieiras
31	71600	Virgem da Lapa
31	71709	Virgínia
31	71808	Virginópolis
31	71907	Virgolândia
31	72004	Visconde do Rio Branco
31	72103	Volta Grande
31	72202	Wenceslau Braz
32	00102	Afonso Cláudio
32	00169	Água Doce do Norte
32	00136	Águia Branca
32	00201	Alegre
32	00300	Alfredo Chaves
32	00359	Alto Rio Novo
32	00409	Anchieta
32	00508	Apiacá
32	00607	Aracruz
32	00706	Atílio Vivacqua
32	00805	Baixo Guandu
32	00904	Barra de São Francisco
32	01001	Boa Esperança
32	01100	Bom Jesus do Norte
32	01159	Brejetuba
32	01209	Cachoeiro de Itapemirim
32	01308	Cariacica
32	01407	Castelo
32	01506	Colatina
32	01605	Conceição da Barra
32	01704	Conceição do Castelo
32	01803	Divino de São Lourenço
32	01902	Domingos Martins
32	02009	Dores do Rio Preto
32	02108	Ecoporanga
32	02207	Fundão
32	02256	Governador Lindenberg
32	02306	Guaçuí
32	02405	Guarapari
32	02454	Ibatiba
32	02504	Ibiraçu
32	02553	Ibitirama
32	02603	Iconha
32	02652	Irupi
32	02702	Itaguaçu
32	02801	Itapemirim
32	02900	Itarana
32	03007	Iúna
32	03056	Jaguaré
32	03106	Jerônimo Monteiro
32	03130	João Neiva
32	03163	Laranja da Terra
32	03205	Linhares
32	03304	Mantenópolis
32	03320	Marataízes
32	03346	Marechal Floriano
32	03353	Marilândia
32	03403	Mimoso do Sul
32	03502	Montanha
32	03601	Mucurici
32	03700	Muniz Freire
32	03809	Muqui
32	03908	Nova Venécia
32	04005	Pancas
32	04054	Pedro Canário
32	04104	Pinheiros
32	04203	Piúma
32	04252	Ponto Belo
32	04302	Presidente Kennedy
32	04351	Rio Bananal
32	04401	Rio Novo do Sul
32	04500	Santa Leopoldina
32	04559	Santa Maria de Jetibá
32	04609	Santa Teresa
32	04658	São Domingos do Norte
32	04708	São Gabriel da Palha
32	04807	São José do Calçado
32	04906	São Mateus
32	04955	São Roque do Canaã
32	05002	Serra
32	05010	Sooretama
32	05036	Vargem Alta
32	05069	Venda Nova do Imigrante
32	05101	Viana
32	05150	Vila Pavão
32	05176	Vila Valério
32	05200	Vila Velha
32	05309	Vitória
33	00100	Angra dos Reis
33	00159	Aperibé
33	00209	Araruama
33	00225	Areal
33	00233	Armação dos Búzios
33	00258	Arraial do Cabo
33	00308	Barra do Piraí
33	00407	Barra Mansa
33	00456	Belford Roxo
33	00506	Bom Jardim
33	00605	Bom Jesus do Itabapoana
33	00704	Cabo Frio
33	00803	Cachoeiras de Macacu
33	00902	Cambuci
33	01009	Campos dos Goytacazes
33	01108	Cantagalo
33	00936	Carapebus
33	01157	Cardoso Moreira
33	01207	Carmo
33	01306	Casimiro de Abreu
33	00951	Comendador Levy Gasparian
33	01405	Conceição de Macabu
33	01504	Cordeiro
33	01603	Duas Barras
33	01702	Duque de Caxias
33	01801	Engenheiro Paulo de Frontin
33	01850	Guapimirim
33	01876	Iguaba Grande
33	01900	Itaboraí
33	02007	Itaguaí
33	02056	Italva
33	02106	Itaocara
33	02205	Itaperuna
33	02254	Itatiaia
33	02270	Japeri
33	02304	Laje do Muriaé
33	02403	Macaé
33	02452	Macuco
33	02502	Magé
33	02601	Mangaratiba
33	02700	Maricá
33	02809	Mendes
33	02858	Mesquita
33	02908	Miguel Pereira
33	03005	Miracema
33	03104	Natividade
33	03203	Nilópolis
33	03302	Niterói
33	03401	Nova Friburgo
33	03500	Nova Iguaçu
33	03609	Paracambi
33	03708	Paraíba do Sul
33	03807	Paraty
33	03856	Paty do Alferes
33	03906	Petrópolis
33	03955	Pinheiral
33	04003	Piraí
33	04102	Porciúncula
33	04110	Porto Real
33	04128	Quatis
33	04144	Queimados
33	04151	Quissamã
33	04201	Resende
33	04300	Rio Bonito
33	04409	Rio Claro
33	04508	Rio das Flores
33	04524	Rio das Ostras
33	04557	Rio de Janeiro
33	04607	Santa Maria Madalena
33	04706	Santo Antônio de Pádua
33	04805	São Fidélis
33	04755	São Francisco de Itabapoana
33	04904	São Gonçalo
33	05000	São João da Barra
33	05109	São João de Meriti
33	05133	São José de Ubá
33	05158	São José do Vale do Rio Preto
33	05208	São Pedro da Aldeia
33	05307	São Sebastião do Alto
33	05406	Sapucaia
33	05505	Saquarema
33	05554	Seropédica
33	05604	Silva Jardim
33	05703	Sumidouro
33	05752	Tanguá
33	05802	Teresópolis
33	05901	Trajano de Moraes
33	06008	Três Rios
33	06107	Valença
33	06156	Varre-Sai
33	06206	Vassouras
33	06305	Volta Redonda
35	00105	Adamantina
35	00204	Adolfo
35	00303	Aguaí
35	00402	Águas da Prata
35	00501	Águas de Lindóia
35	00550	Águas de Santa Bárbara
35	00600	Águas de São Pedro
35	00709	Agudos
35	00758	Alambari
35	00808	Alfredo Marcondes
35	00907	Altair
35	01004	Altinópolis
35	01103	Alto Alegre
35	01152	Alumínio
35	01202	Álvares Florence
35	01301	Álvares Machado
35	01400	Álvaro de Carvalho
35	01509	Alvinlândia
35	01608	Americana
35	01707	Américo Brasiliense
35	01806	Américo de Campos
35	01905	Amparo
35	02002	Analândia
35	02101	Andradina
35	02200	Angatuba
35	02309	Anhembi
35	02408	Anhumas
35	02507	Aparecida
35	02606	Aparecida d'Oeste
35	02705	Apiaí
35	02754	Araçariguama
35	02804	Araçatuba
35	02903	Araçoiaba da Serra
35	03000	Aramina
35	03109	Arandu
35	03158	Arapeí
35	03208	Araraquara
35	03307	Araras
35	03356	Arco-Íris
35	03406	Arealva
35	03505	Areias
35	03604	Areiópolis
35	03703	Ariranha
35	03802	Artur Nogueira
35	03901	Arujá
35	03950	Aspásia
35	04008	Assis
35	04107	Atibaia
35	04206	Auriflama
35	04305	Avaí
35	04404	Avanhandava
35	04503	Avaré
35	04602	Bady Bassitt
35	04701	Balbinos
35	04800	Bálsamo
35	04909	Bananal
35	05005	Barão de Antonina
35	05104	Barbosa
35	05203	Bariri
35	05302	Barra Bonita
35	05351	Barra do Chapéu
35	05401	Barra do Turvo
35	05500	Barretos
35	05609	Barrinha
35	05708	Barueri
35	05807	Bastos
35	05906	Batatais
35	06003	Bauru
35	06102	Bebedouro
35	06201	Bento de Abreu
35	06300	Bernardino de Campos
35	06359	Bertioga
35	06409	Bilac
35	06508	Birigui
35	06607	Biritiba Mirim
35	06706	Boa Esperança do Sul
35	06805	Bocaina
35	06904	Bofete
35	07001	Boituva
35	07100	Bom Jesus dos Perdões
35	07159	Bom Sucesso de Itararé
35	07209	Borá
35	07308	Boracéia
35	07407	Borborema
35	07456	Borebi
35	07506	Botucatu
35	07605	Bragança Paulista
35	07704	Braúna
35	07753	Brejo Alegre
35	07803	Brodowski
35	07902	Brotas
35	08009	Buri
35	08108	Buritama
35	08207	Buritizal
35	08306	Cabrália Paulista
35	08405	Cabreúva
35	08504	Caçapava
35	08603	Cachoeira Paulista
35	08702	Caconde
35	08801	Cafelândia
35	08900	Caiabu
35	09007	Caieiras
35	09106	Caiuá
35	09205	Cajamar
35	09254	Cajati
35	09304	Cajobi
35	09403	Cajuru
35	09452	Campina do Monte Alegre
35	09502	Campinas
35	09601	Campo Limpo Paulista
35	09700	Campos do Jordão
35	09809	Campos Novos Paulista
35	09908	Cananéia
35	09957	Canas
35	10005	Cândido Mota
35	10104	Cândido Rodrigues
35	10153	Canitar
35	10203	Capão Bonito
35	10302	Capela do Alto
35	10401	Capivari
35	10500	Caraguatatuba
35	10609	Carapicuíba
35	10708	Cardoso
35	10807	Casa Branca
35	10906	Cássia dos Coqueiros
35	11003	Castilho
35	11102	Catanduva
35	11201	Catiguá
35	11300	Cedral
35	11409	Cerqueira César
35	11508	Cerquilho
35	11607	Cesário Lange
35	11706	Charqueada
35	57204	Chavantes
35	11904	Clementina
35	12001	Colina
35	12100	Colômbia
35	12209	Conchal
35	12308	Conchas
35	12407	Cordeirópolis
35	12506	Coroados
35	12605	Coronel Macedo
35	12704	Corumbataí
35	12803	Cosmópolis
35	12902	Cosmorama
35	13009	Cotia
35	13108	Cravinhos
35	13207	Cristais Paulista
35	13306	Cruzália
35	13405	Cruzeiro
35	13504	Cubatão
35	13603	Cunha
35	13702	Descalvado
35	13801	Diadema
35	13850	Dirce Reis
35	13900	Divinolândia
35	14007	Dobrada
35	14106	Dois Córregos
35	14205	Dolcinópolis
35	14304	Dourado
35	14403	Dracena
35	14502	Duartina
35	14601	Dumont
35	14700	Echaporã
35	14809	Eldorado
35	14908	Elias Fausto
35	14924	Elisiário
35	14957	Embaúba
35	15004	Embu das Artes
35	15103	Embu-Guaçu
35	15129	Emilianópolis
35	15152	Engenheiro Coelho
35	15186	Espírito Santo do Pinhal
35	15194	Espírito Santo do Turvo
35	57303	Estiva Gerbi
35	15301	Estrela do Norte
35	15202	Estrela d'Oeste
35	15350	Euclides da Cunha Paulista
35	15400	Fartura
35	15608	Fernando Prestes
35	15509	Fernandópolis
35	15657	Fernão
35	15707	Ferraz de Vasconcelos
35	15806	Flora Rica
35	15905	Floreal
35	16002	Flórida Paulista
35	16101	Florínea
35	16200	Franca
35	16309	Francisco Morato
35	16408	Franco da Rocha
35	16507	Gabriel Monteiro
35	16606	Gália
35	16705	Garça
35	16804	Gastão Vidigal
35	16853	Gavião Peixoto
35	16903	General Salgado
35	17000	Getulina
35	17109	Glicério
35	17208	Guaiçara
35	17307	Guaimbê
35	17406	Guaíra
35	17505	Guapiaçu
35	17604	Guapiara
35	17703	Guará
35	17802	Guaraçaí
35	17901	Guaraci
35	18008	Guarani d'Oeste
35	18107	Guarantã
35	18206	Guararapes
35	18305	Guararema
35	18404	Guaratinguetá
35	18503	Guareí
35	18602	Guariba
35	18701	Guarujá
35	18800	Guarulhos
35	18859	Guatapará
35	18909	Guzolândia
35	19006	Herculândia
35	19055	Holambra
35	19071	Hortolândia
35	19105	Iacanga
35	19204	Iacri
35	19253	Iaras
35	19303	Ibaté
35	19402	Ibirá
35	19501	Ibirarema
35	19600	Ibitinga
35	19709	Ibiúna
35	19808	Icém
35	19907	Iepê
35	20004	Igaraçu do Tietê
35	20103	Igarapava
35	20202	Igaratá
35	20301	Iguape
35	20426	Ilha Comprida
35	20442	Ilha Solteira
35	20400	Ilhabela
35	20509	Indaiatuba
35	20608	Indiana
35	20707	Indiaporã
35	20806	Inúbia Paulista
35	20905	Ipaussu
35	21002	Iperó
35	21101	Ipeúna
35	21150	Ipiguá
35	21200	Iporanga
35	21309	Ipuã
35	21408	Iracemápolis
35	21507	Irapuã
35	21606	Irapuru
35	21705	Itaberá
35	21804	Itaí
35	21903	Itajobi
35	22000	Itaju
35	22109	Itanhaém
35	22158	Itaoca
35	22208	Itapecerica da Serra
35	22307	Itapetininga
35	22406	Itapeva
35	22505	Itapevi
35	22604	Itapira
35	22653	Itapirapuã Paulista
35	22703	Itápolis
35	22802	Itaporanga
35	22901	Itapuí
35	23008	Itapura
35	23107	Itaquaquecetuba
35	23206	Itararé
35	23305	Itariri
35	23404	Itatiba
35	23503	Itatinga
35	23602	Itirapina
35	23701	Itirapuã
35	23800	Itobi
35	23909	Itu
35	24006	Itupeva
35	24105	Ituverava
35	24204	Jaborandi
35	24303	Jaboticabal
35	24402	Jacareí
35	24501	Jaci
35	24600	Jacupiranga
35	24709	Jaguariúna
35	24808	Jales
35	24907	Jambeiro
35	25003	Jandira
35	25102	Jardinópolis
35	25201	Jarinu
35	25300	Jaú
35	25409	Jeriquara
35	25508	Joanópolis
35	25607	João Ramalho
35	25706	José Bonifácio
35	25805	Júlio Mesquita
35	25854	Jumirim
35	25904	Jundiaí
35	26001	Junqueirópolis
35	26100	Juquiá
35	26209	Juquitiba
35	26308	Lagoinha
35	26407	Laranjal Paulista
35	26506	Lavínia
35	26605	Lavrinhas
35	26704	Leme
35	26803	Lençóis Paulista
35	26902	Limeira
35	27009	Lindóia
35	27108	Lins
35	27207	Lorena
35	27256	Lourdes
35	27306	Louveira
35	27405	Lucélia
35	27504	Lucianópolis
35	27603	Luís Antônio
35	27702	Luiziânia
35	27801	Lupércio
35	27900	Lutécia
35	28007	Macatuba
35	28106	Macaubal
35	28205	Macedônia
35	28304	Magda
35	28403	Mairinque
35	28502	Mairiporã
35	28601	Manduri
35	28700	Marabá Paulista
35	28809	Maracaí
35	28858	Marapoama
35	28908	Mariápolis
35	29005	Marília
35	29104	Marinópolis
35	29203	Martinópolis
35	29302	Matão
35	29401	Mauá
35	29500	Mendonça
35	29609	Meridiano
35	29658	Mesópolis
35	29708	Miguelópolis
35	29807	Mineiros do Tietê
35	30003	Mira Estrela
35	29906	Miracatu
35	30102	Mirandópolis
35	30201	Mirante do Paranapanema
35	30300	Mirassol
35	30409	Mirassolândia
35	30508	Mococa
35	30607	Mogi das Cruzes
35	30706	Mogi Guaçu
35	30805	Mogi Mirim
35	30904	Mombuca
35	31001	Monções
35	31100	Mongaguá
35	31209	Monte Alegre do Sul
35	31308	Monte Alto
35	31407	Monte Aprazível
35	31506	Monte Azul Paulista
35	31605	Monte Castelo
35	31803	Monte Mor
35	31704	Monteiro Lobato
35	31902	Morro Agudo
35	32009	Morungaba
35	32058	Motuca
35	32108	Murutinga do Sul
35	32157	Nantes
35	32207	Narandiba
35	32306	Natividade da Serra
35	32405	Nazaré Paulista
35	32504	Neves Paulista
35	32603	Nhandeara
35	32702	Nipoã
35	32801	Nova Aliança
35	32827	Nova Campina
35	32843	Nova Canaã Paulista
35	32868	Nova Castilho
35	32900	Nova Europa
35	33007	Nova Granada
35	33106	Nova Guataporanga
35	33205	Nova Independência
35	33304	Nova Luzitânia
35	33403	Nova Odessa
35	33254	Novais
35	33502	Novo Horizonte
35	33601	Nuporanga
35	33700	Ocauçu
35	33809	Óleo
35	33908	Olímpia
35	34005	Onda Verde
35	34104	Oriente
35	34203	Orindiúva
35	34302	Orlândia
35	34401	Osasco
35	34500	Oscar Bressane
35	34609	Osvaldo Cruz
35	34708	Ourinhos
35	34807	Ouro Verde
35	34757	Ouroeste
35	34906	Pacaembu
35	35002	Palestina
35	35101	Palmares Paulista
35	35200	Palmeira d'Oeste
35	35309	Palmital
35	35408	Panorama
35	35507	Paraguaçu Paulista
35	35606	Paraibuna
35	35705	Paraíso
35	35804	Paranapanema
35	35903	Paranapuã
35	36000	Parapuã
35	36109	Pardinho
35	36208	Pariquera-Açu
35	36257	Parisi
35	36307	Patrocínio Paulista
35	36406	Paulicéia
35	36505	Paulínia
35	36570	Paulistânia
35	36604	Paulo de Faria
35	36703	Pederneiras
35	36802	Pedra Bela
35	36901	Pedranópolis
35	37008	Pedregulho
35	37107	Pedreira
35	37156	Pedrinhas Paulista
35	37206	Pedro de Toledo
35	37305	Penápolis
35	37404	Pereira Barreto
35	37503	Pereiras
35	37602	Peruíbe
35	37701	Piacatu
35	37800	Piedade
35	37909	Pilar do Sul
35	38006	Pindamonhangaba
35	38105	Pindorama
35	38204	Pinhalzinho
35	38303	Piquerobi
35	38501	Piquete
35	38600	Piracaia
35	38709	Piracicaba
35	38808	Piraju
35	38907	Pirajuí
35	39004	Pirangi
35	39103	Pirapora do Bom Jesus
35	39202	Pirapozinho
35	39301	Pirassununga
35	39400	Piratininga
35	39509	Pitangueiras
35	39608	Planalto
35	39707	Platina
35	39806	Poá
35	39905	Poloni
35	40002	Pompéia
35	40101	Pongaí
35	40200	Pontal
35	40259	Pontalinda
35	40309	Pontes Gestal
35	40408	Populina
35	40507	Porangaba
35	40606	Porto Feliz
35	40705	Porto Ferreira
35	40754	Potim
35	40804	Potirendaba
35	40853	Pracinha
35	40903	Pradópolis
35	41000	Praia Grande
35	41059	Pratânia
35	41109	Presidente Alves
35	41208	Presidente Bernardes
35	41307	Presidente Epitácio
35	41406	Presidente Prudente
35	41505	Presidente Venceslau
35	41604	Promissão
35	41653	Quadra
35	41703	Quatá
35	41802	Queiroz
35	41901	Queluz
35	42008	Quintana
35	42107	Rafard
35	42206	Rancharia
35	42305	Redenção da Serra
35	42404	Regente Feijó
35	42503	Reginópolis
35	42602	Registro
35	42701	Restinga
35	42800	Ribeira
35	42909	Ribeirão Bonito
35	43006	Ribeirão Branco
35	43105	Ribeirão Corrente
35	43204	Ribeirão do Sul
35	43238	Ribeirão dos Índios
35	43253	Ribeirão Grande
35	43303	Ribeirão Pires
35	43402	Ribeirão Preto
35	43600	Rifaina
35	43709	Rincão
35	43808	Rinópolis
35	43907	Rio Claro
35	44004	Rio das Pedras
35	44103	Rio Grande da Serra
35	44202	Riolândia
35	43501	Riversul
35	44251	Rosana
35	44301	Roseira
35	44400	Rubiácea
35	44509	Rubinéia
35	44608	Sabino
35	44707	Sagres
35	44806	Sales
35	44905	Sales Oliveira
35	45001	Salesópolis
35	45100	Salmourão
35	45159	Saltinho
35	45209	Salto
35	45308	Salto de Pirapora
35	45407	Salto Grande
35	45506	Sandovalina
35	45605	Santa Adélia
35	45704	Santa Albertina
35	45803	Santa Bárbara d'Oeste
35	46009	Santa Branca
35	46108	Santa Clara d'Oeste
35	46207	Santa Cruz da Conceição
35	46256	Santa Cruz da Esperança
35	46306	Santa Cruz das Palmeiras
35	46405	Santa Cruz do Rio Pardo
35	46504	Santa Ernestina
35	46603	Santa Fé do Sul
35	46702	Santa Gertrudes
35	46801	Santa Isabel
35	46900	Santa Lúcia
35	47007	Santa Maria da Serra
35	47106	Santa Mercedes
35	47502	Santa Rita do Passa Quatro
35	47403	Santa Rita d'Oeste
35	47601	Santa Rosa de Viterbo
35	47650	Santa Salete
35	47205	Santana da Ponte Pensa
35	47304	Santana de Parnaíba
35	47700	Santo Anastácio
35	47809	Santo André
35	47908	Santo Antônio da Alegria
35	48005	Santo Antônio de Posse
35	48054	Santo Antônio do Aracanguá
35	48104	Santo Antônio do Jardim
35	48203	Santo Antônio do Pinhal
35	48302	Santo Expedito
35	48401	Santópolis do Aguapeí
35	48500	Santos
35	48609	São Bento do Sapucaí
35	48708	São Bernardo do Campo
35	48807	São Caetano do Sul
35	48906	São Carlos
35	49003	São Francisco
35	49102	São João da Boa Vista
35	49201	São João das Duas Pontes
35	49250	São João de Iracema
35	49300	São João do Pau d'Alho
35	49409	São Joaquim da Barra
35	49508	São José da Bela Vista
35	49607	São José do Barreiro
35	49706	São José do Rio Pardo
35	49805	São José do Rio Preto
35	49904	São José dos Campos
35	49953	São Lourenço da Serra
35	50001	São Luiz do Paraitinga
35	50100	São Manuel
35	50209	São Miguel Arcanjo
35	50308	São Paulo
35	50407	São Pedro
35	50506	São Pedro do Turvo
35	50605	São Roque
35	50704	São Sebastião
35	50803	São Sebastião da Grama
35	50902	São Simão
35	51009	São Vicente
35	51108	Sarapuí
35	51207	Sarutaiá
35	51306	Sebastianópolis do Sul
35	51405	Serra Azul
35	51603	Serra Negra
35	51504	Serrana
35	51702	Sertãozinho
35	51801	Sete Barras
35	51900	Severínia
35	52007	Silveiras
35	52106	Socorro
35	52205	Sorocaba
35	52304	Sud Mennucci
35	52403	Sumaré
35	52551	Suzanápolis
35	52502	Suzano
35	52601	Tabapuã
35	52700	Tabatinga
35	52809	Taboão da Serra
35	52908	Taciba
35	53005	Taguaí
35	53104	Taiaçu
35	53203	Taiúva
35	53302	Tambaú
35	53401	Tanabi
35	53500	Tapiraí
35	53609	Tapiratiba
35	53658	Taquaral
35	53708	Taquaritinga
35	53807	Taquarituba
35	53856	Taquarivaí
35	53906	Tarabai
35	53955	Tarumã
35	54003	Tatuí
35	54102	Taubaté
35	54201	Tejupá
35	54300	Teodoro Sampaio
35	54409	Terra Roxa
35	54508	Tietê
35	54607	Timburi
35	54656	Torre de Pedra
35	54706	Torrinha
35	54755	Trabiju
35	54805	Tremembé
35	54904	Três Fronteiras
35	54953	Tuiuti
35	55000	Tupã
35	55109	Tupi Paulista
35	55208	Turiúba
35	55307	Turmalina
35	55356	Ubarana
35	55406	Ubatuba
35	55505	Ubirajara
35	55604	Uchoa
35	55703	União Paulista
35	55802	Urânia
35	55901	Uru
35	56008	Urupês
35	56107	Valentim Gentil
35	56206	Valinhos
35	56305	Valparaíso
35	56354	Vargem
35	56404	Vargem Grande do Sul
35	56453	Vargem Grande Paulista
35	56503	Várzea Paulista
35	56602	Vera Cruz
35	56701	Vinhedo
35	56800	Viradouro
35	56909	Vista Alegre do Alto
35	56958	Vitória Brasil
35	57006	Votorantim
35	57105	Votuporanga
35	57154	Zacarias
41	00103	Abatiá
41	00202	Adrianópolis
41	00301	Agudos do Sul
41	00400	Almirante Tamandaré
41	00459	Altamira do Paraná
41	28625	Alto Paraíso
41	00608	Alto Paraná
41	00707	Alto Piquiri
41	00509	Altônia
41	00806	Alvorada do Sul
41	00905	Amaporã
41	01002	Ampére
41	01051	Anahy
41	01101	Andirá
41	01150	Ângulo
41	01200	Antonina
41	01309	Antônio Olinto
41	01408	Apucarana
41	01507	Arapongas
41	01606	Arapoti
41	01655	Arapuã
41	01705	Araruna
41	01804	Araucária
41	01853	Ariranha do Ivaí
41	01903	Assaí
41	02000	Assis Chateaubriand
41	02109	Astorga
41	02208	Atalaia
41	02307	Balsa Nova
41	02406	Bandeirantes
41	02505	Barbosa Ferraz
41	02703	Barra do Jacaré
41	02604	Barracão
41	02752	Bela Vista da Caroba
41	02802	Bela Vista do Paraíso
41	02901	Bituruna
41	03008	Boa Esperança
41	03024	Boa Esperança do Iguaçu
41	03040	Boa Ventura de São Roque
41	03057	Boa Vista da Aparecida
41	03107	Bocaiúva do Sul
41	03156	Bom Jesus do Sul
41	03206	Bom Sucesso
41	03222	Bom Sucesso do Sul
41	03305	Borrazópolis
41	03354	Braganey
41	03370	Brasilândia do Sul
41	03404	Cafeara
41	03453	Cafelândia
41	03479	Cafezal do Sul
41	03503	Califórnia
41	03602	Cambará
41	03701	Cambé
41	03800	Cambira
41	03909	Campina da Lagoa
41	03958	Campina do Simão
41	04006	Campina Grande do Sul
41	04055	Campo Bonito
41	04105	Campo do Tenente
41	04204	Campo Largo
41	04253	Campo Magro
41	04303	Campo Mourão
41	04402	Cândido de Abreu
41	04428	Candói
41	04451	Cantagalo
41	04501	Capanema
41	04600	Capitão Leônidas Marques
41	04659	Carambeí
41	04709	Carlópolis
41	04808	Cascavel
41	04907	Castro
41	05003	Catanduvas
41	05102	Centenário do Sul
41	05201	Cerro Azul
41	05300	Céu Azul
41	05409	Chopinzinho
41	05508	Cianorte
41	05607	Cidade Gaúcha
41	05706	Clevelândia
41	05805	Colombo
41	05904	Colorado
41	06001	Congonhinhas
41	06100	Conselheiro Mairinck
41	06209	Contenda
41	06308	Corbélia
41	06407	Cornélio Procópio
41	06456	Coronel Domingos Soares
41	06506	Coronel Vivida
41	06555	Corumbataí do Sul
41	06803	Cruz Machado
41	06571	Cruzeiro do Iguaçu
41	06605	Cruzeiro do Oeste
41	06704	Cruzeiro do Sul
41	06852	Cruzmaltina
41	06902	Curitiba
41	07009	Curiúva
41	07108	Diamante do Norte
41	07124	Diamante do Sul
41	07157	Diamante D'Oeste
41	07207	Dois Vizinhos
41	07256	Douradina
41	07306	Doutor Camargo
41	28633	Doutor Ulysses
41	07405	Enéas Marques
41	07504	Engenheiro Beltrão
41	07538	Entre Rios do Oeste
41	07520	Esperança Nova
41	07546	Espigão Alto do Iguaçu
41	07553	Farol
41	07603	Faxinal
41	07652	Fazenda Rio Grande
41	07702	Fênix
41	07736	Fernandes Pinheiro
41	07751	Figueira
41	07850	Flor da Serra do Sul
41	07801	Floraí
41	07900	Floresta
41	08007	Florestópolis
41	08106	Flórida
41	08205	Formosa do Oeste
41	08304	Foz do Iguaçu
41	08452	Foz do Jordão
41	08320	Francisco Alves
41	08403	Francisco Beltrão
41	08502	General Carneiro
41	08551	Godoy Moreira
41	08601	Goioerê
41	08650	Goioxim
41	08700	Grandes Rios
41	08809	Guaíra
41	08908	Guairaçá
41	08957	Guamiranga
41	09005	Guapirama
41	09104	Guaporema
41	09203	Guaraci
41	09302	Guaraniaçu
41	09401	Guarapuava
41	09500	Guaraqueçaba
41	09609	Guaratuba
41	09658	Honório Serpa
41	09708	Ibaiti
41	09757	Ibema
41	09807	Ibiporã
41	09906	Icaraíma
41	10003	Iguaraçu
41	10052	Iguatu
41	10078	Imbaú
41	10102	Imbituva
41	10201	Inácio Martins
41	10300	Inajá
41	10409	Indianópolis
41	10508	Ipiranga
41	10607	Iporã
41	10656	Iracema do Oeste
41	10706	Irati
41	10805	Iretama
41	10904	Itaguajé
41	10953	Itaipulândia
41	11001	Itambaracá
41	11100	Itambé
41	11209	Itapejara d'Oeste
41	11258	Itaperuçu
41	11308	Itaúna do Sul
41	11407	Ivaí
41	11506	Ivaiporã
41	11555	Ivaté
41	11605	Ivatuba
41	11704	Jaboti
41	11803	Jacarezinho
41	11902	Jaguapitã
41	12009	Jaguariaíva
41	12108	Jandaia do Sul
41	12207	Janiópolis
41	12306	Japira
41	12405	Japurá
41	12504	Jardim Alegre
41	12603	Jardim Olinda
41	12702	Jataizinho
41	12751	Jesuítas
41	12801	Joaquim Távora
41	12900	Jundiaí do Sul
41	12959	Juranda
41	13007	Jussara
41	13106	Kaloré
41	13205	Lapa
41	13254	Laranjal
41	13304	Laranjeiras do Sul
41	13403	Leópolis
41	13429	Lidianópolis
41	13452	Lindoeste
41	13502	Loanda
41	13601	Lobato
41	13700	Londrina
41	13734	Luiziana
41	13759	Lunardelli
41	13809	Lupionópolis
41	13908	Mallet
41	14005	Mamborê
41	14104	Mandaguaçu
41	14203	Mandaguari
41	14302	Mandirituba
41	14351	Manfrinópolis
41	14401	Mangueirinha
41	14500	Manoel Ribas
41	14609	Marechal Cândido Rondon
41	14708	Maria Helena
41	14807	Marialva
41	14906	Marilândia do Sul
41	15002	Marilena
41	15101	Mariluz
41	15200	Maringá
41	15309	Mariópolis
41	15358	Maripá
41	15408	Marmeleiro
41	15457	Marquinho
41	15507	Marumbi
41	15606	Matelândia
41	15705	Matinhos
41	15739	Mato Rico
41	15754	Mauá da Serra
41	15804	Medianeira
41	15853	Mercedes
41	15903	Mirador
41	16000	Miraselva
41	16059	Missal
41	16109	Moreira Sales
41	16208	Morretes
41	16307	Munhoz de Melo
41	16406	Nossa Senhora das Graças
41	16505	Nova Aliança do Ivaí
41	16604	Nova América da Colina
41	16703	Nova Aurora
41	16802	Nova Cantu
41	16901	Nova Esperança
41	16950	Nova Esperança do Sudoeste
41	17008	Nova Fátima
41	17057	Nova Laranjeiras
41	17107	Nova Londrina
41	17206	Nova Olímpia
41	17255	Nova Prata do Iguaçu
41	17214	Nova Santa Bárbara
41	17222	Nova Santa Rosa
41	17271	Nova Tebas
41	17297	Novo Itacolomi
41	17305	Ortigueira
41	17404	Ourizona
41	17453	Ouro Verde do Oeste
41	17503	Paiçandu
41	17602	Palmas
41	17701	Palmeira
41	17800	Palmital
41	17909	Palotina
41	18006	Paraíso do Norte
41	18105	Paranacity
41	18204	Paranaguá
41	18303	Paranapoema
41	18402	Paranavaí
41	18451	Pato Bragado
41	18501	Pato Branco
41	18600	Paula Freitas
41	18709	Paulo Frontin
41	18808	Peabiru
41	18857	Perobal
41	18907	Pérola
41	19004	Pérola d'Oeste
41	19103	Piên
41	19152	Pinhais
41	19251	Pinhal de São Bento
41	19202	Pinhalão
41	19301	Pinhão
41	19400	Piraí do Sul
41	19509	Piraquara
41	19608	Pitanga
41	19657	Pitangueiras
41	19707	Planaltina do Paraná
41	19806	Planalto
41	19905	Ponta Grossa
41	19954	Pontal do Paraná
41	20002	Porecatu
41	20101	Porto Amazonas
41	20150	Porto Barreiro
41	20200	Porto Rico
41	20309	Porto Vitória
41	20333	Prado Ferreira
41	20358	Pranchita
41	20408	Presidente Castelo Branco
41	20507	Primeiro de Maio
41	20606	Prudentópolis
41	20655	Quarto Centenário
41	20705	Quatiguá
41	20804	Quatro Barras
41	20853	Quatro Pontes
41	20903	Quedas do Iguaçu
41	21000	Querência do Norte
41	21109	Quinta do Sol
41	21208	Quitandinha
41	21257	Ramilândia
41	21307	Rancho Alegre
41	21356	Rancho Alegre D'Oeste
41	21406	Realeza
41	21505	Rebouças
41	21604	Renascença
41	21703	Reserva
41	21752	Reserva do Iguaçu
41	21802	Ribeirão Claro
41	21901	Ribeirão do Pinhal
41	22008	Rio Azul
41	22107	Rio Bom
41	22156	Rio Bonito do Iguaçu
41	22172	Rio Branco do Ivaí
41	22206	Rio Branco do Sul
41	22305	Rio Negro
41	22404	Rolândia
41	22503	Roncador
41	22602	Rondon
41	22651	Rosário do Ivaí
41	22701	Sabáudia
41	22800	Salgado Filho
41	22909	Salto do Itararé
41	23006	Salto do Lontra
41	23105	Santa Amélia
41	23204	Santa Cecília do Pavão
41	23303	Santa Cruz de Monte Castelo
41	23402	Santa Fé
41	23501	Santa Helena
41	23600	Santa Inês
41	23709	Santa Isabel do Ivaí
41	23808	Santa Izabel do Oeste
41	23824	Santa Lúcia
41	23857	Santa Maria do Oeste
41	23907	Santa Mariana
41	23956	Santa Mônica
41	24020	Santa Tereza do Oeste
41	24053	Santa Terezinha de Itaipu
41	24004	Santana do Itararé
41	24103	Santo Antônio da Platina
41	24202	Santo Antônio do Caiuá
41	24301	Santo Antônio do Paraíso
41	24400	Santo Antônio do Sudoeste
41	24509	Santo Inácio
41	24608	São Carlos do Ivaí
41	24707	São Jerônimo da Serra
41	24806	São João
41	24905	São João do Caiuá
41	25001	São João do Ivaí
41	25100	São João do Triunfo
41	25308	São Jorge do Ivaí
41	25357	São Jorge do Patrocínio
41	25209	São Jorge d'Oeste
41	25407	São José da Boa Vista
41	25456	São José das Palmeiras
41	25506	São José dos Pinhais
41	25555	São Manoel do Paraná
41	25605	São Mateus do Sul
41	25704	São Miguel do Iguaçu
41	25753	São Pedro do Iguaçu
41	25803	São Pedro do Ivaí
41	25902	São Pedro do Paraná
41	26009	São Sebastião da Amoreira
41	26108	São Tomé
41	26207	Sapopema
41	26256	Sarandi
41	26272	Saudade do Iguaçu
41	26306	Sengés
41	26355	Serranópolis do Iguaçu
41	26405	Sertaneja
41	26504	Sertanópolis
41	26603	Siqueira Campos
41	26652	Sulina
41	26678	Tamarana
41	26702	Tamboara
41	26801	Tapejara
41	26900	Tapira
41	27007	Teixeira Soares
41	27106	Telêmaco Borba
41	27205	Terra Boa
41	27304	Terra Rica
41	27403	Terra Roxa
41	27502	Tibagi
41	27601	Tijucas do Sul
41	27700	Toledo
41	27809	Tomazina
41	27858	Três Barras do Paraná
41	27882	Tunas do Paraná
41	27908	Tuneiras do Oeste
41	27957	Tupãssi
41	27965	Turvo
41	28005	Ubiratã
41	28104	Umuarama
41	28203	União da Vitória
41	28302	Uniflor
41	28401	Uraí
41	28534	Ventania
41	28559	Vera Cruz do Oeste
41	28609	Verê
41	28658	Virmond
41	28708	Vitorino
41	28500	Wenceslau Braz
41	28807	Xambrê
42	00051	Abdon Batista
42	00101	Abelardo Luz
42	00200	Agrolândia
42	00309	Agronômica
42	00408	Água Doce
42	00507	Águas de Chapecó
42	00556	Águas Frias
42	00606	Águas Mornas
42	00705	Alfredo Wagner
42	00754	Alto Bela Vista
42	00804	Anchieta
42	00903	Angelina
42	01000	Anita Garibaldi
42	01109	Anitápolis
42	01208	Antônio Carlos
42	01257	Apiúna
42	01273	Arabutã
42	01307	Araquari
42	01406	Araranguá
42	01505	Armazém
42	01604	Arroio Trinta
42	01653	Arvoredo
42	01703	Ascurra
42	01802	Atalanta
42	01901	Aurora
42	01950	Balneário Arroio do Silva
42	02057	Balneário Barra do Sul
42	02008	Balneário Camboriú
42	02073	Balneário Gaivota
42	12809	Balneário Piçarras
42	20000	Balneário Rincão
42	02081	Bandeirante
42	02099	Barra Bonita
42	02107	Barra Velha
42	02131	Bela Vista do Toldo
42	02156	Belmonte
42	02206	Benedito Novo
42	02305	Biguaçu
42	02404	Blumenau
42	02438	Bocaina do Sul
42	02503	Bom Jardim da Serra
42	02537	Bom Jesus
42	02578	Bom Jesus do Oeste
42	02602	Bom Retiro
42	02453	Bombinhas
42	02701	Botuverá
42	02800	Braço do Norte
42	02859	Braço do Trombudo
42	02875	Brunópolis
42	02909	Brusque
42	03006	Caçador
42	03105	Caibi
42	03154	Calmon
42	03204	Camboriú
42	03303	Campo Alegre
42	03402	Campo Belo do Sul
42	03501	Campo Erê
42	03600	Campos Novos
42	03709	Canelinha
42	03808	Canoinhas
42	03253	Capão Alto
42	03907	Capinzal
42	03956	Capivari de Baixo
42	04004	Catanduvas
42	04103	Caxambu do Sul
42	04152	Celso Ramos
42	04178	Cerro Negro
42	04194	Chapadão do Lageado
42	04202	Chapecó
42	04251	Cocal do Sul
42	04301	Concórdia
42	04350	Cordilheira Alta
42	04400	Coronel Freitas
42	04459	Coronel Martins
42	04558	Correia Pinto
42	04509	Corupá
42	04608	Criciúma
42	04707	Cunha Porã
42	04756	Cunhataí
42	04806	Curitibanos
42	04905	Descanso
42	05001	Dionísio Cerqueira
42	05100	Dona Emma
42	05159	Doutor Pedrinho
42	05175	Entre Rios
42	05191	Ermo
42	05209	Erval Velho
42	05308	Faxinal dos Guedes
42	05357	Flor do Sertão
42	05407	Florianópolis
42	05431	Formosa do Sul
42	05456	Forquilhinha
42	05506	Fraiburgo
42	05555	Frei Rogério
42	05605	Galvão
42	05704	Garopaba
42	05803	Garuva
42	05902	Gaspar
42	06009	Governador Celso Ramos
42	06108	Grão Pará
42	06207	Gravatal
42	06306	Guabiruba
42	06405	Guaraciaba
42	06504	Guaramirim
42	06603	Guarujá do Sul
42	06652	Guatambú
42	06702	Herval d'Oeste
42	06751	Ibiam
42	06801	Ibicaré
42	06900	Ibirama
42	07007	Içara
42	07106	Ilhota
42	07205	Imaruí
42	07304	Imbituba
42	07403	Imbuia
42	07502	Indaial
42	07577	Iomerê
42	07601	Ipira
42	07650	Iporã do Oeste
42	07684	Ipuaçu
42	07700	Ipumirim
42	07759	Iraceminha
42	07809	Irani
42	07858	Irati
42	07908	Irineópolis
42	08005	Itá
42	08104	Itaiópolis
42	08203	Itajaí
42	08302	Itapema
42	08401	Itapiranga
42	08450	Itapoá
42	08500	Ituporanga
42	08609	Jaborá
42	08708	Jacinto Machado
42	08807	Jaguaruna
42	08906	Jaraguá do Sul
42	08955	Jardinópolis
42	09003	Joaçaba
42	09102	Joinville
42	09151	José Boiteux
42	09177	Jupiá
42	09201	Lacerdópolis
42	09300	Lages
42	09409	Laguna
42	09458	Lajeado Grande
42	09508	Laurentino
42	09607	Lauro Müller
42	09706	Lebon Régis
42	09805	Leoberto Leal
42	09854	Lindóia do Sul
42	09904	Lontras
42	10001	Luiz Alves
42	10035	Luzerna
42	10050	Macieira
42	10100	Mafra
42	10209	Major Gercino
42	10308	Major Vieira
42	10407	Maracajá
42	10506	Maravilha
42	10555	Marema
42	10605	Massaranduba
42	10704	Matos Costa
42	10803	Meleiro
42	10852	Mirim Doce
42	10902	Modelo
42	11009	Mondaí
42	11058	Monte Carlo
42	11108	Monte Castelo
42	11207	Morro da Fumaça
42	11256	Morro Grande
42	11306	Navegantes
42	11405	Nova Erechim
42	11454	Nova Itaberaba
42	11504	Nova Trento
42	11603	Nova Veneza
42	11652	Novo Horizonte
42	11702	Orleans
42	11751	Otacílio Costa
42	11801	Ouro
42	11850	Ouro Verde
42	11876	Paial
42	11892	Painel
42	11900	Palhoça
42	12007	Palma Sola
42	12056	Palmeira
42	12106	Palmitos
42	12205	Papanduva
42	12239	Paraíso
42	12254	Passo de Torres
42	12270	Passos Maia
42	12304	Paulo Lopes
42	12403	Pedras Grandes
42	12502	Penha
42	12601	Peritiba
42	12650	Pescaria Brava
42	12700	Petrolândia
42	12908	Pinhalzinho
42	13005	Pinheiro Preto
42	13104	Piratuba
42	13153	Planalto Alegre
42	13203	Pomerode
42	13302	Ponte Alta
42	13351	Ponte Alta do Norte
42	13401	Ponte Serrada
42	13500	Porto Belo
42	13609	Porto União
42	13708	Pouso Redondo
42	13807	Praia Grande
42	13906	Presidente Castello Branco
42	14003	Presidente Getúlio
42	14102	Presidente Nereu
42	14151	Princesa
42	14201	Quilombo
42	14300	Rancho Queimado
42	14409	Rio das Antas
42	14508	Rio do Campo
42	14607	Rio do Oeste
42	14805	Rio do Sul
42	14706	Rio dos Cedros
42	14904	Rio Fortuna
42	15000	Rio Negrinho
42	15059	Rio Rufino
42	15075	Riqueza
42	15109	Rodeio
42	15208	Romelândia
42	15307	Salete
42	15356	Saltinho
42	15406	Salto Veloso
42	15455	Sangão
42	15505	Santa Cecília
42	15554	Santa Helena
42	15604	Santa Rosa de Lima
42	15653	Santa Rosa do Sul
42	15679	Santa Terezinha
42	15687	Santa Terezinha do Progresso
42	15695	Santiago do Sul
42	15703	Santo Amaro da Imperatriz
42	15802	São Bento do Sul
42	15752	São Bernardino
42	15901	São Bonifácio
42	16008	São Carlos
42	16057	São Cristóvão do Sul
42	16107	São Domingos
42	16206	São Francisco do Sul
42	16305	São João Batista
42	16354	São João do Itaperiú
42	16255	São João do Oeste
42	16404	São João do Sul
42	16503	São Joaquim
42	16602	São José
42	16701	São José do Cedro
42	16800	São José do Cerrito
42	16909	São Lourenço do Oeste
42	17006	São Ludgero
42	17105	São Martinho
42	17154	São Miguel da Boa Vista
42	17204	São Miguel do Oeste
42	17253	São Pedro de Alcântara
42	17303	Saudades
42	17402	Schroeder
42	17501	Seara
42	17550	Serra Alta
42	17600	Siderópolis
42	17709	Sombrio
42	17758	Sul Brasil
42	17808	Taió
42	17907	Tangará
42	17956	Tigrinhos
42	18004	Tijucas
42	18103	Timbé do Sul
42	18202	Timbó
42	18251	Timbó Grande
42	18301	Três Barras
42	18350	Treviso
42	18400	Treze de Maio
42	18509	Treze Tílias
42	18608	Trombudo Central
42	18707	Tubarão
42	18756	Tunápolis
42	18806	Turvo
42	18855	União do Oeste
42	18905	Urubici
42	18954	Urupema
42	19002	Urussanga
42	19101	Vargeão
42	19150	Vargem
42	19176	Vargem Bonita
42	19200	Vidal Ramos
42	19309	Videira
42	19358	Vitor Meireles
42	19408	Witmarsum
42	19507	Xanxerê
42	19606	Xavantina
42	19705	Xaxim
42	19853	Zortéa
43	00034	Aceguá
43	00059	Água Santa
43	00109	Agudo
43	00208	Ajuricaba
43	00307	Alecrim
43	00406	Alegrete
43	00455	Alegria
43	00471	Almirante Tamandaré do Sul
43	00505	Alpestre
43	00554	Alto Alegre
43	00570	Alto Feliz
43	00604	Alvorada
43	00638	Amaral Ferrador
43	00646	Ametista do Sul
43	00661	André da Rocha
43	00703	Anta Gorda
43	00802	Antônio Prado
43	00851	Arambaré
43	00877	Araricá
43	00901	Aratiba
43	01008	Arroio do Meio
43	01073	Arroio do Padre
43	01057	Arroio do Sal
43	01206	Arroio do Tigre
43	01107	Arroio dos Ratos
43	01305	Arroio Grande
43	01404	Arvorezinha
43	01503	Augusto Pestana
43	01552	Áurea
43	01602	Bagé
43	01636	Balneário Pinhal
43	01651	Barão
43	01701	Barão de Cotegipe
43	01750	Barão do Triunfo
43	01859	Barra do Guarita
43	01875	Barra do Quaraí
43	01909	Barra do Ribeiro
43	01925	Barra do Rio Azul
43	01958	Barra Funda
43	01800	Barracão
43	02006	Barros Cassal
43	02055	Benjamin Constant do Sul
43	02105	Bento Gonçalves
43	02154	Boa Vista das Missões
43	02204	Boa Vista do Buricá
43	02220	Boa Vista do Cadeado
43	02238	Boa Vista do Incra
43	02253	Boa Vista do Sul
43	02303	Bom Jesus
43	02352	Bom Princípio
43	02378	Bom Progresso
43	02402	Bom Retiro do Sul
43	02451	Boqueirão do Leão
43	02501	Bossoroca
43	02584	Bozano
43	02600	Braga
43	02659	Brochier
43	02709	Butiá
43	02808	Caçapava do Sul
43	02907	Cacequi
43	03004	Cachoeira do Sul
43	03103	Cachoeirinha
43	03202	Cacique Doble
43	03301	Caibaté
43	03400	Caiçara
43	03509	Camaquã
43	03558	Camargo
43	03608	Cambará do Sul
43	03673	Campestre da Serra
43	03707	Campina das Missões
43	03806	Campinas do Sul
43	03905	Campo Bom
43	04002	Campo Novo
43	04101	Campos Borges
43	04200	Candelária
43	04309	Cândido Godói
43	04358	Candiota
43	04408	Canela
43	04507	Canguçu
43	04606	Canoas
43	04614	Canudos do Vale
43	04622	Capão Bonito do Sul
43	04630	Capão da Canoa
43	04655	Capão do Cipó
43	04663	Capão do Leão
43	04689	Capela de Santana
43	04697	Capitão
43	04671	Capivari do Sul
43	04713	Caraá
43	04705	Carazinho
43	04804	Carlos Barbosa
43	04853	Carlos Gomes
43	04903	Casca
43	04952	Caseiros
43	05009	Catuípe
43	05108	Caxias do Sul
43	05116	Centenário
43	05124	Cerrito
43	05132	Cerro Branco
43	05157	Cerro Grande
43	05173	Cerro Grande do Sul
43	05207	Cerro Largo
43	05306	Chapada
43	05355	Charqueadas
43	05371	Charrua
43	05405	Chiapetta
43	05439	Chuí
43	05447	Chuvisca
43	05454	Cidreira
43	05504	Ciríaco
43	05587	Colinas
43	05603	Colorado
43	05702	Condor
43	05801	Constantina
43	05835	Coqueiro Baixo
43	05850	Coqueiros do Sul
43	05871	Coronel Barros
43	05900	Coronel Bicaco
43	05934	Coronel Pilar
43	05959	Cotiporã
43	05975	Coxilha
43	06007	Crissiumal
43	06056	Cristal
43	06072	Cristal do Sul
43	06106	Cruz Alta
43	06130	Cruzaltense
43	06205	Cruzeiro do Sul
43	06304	David Canabarro
43	06320	Derrubadas
43	06353	Dezesseis de Novembro
43	06379	Dilermando de Aguiar
43	06403	Dois Irmãos
43	06429	Dois Irmãos das Missões
43	06452	Dois Lajeados
43	06502	Dom Feliciano
43	06601	Dom Pedrito
43	06551	Dom Pedro de Alcântara
43	06700	Dona Francisca
43	06734	Doutor Maurício Cardoso
43	06759	Doutor Ricardo
43	06767	Eldorado do Sul
43	06809	Encantado
43	06908	Encruzilhada do Sul
43	06924	Engenho Velho
43	06957	Entre Rios do Sul
43	06932	Entre-Ijuís
43	06973	Erebango
43	07005	Erechim
43	07054	Ernestina
43	07203	Erval Grande
43	07302	Erval Seco
43	07401	Esmeralda
43	07450	Esperança do Sul
43	07500	Espumoso
43	07559	Estação
43	07609	Estância Velha
43	07708	Esteio
43	07807	Estrela
43	07815	Estrela Velha
43	07831	Eugênio de Castro
43	07864	Fagundes Varela
43	07906	Farroupilha
43	08003	Faxinal do Soturno
43	08052	Faxinalzinho
43	08078	Fazenda Vilanova
43	08102	Feliz
43	08201	Flores da Cunha
43	08250	Floriano Peixoto
43	08300	Fontoura Xavier
43	08409	Formigueiro
43	08433	Forquetinha
43	08458	Fortaleza dos Valos
43	08508	Frederico Westphalen
43	08607	Garibaldi
43	08656	Garruchos
43	08706	Gaurama
43	08805	General Câmara
43	08854	Gentil
43	08904	Getúlio Vargas
43	09001	Giruá
43	09050	Glorinha
43	09100	Gramado
43	09126	Gramado dos Loureiros
43	09159	Gramado Xavier
43	09209	Gravataí
43	09258	Guabiju
43	09308	Guaíba
43	09407	Guaporé
43	09506	Guarani das Missões
43	09555	Harmonia
43	07104	Herval
43	09571	Herveiras
43	09605	Horizontina
43	09654	Hulha Negra
43	09704	Humaitá
43	09753	Ibarama
43	09803	Ibiaçá
43	09902	Ibiraiaras
43	09951	Ibirapuitã
43	10009	Ibirubá
43	10108	Igrejinha
43	10207	Ijuí
43	10306	Ilópolis
43	10330	Imbé
43	10363	Imigrante
43	10405	Independência
43	10413	Inhacorá
43	10439	Ipê
43	10462	Ipiranga do Sul
43	10504	Iraí
43	10538	Itaara
43	10553	Itacurubi
43	10579	Itapuca
43	10603	Itaqui
43	10652	Itati
43	10702	Itatiba do Sul
43	10751	Ivorá
43	10801	Ivoti
43	10850	Jaboticaba
43	10876	Jacuizinho
43	10900	Jacutinga
43	11007	Jaguarão
43	11106	Jaguari
43	11122	Jaquirana
43	11130	Jari
43	11155	Jóia
43	11205	Júlio de Castilhos
43	11239	Lagoa Bonita do Sul
43	11270	Lagoa dos Três Cantos
43	11304	Lagoa Vermelha
43	11254	Lagoão
43	11403	Lajeado
43	11429	Lajeado do Bugre
43	11502	Lavras do Sul
43	11601	Liberato Salzano
43	11627	Lindolfo Collor
43	11643	Linha Nova
43	11718	Maçambará
43	11700	Machadinho
43	11734	Mampituba
43	11759	Manoel Viana
43	11775	Maquiné
43	11791	Maratá
43	11809	Marau
43	11908	Marcelino Ramos
43	11981	Mariana Pimentel
43	12005	Mariano Moro
43	12054	Marques de Souza
43	12104	Mata
43	12138	Mato Castelhano
43	12153	Mato Leitão
43	12179	Mato Queimado
43	12203	Maximiliano de Almeida
43	12252	Minas do Leão
43	12302	Miraguaí
43	12351	Montauri
43	12377	Monte Alegre dos Campos
43	12385	Monte Belo do Sul
43	12401	Montenegro
43	12427	Mormaço
43	12443	Morrinhos do Sul
43	12450	Morro Redondo
43	12476	Morro Reuter
43	12500	Mostardas
43	12609	Muçum
43	12617	Muitos Capões
43	12625	Muliterno
43	12658	Não-Me-Toque
43	12674	Nicolau Vergueiro
43	12708	Nonoai
43	12757	Nova Alvorada
43	12807	Nova Araçá
43	12906	Nova Bassano
43	12955	Nova Boa Vista
43	13003	Nova Bréscia
43	13011	Nova Candelária
43	13037	Nova Esperança do Sul
43	13060	Nova Hartz
43	13086	Nova Pádua
43	13102	Nova Palma
43	13201	Nova Petrópolis
43	13300	Nova Prata
43	13334	Nova Ramada
43	13359	Nova Roma do Sul
43	13375	Nova Santa Rita
43	13490	Novo Barreiro
43	13391	Novo Cabrais
43	13409	Novo Hamburgo
43	13425	Novo Machado
43	13441	Novo Tiradentes
43	13466	Novo Xingu
43	13508	Osório
43	13607	Paim Filho
43	13656	Palmares do Sul
43	13706	Palmeira das Missões
43	13805	Palmitinho
43	13904	Panambi
43	13953	Pantano Grande
43	14001	Paraí
43	14027	Paraíso do Sul
43	14035	Pareci Novo
43	14050	Parobé
43	14068	Passa Sete
43	14076	Passo do Sobrado
43	14100	Passo Fundo
43	14134	Paulo Bento
43	14159	Paverama
43	14175	Pedras Altas
43	14209	Pedro Osório
43	14308	Pejuçara
43	14407	Pelotas
43	14423	Picada Café
43	14456	Pinhal
43	14464	Pinhal da Serra
43	14472	Pinhal Grande
43	14498	Pinheirinho do Vale
43	14506	Pinheiro Machado
43	14548	Pinto Bandeira
43	14555	Pirapó
43	14605	Piratini
43	14704	Planalto
43	14753	Poço das Antas
43	14779	Pontão
43	14787	Ponte Preta
43	14803	Portão
43	14902	Porto Alegre
43	15008	Porto Lucena
43	15057	Porto Mauá
43	15073	Porto Vera Cruz
43	15107	Porto Xavier
43	15131	Pouso Novo
43	15149	Presidente Lucena
43	15156	Progresso
43	15172	Protásio Alves
43	15206	Putinga
43	15305	Quaraí
43	15313	Quatro Irmãos
43	15321	Quevedos
43	15354	Quinze de Novembro
43	15404	Redentora
43	15453	Relvado
43	15503	Restinga Sêca
43	15552	Rio dos Índios
43	15602	Rio Grande
43	15701	Rio Pardo
43	15750	Riozinho
43	15800	Roca Sales
43	15909	Rodeio Bonito
43	15958	Rolador
43	16006	Rolante
43	16105	Ronda Alta
43	16204	Rondinha
43	16303	Roque Gonzales
43	16402	Rosário do Sul
43	16428	Sagrada Família
43	16436	Saldanha Marinho
43	16451	Salto do Jacuí
43	16477	Salvador das Missões
43	16501	Salvador do Sul
43	16600	Sananduva
43	16709	Santa Bárbara do Sul
43	16733	Santa Cecília do Sul
43	16758	Santa Clara do Sul
43	16808	Santa Cruz do Sul
43	16972	Santa Margarida do Sul
43	16907	Santa Maria
43	16956	Santa Maria do Herval
43	17202	Santa Rosa
43	17251	Santa Tereza
43	17301	Santa Vitória do Palmar
43	17004	Santana da Boa Vista
43	17103	Sant'Ana do Livramento
43	17400	Santiago
43	17509	Santo Ângelo
43	17608	Santo Antônio da Patrulha
43	17707	Santo Antônio das Missões
43	17558	Santo Antônio do Palma
43	17756	Santo Antônio do Planalto
43	17806	Santo Augusto
43	17905	Santo Cristo
43	17954	Santo Expedito do Sul
43	18002	São Borja
43	18051	São Domingos do Sul
43	18101	São Francisco de Assis
43	18200	São Francisco de Paula
43	18309	São Gabriel
43	18408	São Jerônimo
43	18424	São João da Urtiga
43	18432	São João do Polêsine
43	18440	São Jorge
43	18457	São José das Missões
43	18465	São José do Herval
43	18481	São José do Hortêncio
43	18499	São José do Inhacorá
43	18507	São José do Norte
43	18606	São José do Ouro
43	18614	São José do Sul
43	18622	São José dos Ausentes
43	18705	São Leopoldo
43	18804	São Lourenço do Sul
43	18903	São Luiz Gonzaga
43	19000	São Marcos
43	19109	São Martinho
43	19125	São Martinho da Serra
43	19158	São Miguel das Missões
43	19208	São Nicolau
43	19307	São Paulo das Missões
43	19356	São Pedro da Serra
43	19364	São Pedro das Missões
43	19372	São Pedro do Butiá
43	19406	São Pedro do Sul
43	19505	São Sebastião do Caí
43	19604	São Sepé
43	19703	São Valentim
43	19711	São Valentim do Sul
43	19737	São Valério do Sul
43	19752	São Vendelino
43	19802	São Vicente do Sul
43	19901	Sapiranga
43	20008	Sapucaia do Sul
43	20107	Sarandi
43	20206	Seberi
43	20230	Sede Nova
43	20263	Segredo
43	20305	Selbach
43	20321	Senador Salgado Filho
43	20354	Sentinela do Sul
43	20404	Serafina Corrêa
43	20453	Sério
43	20503	Sertão
43	20552	Sertão Santana
43	20578	Sete de Setembro
43	20602	Severiano de Almeida
43	20651	Silveira Martins
43	20677	Sinimbu
43	20701	Sobradinho
43	20800	Soledade
43	20859	Tabaí
43	20909	Tapejara
43	21006	Tapera
43	21105	Tapes
43	21204	Taquara
43	21303	Taquari
43	21329	Taquaruçu do Sul
43	21352	Tavares
43	21402	Tenente Portela
43	21436	Terra de Areia
43	21451	Teutônia
43	21469	Tio Hugo
43	21477	Tiradentes do Sul
43	21493	Toropi
43	21501	Torres
43	21600	Tramandaí
43	21626	Travesseiro
43	21634	Três Arroios
43	21667	Três Cachoeiras
43	21709	Três Coroas
43	21808	Três de Maio
43	21832	Três Forquilhas
43	21857	Três Palmeiras
43	21907	Três Passos
43	21956	Trindade do Sul
43	22004	Triunfo
43	22103	Tucunduva
43	22152	Tunas
43	22186	Tupanci do Sul
43	22202	Tupanciretã
43	22251	Tupandi
43	22301	Tuparendi
43	22327	Turuçu
43	22343	Ubiretama
43	22350	União da Serra
43	22376	Unistalda
43	22400	Uruguaiana
43	22509	Vacaria
43	22533	Vale do Sol
43	22541	Vale Real
43	22525	Vale Verde
43	22558	Vanini
43	22608	Venâncio Aires
43	22707	Vera Cruz
43	22806	Veranópolis
43	22855	Vespasiano Corrêa
43	22905	Viadutos
43	23002	Viamão
43	23101	Vicente Dutra
43	23200	Victor Graeff
43	23309	Vila Flores
43	23358	Vila Lângaro
43	23408	Vila Maria
43	23457	Vila Nova do Sul
43	23507	Vista Alegre
43	23606	Vista Alegre do Prata
43	23705	Vista Gaúcha
43	23754	Vitória das Missões
43	23770	Westfália
43	23804	Xangri-lá
50	00203	Água Clara
50	00252	Alcinópolis
50	00609	Amambai
50	00708	Anastácio
50	00807	Anaurilândia
50	00856	Angélica
50	00906	Antônio João
50	01003	Aparecida do Taboado
50	01102	Aquidauana
50	01243	Aral Moreira
50	01508	Bandeirantes
50	01904	Bataguassu
50	02001	Batayporã
50	02100	Bela Vista
50	02159	Bodoquena
50	02209	Bonito
50	02308	Brasilândia
50	02407	Caarapó
50	02605	Camapuã
50	02704	Campo Grande
50	02803	Caracol
50	02902	Cassilândia
50	02951	Chapadão do Sul
50	03108	Corguinho
50	03157	Coronel Sapucaia
50	03207	Corumbá
50	03256	Costa Rica
50	03306	Coxim
50	03454	Deodápolis
50	03488	Dois Irmãos do Buriti
50	03504	Douradina
50	03702	Dourados
50	03751	Eldorado
50	03801	Fátima do Sul
50	03900	Figueirão
50	04007	Glória de Dourados
50	04106	Guia Lopes da Laguna
50	04304	Iguatemi
50	04403	Inocência
50	04502	Itaporã
50	04601	Itaquiraí
50	04700	Ivinhema
50	04809	Japorã
50	04908	Jaraguari
50	05004	Jardim
50	05103	Jateí
50	05152	Juti
50	05202	Ladário
50	05251	Laguna Carapã
50	05400	Maracaju
50	05608	Miranda
50	05681	Mundo Novo
50	05707	Naviraí
50	05806	Nioaque
50	06002	Nova Alvorada do Sul
50	06200	Nova Andradina
50	06259	Novo Horizonte do Sul
50	06275	Paraíso das Águas
50	06309	Paranaíba
50	06358	Paranhos
50	06408	Pedro Gomes
50	06606	Ponta Porã
50	06903	Porto Murtinho
50	07109	Ribas do Rio Pardo
50	07208	Rio Brilhante
50	07307	Rio Negro
50	07406	Rio Verde de Mato Grosso
50	07505	Rochedo
50	07554	Santa Rita do Pardo
50	07695	São Gabriel do Oeste
50	07802	Selvíria
50	07703	Sete Quedas
50	07901	Sidrolândia
50	07935	Sonora
50	07950	Tacuru
50	07976	Taquarussu
50	08008	Terenos
50	08305	Três Lagoas
50	08404	Vicentina
51	00102	Acorizal
51	00201	Água Boa
51	00250	Alta Floresta
51	00300	Alto Araguaia
51	00359	Alto Boa Vista
51	00409	Alto Garças
51	00508	Alto Paraguai
51	00607	Alto Taquari
51	00805	Apiacás
51	01001	Araguaiana
51	01209	Araguainha
51	01258	Araputanga
51	01308	Arenápolis
51	01407	Aripuanã
51	01605	Barão de Melgaço
51	01704	Barra do Bugres
51	01803	Barra do Garças
51	01852	Bom Jesus do Araguaia
51	01902	Brasnorte
51	02504	Cáceres
51	02603	Campinápolis
51	02637	Campo Novo do Parecis
51	02678	Campo Verde
51	02686	Campos de Júlio
51	02694	Canabrava do Norte
51	02702	Canarana
51	02793	Carlinda
51	02850	Castanheira
51	03007	Chapada dos Guimarães
51	03056	Cláudia
51	03106	Cocalinho
51	03205	Colíder
51	03254	Colniza
51	03304	Comodoro
51	03353	Confresa
51	03361	Conquista D'Oeste
51	03379	Cotriguaçu
51	03403	Cuiabá
51	03437	Curvelândia
51	03452	Denise
51	03502	Diamantino
51	03601	Dom Aquino
51	03700	Feliz Natal
51	03809	Figueirópolis D'Oeste
51	03858	Gaúcha do Norte
51	03908	General Carneiro
51	03957	Glória D'Oeste
51	04104	Guarantã do Norte
51	04203	Guiratinga
51	04500	Indiavaí
51	04526	Ipiranga do Norte
51	04542	Itanhangá
51	04559	Itaúba
51	04609	Itiquira
51	04807	Jaciara
51	04906	Jangada
51	05002	Jauru
51	05101	Juara
51	05150	Juína
51	05176	Juruena
51	05200	Juscimeira
51	05234	Lambari D'Oeste
51	05259	Lucas do Rio Verde
51	05309	Luciara
51	05580	Marcelândia
51	05606	Matupá
51	05622	Mirassol d'Oeste
51	05903	Nobres
51	06000	Nortelândia
51	06109	Nossa Senhora do Livramento
51	06158	Nova Bandeirantes
51	06208	Nova Brasilândia
51	06216	Nova Canaã do Norte
51	08808	Nova Guarita
51	06182	Nova Lacerda
51	08857	Nova Marilândia
51	08907	Nova Maringá
51	08956	Nova Monte Verde
51	06224	Nova Mutum
51	06174	Nova Nazaré
51	06232	Nova Olímpia
51	06190	Nova Santa Helena
51	06240	Nova Ubiratã
51	06257	Nova Xavantina
51	06273	Novo Horizonte do Norte
51	06265	Novo Mundo
51	06315	Novo Santo Antônio
51	06281	Novo São Joaquim
51	06299	Paranaíta
51	06307	Paranatinga
51	06372	Pedra Preta
51	06422	Peixoto de Azevedo
51	06455	Planalto da Serra
51	06505	Poconé
51	06653	Pontal do Araguaia
51	06703	Ponte Branca
51	06752	Pontes e Lacerda
51	06778	Porto Alegre do Norte
51	06802	Porto dos Gaúchos
51	06828	Porto Esperidião
51	06851	Porto Estrela
51	07008	Poxoréu
51	07040	Primavera do Leste
51	07065	Querência
51	07156	Reserva do Cabaçal
51	07180	Ribeirão Cascalheira
51	07198	Ribeirãozinho
51	07206	Rio Branco
51	07578	Rondolândia
51	07602	Rondonópolis
51	07701	Rosário Oeste
51	07750	Salto do Céu
51	07248	Santa Carmem
51	07743	Santa Cruz do Xingu
51	07768	Santa Rita do Trivelato
51	07776	Santa Terezinha
51	07263	Santo Afonso
51	07792	Santo Antônio do Leste
51	07800	Santo Antônio do Leverger
51	07859	São Félix do Araguaia
51	07297	São José do Povo
51	07305	São José do Rio Claro
51	07354	São José do Xingu
51	07107	São José dos Quatro Marcos
51	07404	São Pedro da Cipa
51	07875	Sapezal
51	07883	Serra Nova Dourada
51	07909	Sinop
51	07925	Sorriso
51	07941	Tabaporã
51	07958	Tangará da Serra
51	08006	Tapurah
51	08055	Terra Nova do Norte
51	08105	Tesouro
51	08204	Torixoréu
51	08303	União do Sul
51	08352	Vale de São Domingos
51	08402	Várzea Grande
51	08501	Vera
51	05507	Vila Bela da Santíssima Trindade
51	08600	Vila Rica
52	00050	Abadia de Goiás
52	00100	Abadiânia
52	00134	Acreúna
52	00159	Adelândia
52	00175	Água Fria de Goiás
52	00209	Água Limpa
52	00258	Águas Lindas de Goiás
52	00308	Alexânia
52	00506	Aloândia
52	00555	Alto Horizonte
52	00605	Alto Paraíso de Goiás
52	00803	Alvorada do Norte
52	00829	Amaralina
52	00852	Americano do Brasil
52	00902	Amorinópolis
52	01108	Anápolis
52	01207	Anhanguera
52	01306	Anicuns
52	01405	Aparecida de Goiânia
52	01454	Aparecida do Rio Doce
52	01504	Aporé
52	01603	Araçu
52	01702	Aragarças
52	01801	Aragoiânia
52	02155	Araguapaz
52	02353	Arenópolis
52	02502	Aruanã
52	02601	Aurilândia
52	02809	Avelinópolis
52	03104	Baliza
52	03203	Barro Alto
52	03302	Bela Vista de Goiás
52	03401	Bom Jardim de Goiás
52	03500	Bom Jesus de Goiás
52	03559	Bonfinópolis
52	03575	Bonópolis
52	03609	Brazabrantes
52	03807	Britânia
52	03906	Buriti Alegre
52	03939	Buriti de Goiás
52	03962	Buritinópolis
52	04003	Cabeceiras
52	04102	Cachoeira Alta
52	04201	Cachoeira de Goiás
52	04250	Cachoeira Dourada
52	04300	Caçu
52	04409	Caiapônia
52	04508	Caldas Novas
52	04557	Caldazinha
52	04607	Campestre de Goiás
52	04656	Campinaçu
52	04706	Campinorte
52	04805	Campo Alegre de Goiás
52	04854	Campo Limpo de Goiás
52	04904	Campos Belos
52	04953	Campos Verdes
52	05000	Carmo do Rio Verde
52	05059	Castelândia
52	05109	Catalão
52	05208	Caturaí
52	05307	Cavalcante
52	05406	Ceres
52	05455	Cezarina
52	05471	Chapadão do Céu
52	05497	Cidade Ocidental
52	05513	Cocalzinho de Goiás
52	05521	Colinas do Sul
52	05703	Córrego do Ouro
52	05802	Corumbá de Goiás
52	05901	Corumbaíba
52	06206	Cristalina
52	06305	Cristianópolis
52	06404	Crixás
52	06503	Cromínia
52	06602	Cumari
52	06701	Damianópolis
52	06800	Damolândia
52	06909	Davinópolis
52	07105	Diorama
52	08301	Divinópolis de Goiás
52	07253	Doverlândia
52	07352	Edealina
52	07402	Edéia
52	07501	Estrela do Norte
52	07535	Faina
52	07600	Fazenda Nova
52	07808	Firminópolis
52	07907	Flores de Goiás
52	08004	Formosa
52	08103	Formoso
52	08152	Gameleira de Goiás
52	08400	Goianápolis
52	08509	Goiandira
52	08608	Goianésia
52	08707	Goiânia
52	08806	Goianira
52	08905	Goiás
52	09101	Goiatuba
52	09150	Gouvelândia
52	09200	Guapó
52	09291	Guaraíta
52	09408	Guarani de Goiás
52	09457	Guarinos
52	09606	Heitoraí
52	09705	Hidrolândia
52	09804	Hidrolina
52	09903	Iaciara
52	09937	Inaciolândia
52	09952	Indiara
52	10000	Inhumas
52	10109	Ipameri
52	10158	Ipiranga de Goiás
52	10208	Iporá
52	10307	Israelândia
52	10406	Itaberaí
52	10562	Itaguari
52	10604	Itaguaru
52	10802	Itajá
52	10901	Itapaci
52	11008	Itapirapuã
52	11206	Itapuranga
52	11305	Itarumã
52	11404	Itauçu
52	11503	Itumbiara
52	11602	Ivolândia
52	11701	Jandaia
52	11800	Jaraguá
52	11909	Jataí
52	12006	Jaupaci
52	12055	Jesúpolis
52	12105	Joviânia
52	12204	Jussara
52	12253	Lagoa Santa
52	12303	Leopoldo de Bulhões
52	12501	Luziânia
52	12600	Mairipotaba
52	12709	Mambaí
52	12808	Mara Rosa
52	12907	Marzagão
52	12956	Matrinchã
52	13004	Maurilândia
52	13053	Mimoso de Goiás
52	13087	Minaçu
52	13103	Mineiros
52	13400	Moiporá
52	13509	Monte Alegre de Goiás
52	13707	Montes Claros de Goiás
52	13756	Montividiu
52	13772	Montividiu do Norte
52	13806	Morrinhos
52	13855	Morro Agudo de Goiás
52	13905	Mossâmedes
52	14002	Mozarlândia
52	14051	Mundo Novo
52	14101	Mutunópolis
52	14408	Nazário
52	14507	Nerópolis
52	14606	Niquelândia
52	14705	Nova América
52	14804	Nova Aurora
52	14838	Nova Crixás
52	14861	Nova Glória
52	14879	Nova Iguaçu de Goiás
52	14903	Nova Roma
52	15009	Nova Veneza
52	15207	Novo Brasil
52	15231	Novo Gama
52	15256	Novo Planalto
52	15306	Orizona
52	15405	Ouro Verde de Goiás
52	15504	Ouvidor
52	15603	Padre Bernardo
52	15652	Palestina de Goiás
52	15702	Palmeiras de Goiás
52	15801	Palmelo
52	15900	Palminópolis
52	16007	Panamá
52	16304	Paranaiguara
52	16403	Paraúna
52	16452	Perolândia
52	16809	Petrolina de Goiás
52	16908	Pilar de Goiás
52	17104	Piracanjuba
52	17203	Piranhas
52	17302	Pirenópolis
52	17401	Pires do Rio
52	17609	Planaltina
52	17708	Pontalina
52	18003	Porangatu
52	18052	Porteirão
52	18102	Portelândia
52	18300	Posse
52	18391	Professor Jamil
52	18508	Quirinópolis
52	18607	Rialma
52	18706	Rianápolis
52	18789	Rio Quente
52	18805	Rio Verde
52	18904	Rubiataba
52	19001	Sanclerlândia
52	19100	Santa Bárbara de Goiás
52	19209	Santa Cruz de Goiás
52	19258	Santa Fé de Goiás
52	19308	Santa Helena de Goiás
52	19357	Santa Isabel
52	19407	Santa Rita do Araguaia
52	19456	Santa Rita do Novo Destino
52	19506	Santa Rosa de Goiás
52	19605	Santa Tereza de Goiás
52	19704	Santa Terezinha de Goiás
52	19712	Santo Antônio da Barra
52	19738	Santo Antônio de Goiás
52	19753	Santo Antônio do Descoberto
52	19803	São Domingos
52	19902	São Francisco de Goiás
52	20058	São João da Paraúna
52	20009	São João d'Aliança
52	20108	São Luís de Montes Belos
52	20157	São Luiz do Norte
52	20207	São Miguel do Araguaia
52	20264	São Miguel do Passa Quatro
52	20280	São Patrício
52	20405	São Simão
52	20454	Senador Canedo
52	20504	Serranópolis
52	20603	Silvânia
52	20686	Simolândia
52	20702	Sítio d'Abadia
52	21007	Taquaral de Goiás
52	21080	Teresina de Goiás
52	21197	Terezópolis de Goiás
52	21304	Três Ranchos
52	21403	Trindade
52	21452	Trombas
52	21502	Turvânia
52	21551	Turvelândia
52	21577	Uirapuru
52	21601	Uruaçu
52	21700	Uruana
52	21809	Urutaí
52	21858	Valparaíso de Goiás
52	21908	Varjão
52	22005	Vianópolis
52	22054	Vicentinópolis
52	22203	Vila Boa
52	22302	Vila Propício
53	00108	Brasília
";

}

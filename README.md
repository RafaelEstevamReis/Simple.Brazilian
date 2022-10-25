[![.NET](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml/badge.svg)](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml)
[![NuGet](https://buildstats.info/nuget/Simple.Brazilian)](https://www.nuget.org/packages/Simple.Brazilian/)


# Brazilian text Tools

This library is (will be) a tool for developers of brazilian-portuguese software

To be as inclusive as possible this readme will be in Portuguese

# Repositório de Ferramentas Textuais

- [Brazilian text Tools](#brazilian-text-tools)
- [Repositório de Ferramentas Textuais](#repositório-de-ferramentas-textuais)
  - [O que somos ?](#o-que-somos-)
  - [Quais são os pilares desta biblioteca ?](#quais-são-os-pilares-desta-biblioteca-)
  - [O que já temos ou ainda queremos ter ?](#o-que-já-temos-ou-ainda-queremos-ter-)


Esta biblioteca será uma ferramenta para todos que escrevem software em português e precisam lidar com textos, datas, e valores monetários em diferentes ambientes.

Para manter o projeto acessível, este readme e toda a documentação será em português

## O que somos ?

Toda software-house sempre escreve seus próprios métodos para remover acentos, escrever números por extenso, etc.

Existem repositórios em várias linguagens porém é raro que:

* Sejam em C#
* Sejam enxutos
* Sejam altamente compatíveis
* Poucas ou nenhuma dependência externa
* [Licença](/LICENSE) permissiva para uso comercial irrestrito

## Quais são os pilares desta biblioteca ?

* Conformidade com a ABNT
* Segurança e previsibilidade
  * 100% coberto por testes unitários
  * Verificação a cada commit/merge \
   [![.NET](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml/badge.svg)](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml)
* Inclusivo, código escrito e documentado em português
* Altíssima compatibilidade permitindo o uso em qualquer versão de .Net
  * Net6
  * Net5
  * Net Core 3.1
  * Net Framework 4.5
  * Net Framework 4.0
  * Net Framework 2.0
  * Net Standard 1.0+
    * Mono 4.6+
    * Xamarin.iOS 10.0+
    * Xamarin.Android 7.0+
    * UWP 8.0+
    * Unity 2018.1+

## O que já temos ou ainda queremos ter ?

Validadores:

- [X] Validação de Documentos: `CEP`, `CNPJ`, `CPF`, `IE` e `PIS`
- [ ] Validação de Documentos: `RG`
- [X] Valida Dia Útil com possibilidade de verificar feriados nacionais
- [X] Calculador de dias úteis (ex.: Quando será daqui X dias úteis)

Formatadores:

- [X] Máscaras para documentos: `CNPJ`, `CPF`, `PIS` e `IE`
- [ ] Máscaras para documentos: `RG`
- [X] Máscaras em geral: `CEP` e `Telefone`
- [X] Remoção de `máscaras`
- [X] Remoção de `acentos` (torna o texto compatível com ASCII7)
- [X] Remoção de `caracteres especiais` (configurável)
- [X] Remoção de espaços `desnecessários`
- [X] Conversão de textos em números
- [X] Conversão de números em texto com arredondamento `ABNT`
- [X] Conversão de valor em reais para texto com sinal `monetário` e arredondamento `ABNT`
- [x] Funções para escrita de `valores por extenso`
- [ ] Conversão de  palavras em `singular` para `plural`
- [x] Filtragem de textos para remoção de caracteres por categorias

Dados:

- [x] Montagem de BRCode para PIX Estático
- [X] Feriados Nacionais (pelas leis 10.607/2002 e 6.802/1980)
- [X] Dias úteis (pelas leis 10.607/2002 e 6.802/1980)
- [X] Nomes de `meses` e `dias da semana` com e sem acentos, em maiúsculo e minúsculo
- [X] Enum de `UFs` relacionado com o `Código IBGE`
- [X] Arrays com as `UFs`, os `nomes dos estados`, seus códigos no `IBGE` e suas `capitais`
- [X] Lista de `Cidades` com os `Códigos IBGE`


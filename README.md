[![.NET](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml/badge.svg)](https://github.com/RafaelEstevamReis/Simple.Brazilian/actions/workflows/dotnet.yml)
[![NuGet](https://buildstats.info/nuget/Simple.Brazilian)](https://www.nuget.org/packages/Simple.Brazilian)

# Brazilian text Tools

This library is (will be) a tool for developers of brazilian-portuguese software

To be as inclusive as possible this readme will be in Portuguese

# Repositório de Ferramentas Textuais

- [Brazilian text Tools](#brazilian-text-tools)
- [Repositório de Ferramentas Textuais](#repositório-de-ferramentas-textuais)
  - [O que somos ?](#o-que-somos-)
  - [Quais são os pilares desta biblioteca ?](#quais-são-os-pilares-desta-biblioteca-)
  - [O que queremos ter ?](#o-que-queremos-ter-)
  - [O que ja temos ?](#o-que-ja-temos-)


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
  * Verificação a cada commit/merge
* Inclusivo, código escrito e documentado em português
* Altíssima compatibilidade permitindo o uso em qualquer versão de .Net
  * Net5
  * Net Core 3.1
  * Net Framework 4.5
  * Net Standard 1.0
    * Mono 4.6+
    * Xamarin.iOS 10.0+
    * Xamarin.Android 7.0+
    * UWP 8.0+
    * Unity 2018.1+

## O que queremos ter ?

* Funções para remoção de acentos a fim de tornar textos em português compatíveis com ASCII
* Funções para escrita de valores por extenso 
* Conversão bidirecional entre números e texto com sinal monetário
* Remoção de caracteres especiais (configurável)

## O que ja temos ?

* Uma implementação relativamente eficiente de remoção de acentos com personalização para caracteres especiais
* Nomes de meses, já com e sem acentos, escritos em diferentes capitalizações (não precisa converter)



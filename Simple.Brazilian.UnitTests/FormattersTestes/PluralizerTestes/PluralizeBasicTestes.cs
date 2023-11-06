namespace Simple.Brazilian.UnitTests.FormattersTestes.PluralizerTestes;

using Simple.Brazilian.Formatters;
using System;
using System.Runtime.Versioning;
using Xunit;

[RequiresPreviewFeatures]
public class PluralizerTests
{
    [Theory]
    [InlineData("lápis", "lápis")]
    [InlineData("atlas", "atlas")]
    [InlineData("jeans", "jeans")]
    [InlineData("nós", "nós")]
    public void Pluralize_InvarianteRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("carro", "carros")]
    [InlineData("professor", "professores")]
    [InlineData("motor", "motores")]
    [InlineData("país", "países")]
    public void Pluralize_VogalRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("alemão", "alemães")]
    [InlineData("irmão", "irmãos")]
    [InlineData("pão", "pães")]
    [InlineData("ação", "ações")]
    public void Pluralize_TildeAORule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("sol", "sóis")]
    [InlineData("farol", "faróis")]
    [InlineData("anzol", "anzóis")]
    [InlineData("animal", "animais")]
    [InlineData("painel", "painéis")]
    [InlineData("azul", "azuis")]
    [InlineData("jornal", "jornais")]
    public void Pluralize_VogalLRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("cachorro", "cachorros")]
    [InlineData("cidade", "cidades")]
    [InlineData("rato", "ratos")]
    [InlineData("jogo", "jogos")]
    public void Pluralize_ConsoanteRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("motor", "motores")]
    [InlineData("país", "países")]
    public void Pluralize_SpecialCasesRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("sorriso", "sorrisos")]
    public void Pluralize_ExceptionsRule(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Fact]
    public void Pluralize_NullInput_ReturnsNull()
    {
        Assert.Throws<ArgumentNullException>(() => Pluralizer.Pluralize(null));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    public void Pluralize_EmptyOrWhitespaceInput_ReturnsEmpty(string input)
    {
        string plural = Pluralizer.Pluralize(input);
        Assert.Empty(plural);
    }
}


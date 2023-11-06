namespace Simple.Brazilian.UnitTests.FormattersTestes.PluralizerTestes;

using Simple.Brazilian.Formatters;
using System;
using System.Runtime.Versioning;
using Xunit;

[RequiresPreviewFeatures]
public class DivisaoSilabicaTestes
{
    [Theory]
    [InlineData("banana", "ba-na-na")]
    [InlineData("programação", "pro-gra-ma-ção")]
    [InlineData("elefante", "e-le-fan-te")]
    [InlineData("teste", "tes-te")]
    [InlineData("computador", "com-pu-ta-dor")]
    [InlineData("trabalho", "tra-ba-lho")]
    [InlineData("quarentena", "qua-ren-te-na")]
    [InlineData("fundamental", "fun-da-men-tal")]
    [InlineData("inconstitucionalissimamente", "in-cons-ti-tu-ci-o-na-lis-si-ma-men-te")]
    public void TestSyllableDivision(string inputWord, string expectedSyllables)
    {
        var result = Pluralizer.DividirPalavraSilabas(inputWord, "-");
        Assert.Equal(expectedSyllables, result);
    }

    [Theory]
    [InlineData("vigésimo", "vi-gé-si-mo")]
    [InlineData("esfumar", "es-fu-mar")]
    [InlineData("acessível", "a-ces-sí-vel")]
    [InlineData("oligoqueta", "o-li-go-que-ta")]
    [InlineData("orgulhar", "or-gu-lhar")]
    [InlineData("terceiros", "ter-cei-ros")]
    [InlineData("conceder", "con-ce-der")]
    [InlineData("solidificação", "so-li-di-fi-ca-ção")]
    [InlineData("ginja", "gin-ja")]
    [InlineData("chuteira", "chu-tei-ra")]
    [InlineData("pituíta", "pi-tu-í-ta")]
    [InlineData("desencorpar", "de-sen-cor-par")]
    public void ExemploSite(string inputWord, string expectedSyllables)
    {
        var result = Pluralizer.DividirPalavraSilabas(inputWord, "-");
        Assert.Equal(expectedSyllables, result);
    }


    [Fact]
    public void TestSyllableDivision_EmptyInput()
    {
        var result = Pluralizer.DividirPalavraSilabas("", "-");
        Assert.Equal("", result); // A saída deve ser uma string vazia para entrada vazia
    }

    [Fact]
    public void TestSyllableDivision_NullInput()
    {
        Assert.Throws<ArgumentNullException>(() => Pluralizer.DivisaoSilabica(null));
    }
}
using Simple.Brazilian.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.NamesTests;

public class AbbreviateNameTests
{
    [Fact]
    public void AbbreviateName_NullOrEmpty_ReturnsEmpty()
    {
        Assert.Equal("", Names.AbbreviateName(null));
        Assert.Equal("", Names.AbbreviateName(""));
        Assert.Equal("", Names.AbbreviateName("   "));
    }

    [Fact]
    public void AbbreviateName_SingleName_ReturnsSameName()
    {
        Assert.Equal("João", Names.AbbreviateName("João"));
        Assert.Equal("Maria", Names.AbbreviateName("Maria"));
    }
    [Theory]
    [InlineData("João Silva Santos", "João S. Santos")]
    [InlineData("Maria Eduarda de Oliveira Costa", "Maria E. O. Costa")]
    [InlineData("Ana Beatriz Silva", "Ana B. Silva")]
    [InlineData("Pedro Henrique dos Santos Almeida", "Pedro H. S. Almeida")]
    public void AbbreviateName_DefaultOptions_ReturnsExpected(string input, string expected)
    {
        var result = Names.AbbreviateName(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AbbreviateName_RemovePrepositions_True_RemovesCorrectly()
    {
        var options = new NameAbbreviationOptions { RemovePrepositions = true };

        Assert.Equal("João S. Santos", Names.AbbreviateName("João da Silva dos Santos", options));
        Assert.Equal("Maria E. O. Costa", Names.AbbreviateName("Maria Eduarda de Oliveira da Costa", options));
    }

    [Fact]
    public void AbbreviateName_RemovePrepositions_False_KeepsPrepositions()
    {
        var options = new NameAbbreviationOptions
        {
            RemovePrepositions = false
        };

        Assert.Equal("João D. S. D. Santos", Names.AbbreviateName("João da Silva dos Santos", options));
    }

    [Fact]
    public void AbbreviateName_AbbreviateLastName_True()
    {
        var options = new NameAbbreviationOptions
        {
            AbbreviateLastName = true,
            RemovePrepositions = true
        };

        Assert.Equal("João S. S.", Names.AbbreviateName("João da Silva Santos", options));
        Assert.Equal("Maria E. O. C.", Names.AbbreviateName("Maria Eduarda de Oliveira Costa", options));
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void AbbreviateName_MaxMiddleInitials_LimitsCorrectly(int maxInitials)
    {
        var options = new NameAbbreviationOptions
        {
            MaxMiddleInitials = maxInitials,
            RemovePrepositions = true
        };

        var result = Names.AbbreviateName("João Pedro Henrique Lucas Silva Santos", options);

        var middleCount = result.Split(' ').Length - 2; // -2 porque tira primeiro e último
        Assert.True(middleCount <= maxInitials);
    }

    [Fact]
    public void AbbreviateName_CustomPrepositions_Works()
    {
        var options = new NameAbbreviationOptions
        {
            RemovePrepositions = true,
            Prepositions = [
                "da", "de", "do", "van", "von"
            ]
        };

        Assert.Equal("João D. S. Santos", Names.AbbreviateName("João van der Silva Santos", options));
    }

    [Fact]
    public void AbbreviateName_AllOptions_Combined()
    {
        var options = new NameAbbreviationOptions
        {
            MaxMiddleInitials = 2,
            AbbreviateLastName = true,
            RemovePrepositions = true
        };

        Assert.Equal("Maria E. O. S.", Names.AbbreviateName("Maria Eduarda de Oliveira da Costa Silva", options));
    }
}

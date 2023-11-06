namespace Simple.Brazilian.UnitTests.FormattersTestes.PluralizerTestes;

using Simple.Brazilian.Formatters;
using System.Runtime.Versioning;
using Xunit;

[RequiresPreviewFeatures]
public class PluralizePDVTestes
{
    [Theory]
    [InlineData("produto", "produtos")]
    [InlineData("item", "itens")]
    [InlineData("pedido", "pedidos")]
    [InlineData("cliente", "clientes")]
    [InlineData("desconto", "descontos")]
    [InlineData("caixa", "caixas")]
    [InlineData("carrinho", "carrinhos")]
    [InlineData("dinheiro", "dinheiros")]
    [InlineData("cupom", "cupons")]
    [InlineData("imposto", "impostos")]
    [InlineData("real", "reais")]
    [InlineData("centavo", "centavos")]
    [InlineData("compra", "compras")]
    public void Pluralize_PDVRelatedInput(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

    [Theory]
    [InlineData("PRODUTO", "PRODUTOS")]
    [InlineData("Item", "Itens")]
    [InlineData("PEDIDO", "PEDIDOS")]
    [InlineData("Cliente", "Clientes")]
    [InlineData("Desconto", "Descontos")]
    [InlineData("CAIXA", "CAIXAS")]
    public void Pluralize_PDVRelatedInput_Casing(string singular, string expectedPlural)
    {
        string plural = Pluralizer.Pluralize(singular);
        Assert.Equal(expectedPlural, plural);
    }

}

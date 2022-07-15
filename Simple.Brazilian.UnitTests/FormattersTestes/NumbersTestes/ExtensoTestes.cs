using Simple.Brazilian.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Simple.Brazilian.UnitTests.FormattersTestes.NumbersTestes
{
    public class ExtensoTestes
    {
        [Fact]
        public void Numero_Extenso_ULongMax()
        {
            // 18.446.744.073.709.551.615
            Assert.Equal("Dezoito Quintilhões Quatrocentos e Quarenta e Seis Quatrilhões Setecentos e Quarenta e Quatro Trilhões Setenta e Três Bilhões Setecentos e Nove Milhões Quinhentos e Cinquenta e Um Mil Seiscentos e Quinze", 
                         Numbers.NumeroExtenso(ulong.MaxValue));
        }
        [Fact]
        public void Numero_Extenso_UIntMax()
        {
            // 4.294.967.295
            Assert.Equal("Quatro Bilhões Duzentos e Noventa e Quatro Milhões Novecentos e Sessenta e Sete Mil Duzentos e Noventa e Cinco",
                         Numbers.NumeroExtenso(uint.MaxValue));
        }

        [Theory]
        [InlineData(0, "Zero")]
        [InlineData(1_000, "Mil")]
        // https://duvidas.dicio.com.br/como-escrever-numeros-por-extenso/
        // [1] Deverá ser usada a conjunção e entre as centenas, dezenas e unidades
        [InlineData(37, "Trinta e Sete")]
        [InlineData(237, "Duzentos e Trinta e Sete")]
        [InlineData(207, "Duzentos e Sete")]
        // [2] Na separação dos milhares e das centenas, a conjunção e apenas deverá ser usada quando o número termina nas centenas
        [InlineData(5_500, "Cinco Mil e Quinhentos")]
        [InlineData(1_300, "Mil e Trezentos")]
        [InlineData(8_100, "Oito Mil e Cem")]
        // [3] Quando o número começa nos milhares e termina nas dezenas ou nas unidades, não deverá ser usada a conjunção e na separação das centenas,
        // apenas na separação das restantes ordens
        [InlineData(2_125, "Dois Mil Cento e Vinte e Cinco")]
        [InlineData(7_491, "Sete Mil Quatrocentos e Noventa e Um")]
        [InlineData(6_510, "Seis Mil Quinhentos e Dez")]
        [InlineData(9_030, "Nove Mil e Trinta")]
        [InlineData(9_003, "Nove Mil e Três")]
        // [4] Quando o número é muito grande, a leitura é feita por classes.
        // A conjunção e é usada para separar os algarismos da classe mas não deverá ser usada para separar as classes
        [InlineData(378_027_312L, "Trezentos e Setenta e Oito Milhões Vinte e Sete Mil Trezentos e Doze")]
        [InlineData(209_670_123_418L, "Duzentos e Nove Bilhões Seiscentos e Setenta Milhões Cento e Vinte e Três Mil Quatrocentos e Dezoito")]
        // Outros casos
        [InlineData(1_000_090_000_003, "Um Trilhão Noventa Milhões e Três")]
        [InlineData(2_000_090_000_030, "Dois Trilhões Noventa Milhões e Trinta")]
        [InlineData(1_000_090_000_500, "Um Trilhão Noventa Milhões e Quinhentos")]
        public void Numero_Extenso(ulong numero, string correto)
        {
            var calculado = Numbers.NumeroExtenso(numero);
            Assert.Equal(correto, calculado);
        }


        [Fact]
        public void Numero_ValorExtenso_UIntMax()
        {
            // 4.294.967.295
            Assert.Equal("Quatro Bilhões Duzentos e Noventa e Quatro Milhões Novecentos e Sessenta e Sete Mil Duzentos e Noventa e Cinco Reais",
                         Numbers.MoedaExtenso(uint.MaxValue));
        }

        [Theory]
        [InlineData(1, "Um Real")]
        [InlineData(1.01, "Um Real e Um Centavo")]
        [InlineData(1_000_090_000_003, "Um Trilhão Noventa Milhões e Três Reais")]
        [InlineData(2_000_090_000_030, "Dois Trilhões Noventa Milhões e Trinta Reais")]
        [InlineData(1_000_090_000_500, "Um Trilhão Noventa Milhões e Quinhentos Reais")]
        [InlineData(1_000_090_000_003.01, "Um Trilhão Noventa Milhões e Três Reais e Um Centavo")]
        [InlineData(2_000_090_000_030.02, "Dois Trilhões Noventa Milhões e Trinta Reais e Dois Centavos")]
        [InlineData(2_000_090_000_000.02, "Dois Trilhões Noventa Milhões de Reais e Dois Centavos")]
        // https://www.todamateria.com.br/numeros-por-extenso/
        [InlineData(0.01, "Um Centavo de Real")]
        [InlineData(0.02, "Dois Centavos de Real")]
        [InlineData(1.03, "Um Real e Três Centavos")]
        [InlineData(2.00, "Dois Reais")]
        [InlineData(10.0, "Dez Reais")]
        [InlineData(100, "Cem Reais")]
        [InlineData(1_000, "Mil Reais")]
        [InlineData(1_000_000, "Um Milhão de Reais")]
        [InlineData(2_000_000_000, "Dois Bilhões de Reais")]
        public void Numero_MoedaExtenso(decimal numero, string correto)
        {
            var calculado = Numbers.MoedaExtenso(numero);
            Assert.Equal(correto, calculado);
        }


    }
}

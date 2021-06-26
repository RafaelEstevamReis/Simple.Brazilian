using Simple.Brazilian.Documents;
using System;
using System.Linq;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.CEPTestes
{
    public class IsValidTestes
    {
        /// <summary>
        /// Verifica o comprimento do CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <param name="resultado"></param>
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("00.000", false)]
        [InlineData("00.000-000", true)]
        [InlineData("00000000", true)]
        public void CEP_IsValid(string cep, bool resultado)
        {
            Assert.Equal(resultado, CEP.IsValid(cep));
        }
        /// <summary>
        /// Varre todos os inícios de CEP para procurar brechas nos UFs
        /// </summary>
        [Fact]
        public void CEP_IsValidVarreduraInicio()
        {
            for (char i = '0'; i <= '9'; i++)
            {
                var cep = $"{i}0.000-000";
                foreach (var uf in Enum.GetValues<Dados.Places.UF>())
                {
                    // Nãodeve lançar exceções
                    CEP.IsValid(cep, uf);
                }
            }
        }

        /// <summary>
        /// Varre todas as UFs para procurar brechas nos CEPs
        /// </summary>
        [Theory]
        [InlineData(Dados.Places.UF.SP, '0')]
        [InlineData(Dados.Places.UF.SP, '1')]
        [InlineData(Dados.Places.UF.RJ, '2')]
        [InlineData(Dados.Places.UF.ES, '2')]
        [InlineData(Dados.Places.UF.MG, '3')]
        [InlineData(Dados.Places.UF.BA, '4')]
        [InlineData(Dados.Places.UF.SE, '4')]
        [InlineData(Dados.Places.UF.PE, '5')]
        [InlineData(Dados.Places.UF.AL, '5')]
        [InlineData(Dados.Places.UF.PB, '5')]
        [InlineData(Dados.Places.UF.RN, '5')]
        [InlineData(Dados.Places.UF.CE, '6')]
        [InlineData(Dados.Places.UF.PI, '6')]
        [InlineData(Dados.Places.UF.MA, '6')]
        [InlineData(Dados.Places.UF.PA, '6')]
        [InlineData(Dados.Places.UF.AP, '6')]
        [InlineData(Dados.Places.UF.AM, '6')]
        [InlineData(Dados.Places.UF.RR, '6')]
        [InlineData(Dados.Places.UF.AC, '6')]
        [InlineData(Dados.Places.UF.DF, '7')]
        [InlineData(Dados.Places.UF.GO, '7')]
        [InlineData(Dados.Places.UF.TO, '7')]
        [InlineData(Dados.Places.UF.MT, '7')]
        [InlineData(Dados.Places.UF.RO, '7')]
        [InlineData(Dados.Places.UF.MS, '7')]
        [InlineData(Dados.Places.UF.PR, '8')]
        [InlineData(Dados.Places.UF.SC, '8')]
        [InlineData(Dados.Places.UF.RS, '9')]
        public void CEP_IsValidVarreduraUF(Dados.Places.UF uf, char inicioCorreto)
        {
            var cep = $"{inicioCorreto}0.000-000";
            Assert.True(CEP.IsValid(cep, uf));
        }

        /// <summary>
        /// Varre todas as UFs para procurar brechas nos CEPs
        /// </summary>
        [Theory]
        [InlineData('0', Dados.Places.UF.SP)]
        [InlineData('1', Dados.Places.UF.SP)]
        [InlineData('2', Dados.Places.UF.RJ, Dados.Places.UF.ES)]
        [InlineData('3', Dados.Places.UF.MG)]
        [InlineData('4', Dados.Places.UF.BA, Dados.Places.UF.SE)]
        [InlineData('5', Dados.Places.UF.PE, Dados.Places.UF.AL, Dados.Places.UF.PB, Dados.Places.UF.RN)]
        [InlineData('6', Dados.Places.UF.CE, Dados.Places.UF.PI, Dados.Places.UF.MA, Dados.Places.UF.PA,
                         Dados.Places.UF.AP, Dados.Places.UF.AM, Dados.Places.UF.RR, Dados.Places.UF.AC)]
        [InlineData('7', Dados.Places.UF.DF, Dados.Places.UF.GO, Dados.Places.UF.TO, Dados.Places.UF.MT, 
                         Dados.Places.UF.RO, Dados.Places.UF.MS)]
        [InlineData('8', Dados.Places.UF.PR, Dados.Places.UF.SC)]
        [InlineData('9', Dados.Places.UF.RS)]
        public void CEP_IsValidVarreduraUFPares(char inicioCorreto, params Dados.Places.UF[] ufs)
        {
            var cep = $"{inicioCorreto}0.000-000";
            
            foreach (var uf in Enum.GetValues<Dados.Places.UF>())
            {
                // Nãodeve lançar exceções
                bool contains = ufs.Contains(uf);
                Assert.Equal(contains, CEP.IsValid(cep, uf));
            }

        }
    }
}

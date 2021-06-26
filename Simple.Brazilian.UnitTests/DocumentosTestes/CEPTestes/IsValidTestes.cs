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
                foreach (var uf in Enum.GetValues<Information.Places.UF>())
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
        [InlineData(Information.Places.UF.SP, '0')]
        [InlineData(Information.Places.UF.SP, '1')]
        [InlineData(Information.Places.UF.RJ, '2')]
        [InlineData(Information.Places.UF.ES, '2')]
        [InlineData(Information.Places.UF.MG, '3')]
        [InlineData(Information.Places.UF.BA, '4')]
        [InlineData(Information.Places.UF.SE, '4')]
        [InlineData(Information.Places.UF.PE, '5')]
        [InlineData(Information.Places.UF.AL, '5')]
        [InlineData(Information.Places.UF.PB, '5')]
        [InlineData(Information.Places.UF.RN, '5')]
        [InlineData(Information.Places.UF.CE, '6')]
        [InlineData(Information.Places.UF.PI, '6')]
        [InlineData(Information.Places.UF.MA, '6')]
        [InlineData(Information.Places.UF.PA, '6')]
        [InlineData(Information.Places.UF.AP, '6')]
        [InlineData(Information.Places.UF.AM, '6')]
        [InlineData(Information.Places.UF.RR, '6')]
        [InlineData(Information.Places.UF.AC, '6')]
        [InlineData(Information.Places.UF.DF, '7')]
        [InlineData(Information.Places.UF.GO, '7')]
        [InlineData(Information.Places.UF.TO, '7')]
        [InlineData(Information.Places.UF.MT, '7')]
        [InlineData(Information.Places.UF.RO, '7')]
        [InlineData(Information.Places.UF.MS, '7')]
        [InlineData(Information.Places.UF.PR, '8')]
        [InlineData(Information.Places.UF.SC, '8')]
        [InlineData(Information.Places.UF.RS, '9')]
        public void CEP_IsValidVarreduraUF(Information.Places.UF uf, char inicioCorreto)
        {
            var cep = $"{inicioCorreto}0.000-000";
            Assert.True(CEP.IsValid(cep, uf));
        }

        /// <summary>
        /// Varre todas as UFs para procurar brechas nos CEPs
        /// </summary>
        [Theory]
        [InlineData('0', Information.Places.UF.SP)]
        [InlineData('1', Information.Places.UF.SP)]
        [InlineData('2', Information.Places.UF.RJ, Information.Places.UF.ES)]
        [InlineData('3', Information.Places.UF.MG)]
        [InlineData('4', Information.Places.UF.BA, Information.Places.UF.SE)]
        [InlineData('5', Information.Places.UF.PE, Information.Places.UF.AL, Information.Places.UF.PB, Information.Places.UF.RN)]
        [InlineData('6', Information.Places.UF.CE, Information.Places.UF.PI, Information.Places.UF.MA, Information.Places.UF.PA,
                         Information.Places.UF.AP, Information.Places.UF.AM, Information.Places.UF.RR, Information.Places.UF.AC)]
        [InlineData('7', Information.Places.UF.DF, Information.Places.UF.GO, Information.Places.UF.TO, Information.Places.UF.MT, 
                         Information.Places.UF.RO, Information.Places.UF.MS)]
        [InlineData('8', Information.Places.UF.PR, Information.Places.UF.SC)]
        [InlineData('9', Information.Places.UF.RS)]
        public void CEP_IsValidVarreduraUFPares(char inicioCorreto, params Information.Places.UF[] ufs)
        {
            var cep = $"{inicioCorreto}0.000-000";
            
            foreach (var uf in Enum.GetValues<Information.Places.UF>())
            {
                // Nãodeve lançar exceções
                bool contains = ufs.Contains(uf);
                Assert.Equal(contains, CEP.IsValid(cep, uf));
            }

        }
    }
}

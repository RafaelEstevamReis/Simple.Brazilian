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
                foreach (var uf in Enum.GetValues<Information.Places.UFs>())
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
        [InlineData(Information.Places.UFs.SP, '0')]
        [InlineData(Information.Places.UFs.SP, '1')]
        [InlineData(Information.Places.UFs.RJ, '2')]
        [InlineData(Information.Places.UFs.ES, '2')]
        [InlineData(Information.Places.UFs.MG, '3')]
        [InlineData(Information.Places.UFs.BA, '4')]
        [InlineData(Information.Places.UFs.SE, '4')]
        [InlineData(Information.Places.UFs.PE, '5')]
        [InlineData(Information.Places.UFs.AL, '5')]
        [InlineData(Information.Places.UFs.PB, '5')]
        [InlineData(Information.Places.UFs.RN, '5')]
        [InlineData(Information.Places.UFs.CE, '6')]
        [InlineData(Information.Places.UFs.PI, '6')]
        [InlineData(Information.Places.UFs.MA, '6')]
        [InlineData(Information.Places.UFs.PA, '6')]
        [InlineData(Information.Places.UFs.AP, '6')]
        [InlineData(Information.Places.UFs.AM, '6')]
        [InlineData(Information.Places.UFs.RR, '6')]
        [InlineData(Information.Places.UFs.AC, '6')]
        [InlineData(Information.Places.UFs.DF, '7')]
        [InlineData(Information.Places.UFs.GO, '7')]
        [InlineData(Information.Places.UFs.TO, '7')]
        [InlineData(Information.Places.UFs.MT, '7')]
        [InlineData(Information.Places.UFs.RO, '7')]
        [InlineData(Information.Places.UFs.MS, '7')]
        [InlineData(Information.Places.UFs.PR, '8')]
        [InlineData(Information.Places.UFs.SC, '8')]
        [InlineData(Information.Places.UFs.RS, '9')]
        public void CEP_IsValidVarreduraUF(Information.Places.UFs uf, char inicioCorreto)
        {
            var cep = $"{inicioCorreto}0.000-000";
            Assert.True(CEP.IsValid(cep, uf));
        }

        /// <summary>
        /// Varre todas as UFs para procurar brechas nos CEPs
        /// </summary>
        [Theory]
        [InlineData('0', Information.Places.UFs.SP)]
        [InlineData('1', Information.Places.UFs.SP)]
        [InlineData('2', Information.Places.UFs.RJ, Information.Places.UFs.ES)]
        [InlineData('3', Information.Places.UFs.MG)]
        [InlineData('4', Information.Places.UFs.BA, Information.Places.UFs.SE)]
        [InlineData('5', Information.Places.UFs.PE, Information.Places.UFs.AL, Information.Places.UFs.PB, Information.Places.UFs.RN)]
        [InlineData('6', Information.Places.UFs.CE, Information.Places.UFs.PI, Information.Places.UFs.MA, Information.Places.UFs.PA,
                         Information.Places.UFs.AP, Information.Places.UFs.AM, Information.Places.UFs.RR, Information.Places.UFs.AC)]
        [InlineData('7', Information.Places.UFs.DF, Information.Places.UFs.GO, Information.Places.UFs.TO, Information.Places.UFs.MT, 
                         Information.Places.UFs.RO, Information.Places.UFs.MS)]
        [InlineData('8', Information.Places.UFs.PR, Information.Places.UFs.SC)]
        [InlineData('9', Information.Places.UFs.RS)]
        public void CEP_IsValidVarreduraUFPares(char inicioCorreto, params Information.Places.UFs[] ufs)
        {
            var cep = $"{inicioCorreto}0.000-000";
            
            foreach (var uf in Enum.GetValues<Information.Places.UFs>())
            {
                // Nãodeve lançar exceções
                bool contains = ufs.Contains(uf);
                Assert.Equal(contains, CEP.IsValid(cep, uf));
            }

        }
    }
}

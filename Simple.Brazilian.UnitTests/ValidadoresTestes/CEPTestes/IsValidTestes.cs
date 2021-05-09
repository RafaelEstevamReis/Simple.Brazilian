using Simple.Brazilian.Validadores;
using System;
using System.Linq;
using System.Reflection.Emit;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidadoresTestes.CEPTestes
{
    public class IsValidTestes
    {
        /// <summary>
        /// Verifica o comprimento do CEP
        /// </summary>
        /// <param name="cep"></param>
        /// <param name="resultado"></param>
        [Theory]
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
                foreach (var uf in Enum.GetValues<Dados.Locais.UF>())
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
        [InlineData(Dados.Locais.UF.SP, '0')]
        [InlineData(Dados.Locais.UF.SP, '1')]
        [InlineData(Dados.Locais.UF.RJ, '2')]
        [InlineData(Dados.Locais.UF.ES, '2')]
        [InlineData(Dados.Locais.UF.MG, '3')]
        [InlineData(Dados.Locais.UF.BA, '4')]
        [InlineData(Dados.Locais.UF.SE, '4')]
        [InlineData(Dados.Locais.UF.PE, '5')]
        [InlineData(Dados.Locais.UF.AL, '5')]
        [InlineData(Dados.Locais.UF.PB, '5')]
        [InlineData(Dados.Locais.UF.RN, '5')]
        [InlineData(Dados.Locais.UF.CE, '6')]
        [InlineData(Dados.Locais.UF.PI, '6')]
        [InlineData(Dados.Locais.UF.MA, '6')]
        [InlineData(Dados.Locais.UF.PA, '6')]
        [InlineData(Dados.Locais.UF.AP, '6')]
        [InlineData(Dados.Locais.UF.AM, '6')]
        [InlineData(Dados.Locais.UF.RR, '6')]
        [InlineData(Dados.Locais.UF.AC, '6')]
        [InlineData(Dados.Locais.UF.DF, '7')]
        [InlineData(Dados.Locais.UF.GO, '7')]
        [InlineData(Dados.Locais.UF.TO, '7')]
        [InlineData(Dados.Locais.UF.MT, '7')]
        [InlineData(Dados.Locais.UF.RO, '7')]
        [InlineData(Dados.Locais.UF.MS, '7')]
        [InlineData(Dados.Locais.UF.PR, '8')]
        [InlineData(Dados.Locais.UF.SC, '8')]
        [InlineData(Dados.Locais.UF.RS, '9')]
        public void CEP_IsValidVarreduraUF(Dados.Locais.UF uf, char inicioCorreto)
        {
            var cep = $"{inicioCorreto}0.000-000";
            Assert.True(CEP.IsValid(cep, uf));
        }


        /// <summary>
        /// Varre todas as UFs para procurar brechas nos CEPs
        /// </summary>
        [Theory]
        [InlineData('0', Dados.Locais.UF.SP)]
        [InlineData('1', Dados.Locais.UF.SP)]
        [InlineData('2', Dados.Locais.UF.RJ, Dados.Locais.UF.ES)]
        [InlineData('3', Dados.Locais.UF.MG)]
        [InlineData('4', Dados.Locais.UF.BA, Dados.Locais.UF.SE)]
        [InlineData('5', Dados.Locais.UF.PE, Dados.Locais.UF.AL, Dados.Locais.UF.PB, Dados.Locais.UF.RN)]
        [InlineData('6', Dados.Locais.UF.CE, Dados.Locais.UF.PI, Dados.Locais.UF.MA, Dados.Locais.UF.PA,
                         Dados.Locais.UF.AP, Dados.Locais.UF.AM, Dados.Locais.UF.RR, Dados.Locais.UF.AC)]
        [InlineData('7', Dados.Locais.UF.DF, Dados.Locais.UF.GO, Dados.Locais.UF.TO, Dados.Locais.UF.MT, 
                         Dados.Locais.UF.RO, Dados.Locais.UF.MS)]
        [InlineData('8', Dados.Locais.UF.PR, Dados.Locais.UF.SC)]
        [InlineData('9', Dados.Locais.UF.RS)]
        public void CEP_IsValidVarreduraUFPares(char inicioCorreto, params Dados.Locais.UF[] ufs)
        {
            var cep = $"{inicioCorreto}0.000-000";
            
            foreach (var uf in Enum.GetValues<Dados.Locais.UF>())
            {
                // Nãodeve lançar exceções
                bool contains = ufs.Contains(uf);
                Assert.Equal(contains, CEP.IsValid(cep, uf));
            }

        }
    }
}

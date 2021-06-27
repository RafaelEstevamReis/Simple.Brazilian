using Simple.Brazilian.Information.Places;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.InformationTestes.PlacesTestes
{
    public class StatesTestes
    {
        [Fact]
        public void VerificaComprimentoArrays()
        {
            Assert.Equal(27, States.UF.Length);
            Assert.Equal(27, States.Names.Length);
            Assert.Equal(27, States.IdIBGE.Length);
            Assert.Equal(27, States.Capital.Length);
            Assert.Equal(27, States.AreaKm2.Length);
        }

        [Fact]
        public void VerificaArraysPeloEnum()
        {
            foreach (UFs uf in Enum.GetValues(typeof(UFs)))
            {
                if (uf == UFs.EX) continue;

                var sigla = uf.ToString();
                var ibge = (int)uf;

                int idx = States.UF.IndexOf(sigla);

                Assert.True(idx >= 0);
                Assert.Equal(States.IdIBGE[idx], ibge);
            }
        }

        [Fact]
        public void VerificaEnumPeloArrays()
        {
            for (int i = 0; i < 27; i++)
            {
                int ibge = States.IdIBGE[i];
                string sigla = States.UF[i];

                Assert.Equal(sigla, ((UFs)ibge).ToString());
            }
        }
    }
}

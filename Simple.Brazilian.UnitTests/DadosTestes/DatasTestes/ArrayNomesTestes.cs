using Simple.Brazilian.Information;
using Xunit;

namespace Simple.Brazilian.UnitTests.DadosTestes.DatasTestes
{
    public class ArrayNomesTestes
    {
        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Semana()
        {
            Assert.Equal(7, Dates.DiasSemanaComAcento.Length);
            Assert.Equal(7, Dates.DiasSemanaSemAcento.Length);
            Assert.Equal(7, Dates.DiasSemanaComAcentoL.Length);
            Assert.Equal(7, Dates.DiasSemanaSemAcentoL.Length);
            Assert.Equal(7, Dates.DiasSemanaComAcentoU.Length);
            Assert.Equal(7, Dates.DiasSemanaSemAcentoU.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Meses()
        {
            Assert.Equal(12, Dates.MesesComAcento.Length);
            Assert.Equal(12, Dates.MesesSemAcento.Length);
            Assert.Equal(12, Dates.MesesComAcentoL.Length);
            Assert.Equal(12, Dates.MesesSemAcentoL.Length);
            Assert.Equal(12, Dates.MesesComAcentoU.Length);
            Assert.Equal(12, Dates.MesesSemAcentoU.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaIgualdade_Semana()
        {
            var baseCompara = Dates.DiasSemanaSemAcentoL;

            var todos = new string[][]{
                Dates.DiasSemanaComAcento,
                Dates.DiasSemanaSemAcento,
                Dates.DiasSemanaComAcentoL,
                //Datas.DiasSemanaSemAcentoL, - Já é a base
                Dates.DiasSemanaComAcentoU,
                Dates.DiasSemanaSemAcentoU,
            };

            foreach (var conjunto in todos)
            {
                for (int i = 0; i < baseCompara.Length; i++)
                {
                    Assert.Equal(baseCompara[i], Formatters.Text.RemoveAcentos(conjunto[i]).ToLower());
                }
            }
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaIgualdade_Meses()
        {
            var baseCompara = Dates.MesesSemAcentoL;

            var todos = new string[][]{
                Dates.MesesComAcento,
                Dates.MesesSemAcento,
                Dates.MesesComAcentoL,
                //Datas.MesesSemAcentoL, - Já é a base
                Dates.MesesComAcentoU,
                Dates.MesesSemAcentoU,
            };

            foreach (var conjunto in todos)
            {
                for (int i = 0; i < baseCompara.Length; i++)
                {
                    Assert.Equal(baseCompara[i], Formatters.Text.RemoveAcentos(conjunto[i]).ToLower());
                }
            }
        }
    }
}

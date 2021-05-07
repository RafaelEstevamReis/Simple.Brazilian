using Simple.Brazilian.Dados;
using Xunit;

namespace Simple.Brazilian.UnitTests.DadosTestes.DatasTestes
{
    public class ArrayNomesTestes
    {
        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Semana()
        {
            Assert.Equal(7, Datas.DiasSemanaComAcento.Length);
            Assert.Equal(7, Datas.DiasSemanaSemAcento.Length);
            Assert.Equal(7, Datas.DiasSemanaComAcentoL.Length);
            Assert.Equal(7, Datas.DiasSemanaSemAcentoL.Length);
            Assert.Equal(7, Datas.DiasSemanaComAcentoU.Length);
            Assert.Equal(7, Datas.DiasSemanaSemAcentoU.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Meses()
        {
            Assert.Equal(12, Datas.MesesComAcento.Length);
            Assert.Equal(12, Datas.MesesSemAcento.Length);
            Assert.Equal(12, Datas.MesesComAcentoL.Length);
            Assert.Equal(12, Datas.MesesSemAcentoL.Length);
            Assert.Equal(12, Datas.MesesComAcentoU.Length);
            Assert.Equal(12, Datas.MesesSemAcentoU.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaIgualdade_Semana()
        {
            var baseCompara = Datas.DiasSemanaSemAcentoL;

            var todos = new string[][]{
                Datas.DiasSemanaComAcento,
                Datas.DiasSemanaSemAcento,
                Datas.DiasSemanaComAcentoL,
                //Datas.DiasSemanaSemAcentoL, - Já é a base
                Datas.DiasSemanaComAcentoU,
                Datas.DiasSemanaSemAcentoU,
            };

            foreach (var conjunto in todos)
            {
                for (int i = 0; i < baseCompara.Length; i++)
                {
                    Assert.Equal(baseCompara[i], Formatadores.Texto.RemoveAcentos(conjunto[i]).ToLower());
                }
            }
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaIgualdade_Meses()
        {
            var baseCompara = Datas.MesesSemAcentoL;

            var todos = new string[][]{
                Datas.MesesComAcento,
                Datas.MesesSemAcento,
                Datas.MesesComAcentoL,
                //Datas.MesesSemAcentoL, - Já é a base
                Datas.MesesComAcentoU,
                Datas.MesesSemAcentoU,
            };

            foreach (var conjunto in todos)
            {
                for (int i = 0; i < baseCompara.Length; i++)
                {
                    Assert.Equal(baseCompara[i], Formatadores.Texto.RemoveAcentos(conjunto[i]).ToLower());
                }
            }
        }
    }
}

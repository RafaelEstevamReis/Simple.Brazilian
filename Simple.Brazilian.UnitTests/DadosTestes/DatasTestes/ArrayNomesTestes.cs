using Simple.Brazilian.Information;
using Xunit;

namespace Simple.Brazilian.UnitTests.DadosTestes.DatasTestes
{
    public class ArrayNomesTestes
    {
        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Semana()
        {
            Assert.Equal(7, Dates.WeekDayWithAccent.Length);
            Assert.Equal(7, Dates.WeekDayWithoutAccent.Length);
            Assert.Equal(7, Dates.WeekDayWithAccentLower.Length);
            Assert.Equal(7, Dates.WeekDayWithoutAccentLower.Length);
            Assert.Equal(7, Dates.WeekDayWithAccentUpper.Length);
            Assert.Equal(7, Dates.WeekDayWithoutAccentUpper.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaComprimento_Meses()
        {
            Assert.Equal(12, Dates.MonthsWithAccent.Length);
            Assert.Equal(12, Dates.MonthsWithoutAccent.Length);
            Assert.Equal(12, Dates.MonthsWithAccentLower.Length);
            Assert.Equal(12, Dates.MonthsWithoutAccentLower.Length);
            Assert.Equal(12, Dates.MonthsWithAccentUpper.Length);
            Assert.Equal(12, Dates.MonthsWithoutAccentUpper.Length);
        }

        [Fact]
        public void Datas_ArraysNomes_CertificaIgualdade_Semana()
        {
            var baseCompara = Dates.WeekDayWithoutAccentLower;

            var todos = new string[][]{
                Dates.WeekDayWithAccent,
                Dates.WeekDayWithoutAccent,
                Dates.WeekDayWithAccentLower,
                //Datas.DiasSemanaSemAcentoL, - Já é a base
                Dates.WeekDayWithAccentUpper,
                Dates.WeekDayWithoutAccentUpper,
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
            var baseCompara = Dates.MonthsWithoutAccentLower;

            var todos = new string[][]{
                Dates.MonthsWithAccent,
                Dates.MonthsWithoutAccent,
                Dates.MonthsWithAccentLower,
                //Datas.MesesSemAcentoL, - Já é a base
                Dates.MonthsWithAccentUpper,
                Dates.MonthsWithoutAccentUpper,
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

using System;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.DatesTestes
{
    public class NextBusinessDay
    {
        [Fact]
        public void NextBusinessDay_DiaNormal()
        {
            // 04/01/2021 é segunda e não é feriado 
            var date = new DateTime(2021, 01, 04);

            // Próximo dia útil é dia 05
            Assert.Equal(5, Dates.NextBusinessDay(date, false, false).Day);
            // Se contar o próprio dia, é dia 4 mesmo
            Assert.Equal(4, Dates.NextBusinessDay(date, false, acceptBaseDate: true).Day);
        }

        [Fact]
        public void NextBusinessDay_FimSemana()
        {
            // 09/01/2021 é sábado e não é feriado 
            var date = new DateTime(2021, 01, 09);

            // Próximo dia útil é dia 11, contando ou não o dia de hoje
            Assert.Equal(11, Dates.NextBusinessDay(date, false, false).Day);
            Assert.Equal(11, Dates.NextBusinessDay(date, false, acceptBaseDate: true).Day);
        }

        [Fact]
        public void NextBusinessDay_Sexta()
        {
            // 08/01/2021 é sexta e não é feriado 
            var date = new DateTime(2021, 01, 08);

            // Próximo dia útil é dia 11, porém aceita o dia de hoje
            Assert.Equal(11, Dates.NextBusinessDay(date, false, false).Day);
            Assert.Equal(8, Dates.NextBusinessDay(date, false, acceptBaseDate: true).Day);
        }

        [Fact]
        public void NextBusinessDay_Feriado()
        {
            // 01/01/2021 é segunda e é feriado 
            var date = new DateTime(2021, 01, 01);
            
            // Próximo dia útil é dia 04 independente do feriado se não olhar o próprio dia
            Assert.Equal(4, Dates.NextBusinessDay(date, checkNationalHolydays: false, false).Day);
            Assert.Equal(4, Dates.NextBusinessDay(date, checkNationalHolydays: true, false).Day);
            // Mesmo que use o próprio dia, é feriado
            Assert.Equal(1, Dates.NextBusinessDay(date, checkNationalHolydays: false, true).Day);
            Assert.Equal(4, Dates.NextBusinessDay(date, checkNationalHolydays: true, true).Day);
        }

        [Fact]
        public void NextBusinessDay_FimSemanaComFeriado()
        {
            // 01/05/2021 é sábado e é feriado 
            var date = new DateTime(2021, 05, 01);

            // Próximo dia útil é dia 04 independente do feriado se não olhar o próprio dia
            Assert.Equal(3, Dates.NextBusinessDay(date, checkNationalHolydays: false, false).Day);
            Assert.Equal(3, Dates.NextBusinessDay(date, checkNationalHolydays: true, false).Day);
            // Mesmo que use o próprio dia, é feriado
            Assert.Equal(3, Dates.NextBusinessDay(date, checkNationalHolydays: false, true).Day);
            Assert.Equal(3, Dates.NextBusinessDay(date, checkNationalHolydays: true, true).Day);
        }
    }
}

using System;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.DatesTestes
{
    public class IsBusinessDayTestes
    {
        [Fact]
        public void IsBusinessDay_BaseTests()
        {
            // 01/01/2021 é sexta 
            var date = new DateTime(2021, 01, 01);

            // Sem contar o feriado, é dia útil
            Assert.True(Dates.IsBusinessDay(date, checkNationalHolydays: false));

            // considerando o feriado, não é
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: true));
        }

        [Fact]
        public void IsBusinessDay_DiaUtil()
        {
            // 04/01/2021 é segunda e não é feriado 
            var date = new DateTime(2021, 01, 04);

            // Sem contar o feriado, é dia útil
            Assert.True(Dates.IsBusinessDay(date, checkNationalHolydays: false));

            // considerando o feriado, não é
            Assert.True(Dates.IsBusinessDay(date, checkNationalHolydays: true));
        }

        [Fact]
        public void IsBusinessDay_FimSemanaSabado()
        {
            // 02/01/2021 é sábado
            var date = new DateTime(2021, 01, 02);

            // Sem contar o feriado, não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: false));

            // Considerando o feriado (não é feriado), também não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: true));
        }
        [Fact]
        public void IsBusinessDay_FimSemanaDomingo()
        {
            // 03/01/2021 é domingo
            var date = new DateTime(2021, 01, 03);

            // Sem contar o feriado, não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: false));

            // Considerando o feriado (não é feriado), também não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: true));
        }


        [Fact]
        public void IsBusinessDay_FimSemanaFeriado()
        {
            // 01/05/2021 é sábado e é feriado 
            var date = new DateTime(2021, 05, 01);

            // Sem contar o feriado, não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: false));

            // considerando o feriado, também não é dia útil
            Assert.False(Dates.IsBusinessDay(date, checkNationalHolydays: true));
        }
    }
}

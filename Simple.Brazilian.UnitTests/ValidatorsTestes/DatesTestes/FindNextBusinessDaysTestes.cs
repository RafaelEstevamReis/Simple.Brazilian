using System;
using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.DatesTestes
{
    public class FindNextBusinessDaysTestes
    {
        [Fact]
        public void FindNextBusinessDays_Base()
        {
            // É Segunda e não é feriado
            var data = new DateTime(2021, 01, 04);

            Assert.Equal(5, Dates.FindNextBusinessDays(data, 1).Day);
            Assert.Equal(6, Dates.FindNextBusinessDays(data, 2).Day);
        }

        [Fact]
        public void FindNextBusinessDays_Feriado()
        {
            // 07/09/2021 É terça e é feriado
            var data = new DateTime(2021, 09, 06); // segunda com feriado na terça

            // +1DU
            // Sem feriado, a terça serve
            Assert.Equal(7, Dates.FindNextBusinessDays(data, 1, checkNationalHolydays: false).Day);
            // com feriado, será quarta
            Assert.Equal(8, Dates.FindNextBusinessDays(data, 1, checkNationalHolydays: true).Day);

            // +2DU
            // Sem feriado, a quarta serve
            Assert.Equal(8, Dates.FindNextBusinessDays(data, 2, checkNationalHolydays: false).Day);
            // com feriado, será quinta
            Assert.Equal(9, Dates.FindNextBusinessDays(data, 2, checkNationalHolydays: true).Day);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 6)]
        [InlineData(3, 7)]
        [InlineData(4, 8)]
        [InlineData(5, 11)]
        [InlineData(6, 12)]
        [InlineData(30, 15)]
        public void FindNextBusinessDays_Range(int diasUteis, int diaMesCai)
        {
            // É Segunda e não é feriado
            var data = new DateTime(2021, 01, 04);

            Assert.Equal(diaMesCai, Dates.FindNextBusinessDays(data, diasUteis, checkNationalHolydays: true).Day);
            Assert.Equal(diaMesCai, Dates.FindNextBusinessDays(data, diasUteis, checkNationalHolydays: false).Day);
        }

    }
}

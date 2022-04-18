using Simple.Brazilian.Information;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.InformationTestes.DatesTestes
{
    public class WorkDayTestes
    {
        [Theory]
        [InlineData(1, WorkDay.DayType.NatinalHoliday)]
        [InlineData(2, WorkDay.DayType.WeekEnd)]
        [InlineData(3, WorkDay.DayType.WeekEnd)]
        [InlineData(4, WorkDay.DayType.WeekDay)]
        public void GetDayTypeTestes_May2020(int day, WorkDay.DayType type)
        {
            var date = new DateTime(2020, 5, day);
            Assert.Equal(type, WorkDay.GetDayType(date));
        }

        [Fact]
        public void WorkDaysBetween_Exemplo_Jan2021()
        {
            DateTime dtInicio = new DateTime(2021, 01, 01);
            DateTime dtFim = new DateTime(2021, 01, 31);

            Assert.Equal(20, WorkDay.WorkDaysBetween(dtInicio, dtFim));
        }
        [Fact]
        public void WorkDaysBetween_Exemplo_Jan2020()
        {
            DateTime dtInicio = new DateTime(2020, 1, 01);
            DateTime dtFim = new DateTime(2020, 1, 31);

            Assert.Equal(22, WorkDay.WorkDaysBetween(dtInicio, dtFim));
        }
        [Fact]
        public void WorkDaysBetween_Exemplo_May2020()
        {
            DateTime dtInicio = new DateTime(2020, 05, 01);
            DateTime dtFim = new DateTime(2020, 05, 31);

            Assert.Equal(20, WorkDay.WorkDaysBetween(dtInicio, dtFim));
        }
        [Fact]
        public void WorkDaysBetween_Exemplo_2020()
        {
            DateTime dtInicio = new DateTime(2020, 01, 01);
            DateTime dtFim = new DateTime(2020, 12, 31);

            Assert.Equal(255, WorkDay.WorkDaysBetween(dtInicio, dtFim));
        }

    }
}

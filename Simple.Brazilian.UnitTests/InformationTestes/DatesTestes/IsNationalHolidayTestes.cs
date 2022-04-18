using Simple.Brazilian.Information;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.InformationTestes.DatesTestes
{
    public class IsNationalHolidayTestes
    {
        // Checar 365/366 dias vai ser complicado
        // Vou checar os que são, e o total

        [Fact]
        public void IsNationalHoliday_TotalCount()
        {
            DateTime dt = new DateTime(2020, 1, 1);

            int count = 0;
            while (dt.Year == 2020)
            {
                bool isNationalHoliday = Dates.IsNationalHoliday(dt, out string name);
                if (isNationalHoliday) count++;

                dt = dt.AddDays(1); // day++
            }

            Assert.Equal(8, count);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 0)]
        [InlineData(3, 0)]
        [InlineData(4, 1)]
        [InlineData(5, 1)]
        [InlineData(6, 0)]
        [InlineData(7, 0)]
        [InlineData(8, 0)]
        [InlineData(9, 1)]
        [InlineData(10, 1)]
        [InlineData(11, 2)]
        [InlineData(12, 1)]
        public void IsNationalHoliday_MonthCount(int month, int actualCount)
        {
            DateTime dt = new DateTime(2020, month, 1);

            int count = 0;
            while (dt.Month == month)
            {
                bool isNationalHoliday = Dates.IsNationalHoliday(dt, out string name);
                if (isNationalHoliday) count++;

                dt = dt.AddDays(1); // day++
            }

            Assert.Equal(actualCount, count);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 21)]
        [InlineData(5, 1)]
        [InlineData(9, 7)]
        [InlineData(11, 2)]
        [InlineData(11, 15)]
        [InlineData(12, 25)]
        [InlineData(10, 12)]
        public void IsNationalHoliday_Is(int month, int day)
        {
            DateTime dt = new DateTime(2020, month, day);
            Assert.True(Dates.IsNationalHoliday(dt, out string name));
        }

    }
}

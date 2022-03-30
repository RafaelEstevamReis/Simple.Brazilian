using Simple.Brazilian.Documents;
using Simple.Brazilian.Information.Places;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.DocumentosTestes.IETestes
{
    public class MaskTestes
    {
        [Theory]
        [InlineData("01.004.823/001-12", UFs.AC)]
        [InlineData("240000048", UFs.AL)]
        [InlineData("03.012.345-9", UFs.AP)]
        [InlineData("07.000.220-7", UFs.AM)]
        [InlineData("123456-63", UFs.BA)]
        [InlineData("031.112.264", UFs.BA)]
        [InlineData("37241644-6", UFs.CE)]
        [InlineData("073.00001.001-09", UFs.DF)]
        [InlineData("99999999-0", UFs.ES)]
        [InlineData("10.987.654-7", UFs.GO)]
        [InlineData("12200609-7", UFs.MA)]
        [InlineData("013.760.531-5", UFs.MT)]
        [InlineData("28294317-0", UFs.MS)]
        [InlineData("062.307.904/0081", UFs.MG)]
        [InlineData("15-999999-5", UFs.PA)]
        [InlineData("06000001-5", UFs.PB)]
        [InlineData("574.48445-60", UFs.PR)]
        [InlineData("0321418-40", UFs.PE)]
        [InlineData("18.1.001.0000004-9", UFs.PE)]
        [InlineData("67721703-0", UFs.PI)]
        [InlineData("99.999.99-3", UFs.RJ)]
        [InlineData("20.040.040-1", UFs.RN)]
        [InlineData("20.0.040.040-0", UFs.RN)]
        [InlineData("784/4832038", UFs.RS)]
        [InlineData("101.62521-3", UFs.RO)]
        [InlineData("0000000062521-3", UFs.RO)]
        [InlineData("24563429-3", UFs.RR)]
        [InlineData("251.040.852", UFs.SC)]
        [InlineData("110.042.490.114", UFs.SP)]
        [InlineData("P-01100424.3/002", UFs.SP)]
        [InlineData("p-01100424.3/002", UFs.SP)]
        [InlineData("27123456-3", UFs.SE)]
        [InlineData("29.01.022783-6", UFs.TO)]
        public void IE_Mask(string maskedToTest, UFs uf)
        {
            string unmasked = IE.Unmask(maskedToTest);
            string masked = IE.Mask(unmasked, uf);
            Assert.Equal(maskedToTest, masked);
        }
        [Fact]
        public void IE_Mask_Empty()
        {
            Assert.Equal("", IE.Mask("", UFs.AC));
        }
        [Fact]
        public void IE_Mask_Null()
        {
            Assert.Throws<ArgumentNullException>(() => IE.Mask(null, UFs.AC));
        }
        [Fact]
        public void IE_Mask_Invalid()
        {
            Assert.Throws<ArgumentException>(() => IE.Mask("123", (UFs)0));
        }
    }
}

using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.CRC
{
    public class CRCTestes
    {
        [Fact]
        public void CRC16_Bytes1()
        {
            var bytes = new byte[] { 1, 2, 3, 4 };
            int result = 35267;
            Assert.Equal(result, CRC16.ComputeCRC(bytes));
        }
        [Fact]
        public void CRC16_Bytes2()
        {
            var bytes = new byte[] { 0x71, 0x82, 0x93, 0xA4 };
            int result = 24045;
            Assert.Equal(result, CRC16.ComputeCRC(bytes));
        }
        [Fact]
        public void CRC16_Text()
        {
            string text = "Simple.Brazilian";
            var result = "12EE";
            Assert.Equal(result, CRC16.ComputeHexCRC(text));
        }
    }
}

using Simple.Brazilian.Validators;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class GenerateReverseSequenceTestes
    {
        [Fact]
        public void GenerateReverseSequenceTestes_BaseTestes()
        {
            int[] arr = new int[] { 6, 5, 4, 3, 2, 1 };
            Assert.Equal(arr, ModValidation.GenerateReverseSequence(1, 6, 6));
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(0)]
        public void GenerateReverseSequenceTestes_Len1Min(int min)
        {
            var arr = new int[] { min };
            Assert.Equal(arr, ModValidation.GenerateReverseSequence(min, min + 1, 1));
        }
        [Fact]
        public void GenerateReverseSequenceTestes_LenMaior()
        {
            int[] arr = new int[] { 7, 6, 5, 4, 3, 8, 7, 6, 5, 4, 3 };
            Assert.Equal(arr, ModValidation.GenerateReverseSequence(3, 8, 11));
        }
        [Fact]
        public void GenerateReverseSequenceTestes_Mod11Tradicional()
        {
            int[] arr = new int[] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            Assert.Equal(arr, ModValidation.GenerateReverseSequence(2, 9, 12));
        }
    }
}

using Simple.Brazilian.Validators;
using System;
using Xunit;

namespace Simple.Brazilian.UnitTests.ValidatorsTestes.ModValitationTestes
{
    public class SumMultiplyTestes
    {
        [Fact]
        public void SumMultiply_int_LenMismatchException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] a1 = new int[] { 1, 2 };
                int[] a2 = new int[] { 1, 2, 3 };
                ModValidation.SumMultiply(a1, a2);
            });
        }
        [Fact]
        public void SumMultiply_int_ArgumentNullException()
        {
            int[] a1 = new int[] { 1, 2 };

            Assert.Throws<ArgumentNullException>(() =>
            {
                ModValidation.SumMultiply(null, a1);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                ModValidation.SumMultiply(a1, (int[])null);
            });
        }
        [Fact]
        public void SumMultiply_int_BaseTest()
        {
            int[] a1 = new int[0];
            int[] a2 = new int[0];
            Assert.Equal(0, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1 };
            a2 = new int[] { 1 };
            Assert.Equal(1, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 2 };
            a2 = new int[] { 2 };
            Assert.Equal(4, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 2, 0 };
            a2 = new int[] { 2, 0 };
            Assert.Equal(4, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1, 2 };
            a2 = new int[] { 1, 2 };
            Assert.Equal(5, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1, 2, 3 };
            a2 = new int[] { 3, 2, 1 };
            Assert.Equal(10, ModValidation.SumMultiply(a1, a2));
        }


        [Fact]
        public void SumMultiply_char_LenMismatchException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                int[] a1 = new int[] { 1, 2 };
                int[] a2 = new int[] { 1, 2, 3 };
                ModValidation.SumMultiply(a1, a2);
            });
        }
        [Fact]
        public void SumMultiply_char_ArgumentNullException()
        {
            int[] a1 = new int[] { 1, 2 };
            char[] a2 = new char[] { '1', '2' };

            Assert.Throws<ArgumentNullException>(() =>
            {
                ModValidation.SumMultiply(null, a2);
            });
            Assert.Throws<ArgumentNullException>(() =>
            {
                ModValidation.SumMultiply(a1, (char[])null);
            });
        }
        [Fact]
        public void SumMultiply_char_BaseTest()
        {
            int[] a1 = new int[0];
            char[] a2 = new char[0];
            Assert.Equal(0, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1 };
            a2 = new char[] { '1' };
            Assert.Equal(1, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 2 };
            a2 = new char[] { '2' };
            Assert.Equal(4, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 2, 0 };
            a2 = new char[] { '2', '0' };
            Assert.Equal(4, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1, 2 };
            a2 = new char[] { '1', '2' };
            Assert.Equal(5, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1, 2, 3 };
            a2 = new char[] { '3', '2', '1' };
            Assert.Equal(10, ModValidation.SumMultiply(a1, a2));
        }
        [Fact]
        public void SumMultiply_char_InvalidChars()
        {
            var a1 = new int[] { 1, 2, 3 };
            var a2 = new char[] { '3', 'a', '1' };
            Assert.Equal(104, ModValidation.SumMultiply(a1, a2));

            a1 = new int[] { 1, 2, 3 };
            a2 = new char[] { '3', '#', '1' };
            Assert.Equal(-20, ModValidation.SumMultiply(a1, a2));
        }

    }
}

using System;
using Xunit;
using OddEvenKata;

namespace OddEvenKata_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "Odd")]
        [InlineData(2, "Even")]
        [InlineData(5, "Odd")]
        [InlineData(51, "Odd")]
        [InlineData(100, "Even")]
        public void TestOddEven(int num, string expected)
        {
            string actual = OddEvenPrime.OddEven(num);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(6, false)]
        [InlineData(11, true)]
        [InlineData(27, false)]
        [InlineData(29, true)]
        public void TestIsPrime(int num, bool expected)
        {
            bool actual = OddEvenPrime.IsPrime(num);
            Assert.Equal(expected, actual);
        }
    }
}

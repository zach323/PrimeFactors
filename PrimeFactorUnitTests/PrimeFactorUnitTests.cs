using System;
using Xunit;
using PrimeFactorClassLib;
namespace PrimeFactorUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPrimesOf546()
        {
            var pf = new PrimeFactor();

            int number = 546;

            string expected = "2 X 3 X 7 X 13";

            var actual = pf.PrimeCalc(number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimesOf888()
        {
            var pf = new PrimeFactor();

            int number = 888;

            string expected = "2 X 2 X 2 X 3 X 37";

            var actual = pf.PrimeCalc(number);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPrimesOf888_Failure()
        {
            var pf = new PrimeFactor();

            int number = 888;

            string expected = "2 X 2 X 2 X 3 X 37 X 46";

            var actual = pf.PrimeCalc(number);

            Assert.NotEqual(expected, actual);
        }
    }
}

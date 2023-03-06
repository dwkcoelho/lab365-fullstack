using numberValidator.Class;

namespace numberValidatorTest
{
    public class NumberValidatorTest
    {
        [Fact]
        public void IsPrimeNumber()
        {
            bool resultPrimeNumber = NumberValidator.IsPrimeNumber(7);
            Assert.True(resultPrimeNumber);
        }
        [Fact]
        public void EvenOddNumber() 
        {
            string resultEvenOddNumber = NumberValidator.EvenOddNumber(7);
            string expected = "Odd";
            Assert.Equal(expected, resultEvenOddNumber);
        }
        [Fact]
        public void IsItDivisible()
        {
            bool resultDivision = NumberValidator.IsItDivisible(10, 5);
            Assert.True(resultDivision);
        }
    }
}
using calculator.Class;

namespace calculatorTest
{
    public class CalculatorTest
    {
        [Fact(Skip = "Ignore the test")]
        public void Division()
        {
            int resultDivision = Calculator.Division(10, 5);
            Assert.Equal(2, resultDivision);
        }
        [Fact(DisplayName = "Your multiplication has been tested.")] 
        public void Multiplication() 
        { 
            int resultMultiplication = Calculator.Multiplication(10, 5);
            Assert.Equal(50, resultMultiplication);
        }
        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(10, 1, 9)]
        public void Subtraction(int firstNumber, int secondNumber, int resultExpected)
        {
            int resultSubtraction = Calculator.Subtraction(firstNumber, secondNumber);
            int expected = resultExpected;
            Assert.Equal(expected, resultSubtraction);
        }

        [Trait("Category", "Sum")]
        [Theory]
        [MemberData(nameof(NumberList))]
        public void IntSumTest(NumberList theList)
        {
            int resultInt = Calculator.Sum(theList.OneNumber, theList.TwoNumber);
            Assert.Equal(theList.Expected, resultInt);
        }
        public static List<object[]> NumberList()
        {
            List<object[]> numberList = new List<object[]>();
            numberList.Add(new[] { new NumberList() { OneNumber = 5, TwoNumber = 5, Expected = 10 } });
            numberList.Add(new[] { new NumberList() { OneNumber = 3, TwoNumber = 8, Expected = 11 } });
            return numberList;
        }

        [Fact]
        [Trait("Category", "Sum")]
        public void DoubleSumTest()
        {
            double resultDouble = Calculator.Sum(5.5, 5.5);

            Assert.Equal(11, resultDouble);
        }
        [Fact]
        [Trait("Category", "Sum")]
        public void FloatSumTest()
        {
            float resultFloat = Calculator.Sum(2.5F, 2.5F);

            Assert.Equal(5, resultFloat);
        }
        [Fact]
        [Trait("Category", "Sum")]
        public void DecimalSumTest()
        {
            decimal resultDecimal = Calculator.Sum(4.5M, 4.5M);

            Assert.Equal(9, resultDecimal);
        }
        [Fact]
        [Trait("Category", "Sum")]
        public void LongSumTest()
        {
            long resultLong = Calculator.Sum(500000, 500000);

            Assert.Equal(1000000, resultLong);
        }
    }
}
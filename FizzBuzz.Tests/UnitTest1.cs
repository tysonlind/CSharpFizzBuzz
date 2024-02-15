namespace FizzBuzz.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, null)]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void Test1(int num, string expected)
        {

        }
    }
}
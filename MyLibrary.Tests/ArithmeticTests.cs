using Xunit;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class ArithmeticTests
    {
        [Fact]
        public void TestAdd()
        {
            Arithmetic arith = new Arithmetic();
            Assert.Equal(5, arith.Add(2, 3));
        }

        [Fact]
        public void TestSubtract()
        {
            Arithmetic arith = new Arithmetic();
            Assert.Equal(1, arith.Subtract(3, 2));
        }
    }
}

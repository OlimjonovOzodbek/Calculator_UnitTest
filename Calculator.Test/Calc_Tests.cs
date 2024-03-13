using Xunit;

namespace Calculator.Test
{
    public class Calc_Tests
    {
        private readonly Calc _calc = new Calc();
        [Fact]

        public void AddTest()
        {
      
            var res = _calc.Add(1, 2);
            Assert.Equal(3, res);
        }
        [Fact]
        
        public void DivideTest()
        {
            var res = _calc.Divide(9, 3);
            Assert.Equal(3, res);
        }
        [Fact]

        public void Subtract()
        {
            var res = _calc.Subtract(9, 3);
            Assert.Equal(6, res);
        }

        [Fact]
        public void Multiply()
        {
            var res = _calc.Multiply(9, 3);
            Assert.Equal(27, res);
        }

    }
}

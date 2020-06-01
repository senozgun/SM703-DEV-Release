using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCalculator;
using Xunit;

namespace BasicLibrary.Tests
{
    public class CalcTest
    {
        [Fact]
        public void Sum_SimpleValues()
        {
            int expected = 5;

            int actual = Calc.Sum(3, 2);

            Assert.Equal(expected, actual);
        }
    }
}

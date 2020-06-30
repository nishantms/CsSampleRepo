using Xunit;
using BasicMath;

namespace BasicMathTest
{
    public class UnitTest1
    {
        [Fact]
        public void Task_Add_TwoNumber()
        {
            BasicMaths bm = new BasicMaths();
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 6;

            // Act  
            var sum = bm.Add(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sum, 1);
        }

        [Fact]
        public void Task_Subtract_TwoNumber()
        {
            BasicMaths bm = new BasicMaths();
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = -0.2;

            // Act  
            var sub = bm.Substract(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, sub, 1);
        }

        [Fact(DisplayName = "My failing test")]
        public void Task_Multiply_TwoNumber()
        {
            BasicMaths bm = new BasicMaths();
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 8.99;

            // Act  
            var mult = bm.Multiply(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, mult, 2);
        }

        [Fact]
        public void Task_Divide_TwoNumber()
        {
            BasicMaths bm = new BasicMaths();
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var expectedValue = 0.94; //Rounded value  

            // Act  
            var div = bm.Divide(num1, num2);

            //Assert  
            Assert.Equal(expectedValue, div, 2);
        }
    }
}

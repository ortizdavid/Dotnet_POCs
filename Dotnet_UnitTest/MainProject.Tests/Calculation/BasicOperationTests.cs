using MainProject.Calculations;

namespace MainProject.Tests.Calculation
{
    public class BasicOperationTests
    {
        private readonly BasicOperation _operation;

        public BasicOperationTests()
        {
            _operation = new BasicOperation();
        }
        
        [Fact]
        public void Sum_PositiveNumbers()
        {
            // Arrange
            int a = 10;
            int b = 20;
            // Act
            int result = _operation.Sum(a, b);
            // Assert
            Assert.Equal(30, result);
        }

        [Fact]
        public void Sum_NegativeNumbers()
        {
            // Arrange
            var operation = new BasicOperation();
            int a = -10;
            int b = -20;
            // Act
            int result = _operation.Sum(a, b);
            // Assert
            Assert.Equal(-30, result);
        }

        [Fact]
        public void Subract_PositiveNumbers()
        {
            // Arrange
            int a = 10;
            int b = 7;
            // Act
            int result = _operation.Subtract(a, b);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Subract_NegativeNumbers()
        {
            // Arrange
            int a = -10;
            int b = -7;
            // Act
            int result = _operation.Subtract(a, b);
            // Assert
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Multiply_Positives()
        {
            // Arrange
            int a = 3;
            int b = 5;
            // Act
            int result = _operation.Multiply(a, b);
            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Multiply_Negatives()
        {
            // Arrange
            int a = -9;
            int b = -3;
            // Act
            int result = _operation.Multiply(a, b);
            // Assert
            Assert.Equal(27, result);
        }

        [Fact]
        public void Divide_Positives()
        {
            // Arrange
            float a = 18;
            float b = 36;
            // Act
            float result = _operation.Divide(a, b);
            // Assert
            Assert.Equal(0.5, result);
        }
        
        [Fact]
        public void Divide_Negatives()
        {
            // Arrange
            float a = -12;
            float b = -4;
            // Act
            float result = _operation.Divide(a, b);
            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Divide_ByZero()
        {
            // Arrange
            float a = 8;
            float b = 0;
            // Act
            var exception = Assert.Throws<DivideByZeroException>(() => _operation.Divide(a, b));
            // Assert
            Assert.Equal("b must be different than 0", exception.Message);
        }
    }
}
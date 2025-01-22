using MainProject.Calculations;

namespace MainProject.Tests.Calculation
{
    public class EquationTests
    {
        [Fact]
        public void SolveQuadratic_ShouldReturnError_WhenNotQuadratic()
        {
            // Arrange
            var equation = new Equation();
            // Act
            var result = equation.SolveQuadratic(0, -2, 6);
            // Assert
            Assert.Equal("Not a quadratic equation", result.error);
            Assert.Null(result.x1);
            Assert.Null(result.x2);
        }

        [Fact]
        public void SolveQuadraric_ShouldReturnError_WhenNotRealRoots()
        {
            // Arrange
            var equation = new Equation();
            // Act
            var result = equation.SolveQuadratic(2, 1, 8);
            // Assert
            Assert.Equal("No real roots", result.error);
            Assert.Null(result.x1);
            Assert.Null(result.x2);
        }

        [Fact]
        public void SolveQuadraric_ShouldReturnRoots_WhenIsCorrect()
        {
            // Arrange
            var equation = new Equation(); 
            // Act
            var result = equation.SolveQuadratic(1, -3, 2);
            // Assert
            Assert.Equal("", result.error);
            Assert.Equal(1, result.x1);
            Assert.Equal(2, result.x2);
        }

        [Fact]
        public void SolvePythagoras_ShouldReturnError_WhenIsNotATriangle()
        {
            // Arrange
            var equation = new Equation();
            // Act
            var result = equation.SolvePythagoras(0, 2);
            // Assert
            Assert.Equal("Is not a triangle", result.error);
            Assert.Null(result.c);
        }

        [Fact]
        public void SolvePythagoras_ShouldReturnHypotenusa_WhenIsCorrect()
        {
            // Arrange
            var equation = new Equation();
            // Act
            var result = equation.SolvePythagoras(3, 4);
            // Assert
            Assert.Equal("", result.error);
            Assert.Equal(5, result.c);
        }
    }
}
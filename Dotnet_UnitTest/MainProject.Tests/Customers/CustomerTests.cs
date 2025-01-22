using MainProject.Customers;

namespace MainProject.Tests.Customers
{
    public class CustomerTests
    {
        [Fact]
        public void IncreaseBalance_ShouldThrowException_WhenValueIsLessThanZero()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 0
            };
            // Act
            var exception = Assert.Throws<Exception>(() => customer.IncreaseBalance(-1800));
            // Assert
            Assert.Equal("Value to increase must be greather than 0", exception.Message);          
        }

        [Fact]
        public void IncreaseBalance_ShouldThrowException_WhenValueIsZero()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 0
            };
            // Act
            var exception = Assert.Throws<Exception>(() => customer.IncreaseBalance(0));
            // Assert
            Assert.Equal("Value to increase must be greather than 0", exception.Message);          
        }

        [Fact]
        public void IncreaseBalance_ShouldWork_WhenValueIsCorrect()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 0
            };
            // Act
            customer.IncreaseBalance(200);
            customer.IncreaseBalance(150);
            // Assert
            Assert.Equal(350, customer.Balance); 
        }

        [Fact]
        public void DecreaseBalance_ShouldThowException_WhenValueIsNegative()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 100
            };
            // Act
            var exception = Assert.Throws<ArgumentException>(() => customer.DecreaseBalance(-50));
            // Assert
            Assert.Equal("Value to decrease must be greather than 0", exception.Message);
        }

        [Fact]
        public void DecreaseBalance_ShouldThrowException_WhenValueIsZero()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 100
            };
            // Act
            var exception = Assert.Throws<ArgumentException>(() => customer.DecreaseBalance(0));
            // Assert
            Assert.Equal("Value to decrease must be greather than 0", exception.Message);
        }

        [Fact]
        public void DecreaseBalance_ShouldThowException_WhenBalanceIsInsufficient()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 100
            };
            // Act
            var exception = Assert.Throws<InvalidOperationException>(() => customer.DecreaseBalance(200));
            // Assert
            Assert.Equal("Insufficient balance", exception.Message);
        }

        [Fact]
        public void DecreaseBalance_ShouldWork_WhenIsCorrect()
        {
            // Arrange
            var customer = new Customer()
            {
                Balance = 300
            };
            // Act
            customer.DecreaseBalance(100);
            customer.DecreaseBalance(50);
            // Assert
            Assert.Equal(150, customer.Balance);
        }

        [Fact]
        public void IsOlderThan_ShouldThowException_WhenCustomerIsNull()
        {
            // Arrange
            var customer1 = new Customer()
            {
                BirthDate = DateTime.Parse("1994-01-10")
            };
            var customer2 = new Customer();
            // Act
            var exception = Assert.Throws<Exception>(() => customer1.IsOlderThan(customer2));
            // Assert
            Assert.Equal("Other BirthDate cannot be null", exception.Message);
        }

        [Fact]
        public void IsOlderThan_ShouldReturnFalse_WhenOtherBirthIsLesser()
        {
            // Arrange
            var customer1 = new Customer()
            {
                BirthDate = DateTime.Parse("1990-01-01")
            };
            var customer2 = new Customer()
            {
                BirthDate = DateTime.Parse("1989-12-12")
            };
            // Act
            var result = customer1.IsOlderThan(customer2); 
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsOlderThan_ShouldReturnTrue_WhenIsCorrect()
        {
            // Arrange
            var customer1 = new Customer()
            {
                BirthDate = DateTime.Parse("1920-01-01")
            };   
            var customer2 = new Customer()
            {
                BirthDate = DateTime.Parse("1974-04-04")
            };
            // Act
            var result = customer1.IsOlderThan(customer2);
            // Assert
            Assert.True(result);
        }
    }
}
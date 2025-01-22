using MainProject.Customers;

namespace MainProject.Tests
{
    public class CustomerManagerTests
    {
        [Fact]
        public void CreateCustomer_ShouldThowException_WhenCustomerExists()
        {
            // Arrange
            var manager = new CustomerManager();
            var customer1 = new Customer { Code = "C001" };
            var customer2 = new Customer { Code = "C002" };
            var customer3 = new Customer { Code = "C002" };
            // Act
            manager.Add(customer1);
            manager.Add(customer2);
            var exception = Assert.Throws<InvalidOperationException>(() => manager.Add(customer3));
            // Arrange
            Assert.Equal($"Customer code '{customer3.Code}' already exists", exception.Message);
        }

        [Fact]
        public void CreateCustomer_ShouldWork_WhenIsCorrect()
        {
            // Arrange
            var manager = new CustomerManager();
            var customer = new Customer { Code = "C009" };
            // Act
            manager.Add(customer);
            var hasValues = manager.HasValues();
            // Arrange
            Assert.True(hasValues);
        }

        [Fact]
        public void RemoveCustomer_ShouldThowException_WhenCustomerListIsEmpty()
        {
            // Arrange
            var manager = new CustomerManager();
            // Act
            var exception = Assert.Throws<Exception>(() => manager.Remove("C-01"));
            // Arrange
            Assert.Equal("Customers List is empty", exception.Message);
        }


        [Fact]
        public void RemoveCustomer_ShouldThowException_WhenCustomerNotFound()
        {
            // Arrange
            var manager = new CustomerManager();
            manager.Add(new Customer { Code = "C001" });
            manager.Add(new Customer { Code = "C002" });
            manager.Add(new Customer { Code = "C003" });
            // Act
            var code = "C092";
            var exception = Assert.Throws<KeyNotFoundException>(() => manager.Remove(code));
            // Arrange
            Assert.Equal($"Customer with code '{code}' does not exist.", exception.Message);
        }

        [Fact]
        public void RemoveCustomer_ShouldWork_WhenIsCorrect()
        {
            // Arrange
            var manager = new CustomerManager();
            manager.Add(new Customer { Code = "C001" });
            manager.Add(new Customer { Code = "C002" });
            manager.Add(new Customer { Code = "C003" });
            manager.Add(new Customer { Code = "C004" });
            // Act
            manager.Remove("C001");
            manager.Remove("C002");
            // Arrange
            Assert.Equal(2, manager.Count());
        }

        [Fact]
        public void SumBalances_ShouldReturnZero_WhenIsEmpty()
        {
            // Arrange
            var manager = new CustomerManager();
            // Act
            var result = manager.SumBalances();
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void SumBalances_ShouldReturnTotal_WhenHasValue()
        {
            // Arrange
            var manager = new CustomerManager();
            // Act
            manager.Add(new Customer { Code = "C01", Balance = 1000 });
            manager.Add(new Customer { Code = "C02", Balance = 1000 });
            manager.Add(new Customer { Code = "C03", Balance = 1000 });
            manager.Add(new Customer { Code = "C04", Balance = 2000 });
            var result = manager.SumBalances();
            // Assert
            Assert.Equal(5000, result);
        }
    }
}
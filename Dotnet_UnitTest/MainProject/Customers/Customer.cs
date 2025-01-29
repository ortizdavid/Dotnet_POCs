namespace MainProject.Customers;

public class Customer
{
    public string? Code { get; set; }
    public DateTime? BirthDate { get; set; } 
    public double Balance { get; set; }
    
    public void IncreaseBalance(double value)
    {
        if (value <= 0)
        {
            throw new Exception("Value to increase must be greather than 0");
        }
        Balance = Balance + value;
    }

    public void DecreaseBalance(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Value to decrease must be greather than 0");
        }
        if (value > Balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }
        Balance = Balance - value;
    }

    public bool IsOlderThan(Customer other)
    {
        if (other.BirthDate is null)
        {
            throw new Exception("Other BirthDate cannot be null");
        }
        return BirthDate < other.BirthDate;
    }
}
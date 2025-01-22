namespace MainProject.Customers
{
    public class CustomerManager
    {
        private readonly List<Customer> _customerList;

        public CustomerManager()
        {
            _customerList = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            if (_customerList.Any(x => x.Code == customer.Code))
            {
                throw new InvalidOperationException($"Customer code '{customer.Code}' already exists");
            }
            _customerList.Add(customer);
        }

        public void Remove(string code)
        {
            if (!_customerList.Any())
            {
                throw new Exception("Customers List is empty");
            }
            var customer = _customerList.FirstOrDefault(x => x.Code == code);
            if (customer is null)
            {
                throw new KeyNotFoundException($"Customer with code '{code}' does not exist.");
            }
            _customerList.Remove(customer);
        }

        public double SumBalances()
        {
            return _customerList.Sum(x => x.Balance);
        }

        public int Count()
        {
            return _customerList.Count;
        }

        public bool HasValues()
        {
            return _customerList.Any();
        }
    }
}
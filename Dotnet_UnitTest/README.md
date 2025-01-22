# MainProject - Unit Tests for Basic Operations, Equations, and Customer Management

This project contains various mathematical operations and customer management functionalities. Unit tests have been implemented to ensure the correct behavior of these functionalities.

## Features

### 1. Basic Operations
- **Sum**: Adds two integers.
- **Subtract**: Subtracts the second integer from the first.
- **Multiply**: Multiplies two integers.
- **Divide**: Divides the first integer by the second (throws `DivideByZeroException` for division by zero).

### 2. Equation Solvers
- **SolveQuadratic**: Solves quadratic equations of the form `ax^2 + bx + c = 0` and returns the roots or an error message.
- **SolvePythagoras**: Solves the Pythagorean theorem `a^2 + b^2 = c^2` for right triangles.

### 3. Customer Management
- **Customer**: Represents a customer with attributes like `Code`, `BirthDate`, and `Balance`. Includes methods to:
  - Increase or decrease the balance.
  - Compare customers' ages.
  
- **CustomerManager**: Manages a list of customers and supports operations like:
  - Adding a customer.
  - Removing a customer by code.
  - Summing the balances of all customers.
  - Checking if there are any customers in the list.

## Tools

- **.NET 9.0**: The project is built on the .NET 9.0 framework.
- **Xunit**: The testing framework used for unit tests.
- **Coverlet**: Code coverage tool for Xunit tests.


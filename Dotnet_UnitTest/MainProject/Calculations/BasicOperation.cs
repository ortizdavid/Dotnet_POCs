namespace MainProject.Calculations;

public class BasicOperation
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public float Divide(float a, float b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("b must be different than 0");
        }
        return a / b;
    }
}
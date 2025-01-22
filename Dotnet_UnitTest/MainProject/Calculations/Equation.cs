namespace MainProject.Calculations
{
    public class Equation
    {
        public (double? x1, double? x2, string error) SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                return (null, null, "Not a quadratic equation");
            }
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                return (null, null, "No real roots");
            }
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            return (x1, x2, "");
        }

        public (double? c, string error) SolvePythagoras(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return (null, "Is not a triangle");
            }
            var c = Math.Sqrt(a * a + b * b);
            return (c, "");
        }
    }
}
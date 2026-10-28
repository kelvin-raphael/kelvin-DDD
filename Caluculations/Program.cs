Console.WriteLine("Hello, World!");
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Subtract(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public float Divide(float a, float b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return a / b;
        }

        public int Mid(int x, int y, int z)
        { // return median of x, y, z
            int mid = z;
            if (y < z)
            {
                if (x < y)
                {
                    mid = y;
                }
                else if (x < z)
                {
                    mid = x;
                }
            }
            else
            {
                if (x > y)
                {
                    mid = y;
                }
                else if (x > z)
                {
                    mid = x;
                }
            }
            return mid;
        }
    }
    
}
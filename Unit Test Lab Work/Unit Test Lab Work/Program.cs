using System.Data;

namespace Unit_Test_Lab_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return a/b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
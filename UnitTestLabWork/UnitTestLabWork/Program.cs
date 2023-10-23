using System.Data;

namespace UnitTestLabWork
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
        #region FirstHalfOfLabSheet
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
        #endregion

        public int Mid(int x, int y, int z) //Returns median of x, y, and z
        {
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

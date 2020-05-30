using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calcul
    {
        public int sum(int x, int y)
        {
            return x + y;
        }
        public int dif(int x, int y)
        {
            return x - y;
        }
        public int mult(int x, int y)
        {
            return x * y;
        }

        public string Hello()
        {
            return "Hello";
        }
    }
}

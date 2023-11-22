using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static int myVar;
        static void Main(string[] args)
        {
            Program a = new Program();
            Program b = new Program();
            Console.WriteLine("Enter number: ");
            a.Test(Convert.ToInt32(Console.ReadLine()));
            myVar = 10;
            myVar = 11;
            Console.WriteLine("a: " + myVar);
            Console.WriteLine("b: " + myVar);

        }

        public void Test(int i)
        {
            if (i < 9)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
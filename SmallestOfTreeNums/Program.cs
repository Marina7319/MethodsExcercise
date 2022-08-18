using System;
namespace SmallestOfTreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfTreeNums(a: num1, b: num2, c: num3));
        }
        static int SmallestOfTreeNums(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}

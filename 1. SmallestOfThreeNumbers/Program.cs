using System;

namespace _1._SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(messege: "Hello people");
            int a = 5;
            int b = 5;

            int result = sumNumbers(a, b);
            Console.WriteLine(result);
        }

       // static void Print(string messege)
       // {
       //     Console.WriteLine($"{messege}");
       // } 

        static int sumNumbers(int a , int b)
        {
            int sum = a + b;
            return sum;
        }
    }
}

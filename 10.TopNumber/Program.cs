using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int numbers = i;
                int digit = i;
                int sum = 0;
                int number = 0;
                while (digit > 0)
                {
                    int currDigit = digit % 10;
                    sum += currDigit;
                    if (sum % 8 == 0)
                    {
                        number = digit; Console.WriteLine(numbers);
                        while (number > 0)
                        {
                            int currNumber = number % 10;
                            int numberCount = 0;
                            if (currNumber % 2 != 0)
                            {
                                numberCount++;
                                if (numberCount == 1)
                                {
                                    break;
                                }
                            }
                            number = number / 10;
                        }

                    }
                    digit = digit / 10;

                    //if (divisibleByEight(i) % 8 == 0)
                    //  {
                    //      Console.WriteLine(oddDigit(i));
                    //  }
                }
                static int oddDigit(int numOne)
                {
                    int number = numOne;
                    while (number > 0)
                    {
                        int currNumber = number % 10;
                        int numberCount = 0;
                        if (currNumber % 2 != 0)
                        {
                            numberCount++;
                            if (numberCount == 1)
                            {
                                break;
                            }
                        }
                        number = number / 10;
                    }
                    return number;
                }

                static int divisibleByEight(int numTwo)
                {
                    int digit = numTwo;
                    int sum = 0;
                    while (numTwo > 0)
                    {
                        int currDigit = numTwo % 10;
                        sum += currDigit;
                        numTwo = numTwo / 10;
                    }
                    return sum;
                }
            }
        }
    }
}

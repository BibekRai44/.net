//Write a C# program to compute the sum of the first 500 prime numbers.

using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 2;
        int count = 0;
        long sum = 0;

        while (count < 500)
        {
            if (IsPrime(num))
            {
                sum += num;
                count++;
            }
            num++;
        }

        Console.WriteLine("The sum of the first 500 prime numbers is: " + sum);
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

}


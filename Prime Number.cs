using System;

class PrimeGenerator
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer value for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers up to {0}:", n);

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.Write("{0} ", i);
            }
        }

        Console.ReadLine(); // wait for user input before closing
    }
}
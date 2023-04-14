using System;

class Program
{
    static int RecursiveSum(int n, int m)
    {
        if (n > m)
            return 0;
        else
            return n + RecursiveSum(n + 1, m);
    }

    static int CountDivisions(int num)
    {
        int count = 0;
        while (num % 2 == 0)
        {
            count++;
            num /= 2;
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number m: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine(RecursiveSum(n, m));

        Console.Write("Enter your number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Total number of divisions: " + CountDivisions(num));
    }
}
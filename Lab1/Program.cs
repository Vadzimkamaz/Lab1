using System;
using System.Numerics;

namespace Lab1
{
    class Program
    {
        static BigInteger Fibonacci(BigInteger m)
        {
            BigInteger q = new BigInteger(1);
            BigInteger w = new BigInteger(1);
            BigInteger e = new BigInteger(0);

            for (int i = 0; i < m; i++)
            {
                e = q;
                q = w;
                w = e + w;
            }
            return q;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел последовательности фибоначи: ");
            int n = int.Parse(Console.ReadLine());
            BigInteger m = new BigInteger(n);
            for (int i = 0; i < m; i++)
            {
                Console.Write((i + 1) + ". " + Fibonacci(i) + "\n");
                if (i == (m - 1)) Console.WriteLine("\nВыполнено.");
            }

            Console.ReadLine();
        }

    }
}
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int stars = n % 2 == 0 ? 2 : 1;
        int roofRows = (n + 1) / 2;

        for (int row = 0; row < roofRows; row++)
        {
            int dashes = (n - stars) / 2;

            for (int i = 0; i < dashes; i++)
                Console.Write('-');

            for (int i = 0; i < stars; i++)
                Console.Write('*');

            for (int i = 0; i < dashes; i++)
                Console.Write('-');

            Console.WriteLine();

            stars += 2;
        }

        int baseRows = n / 2;
        for (int row = 0; row < baseRows; row++)
        {
            Console.Write('|');
            for (int i = 0; i < n - 2; i++)
                Console.Write('*');
            Console.WriteLine('|');
        }
    }
}
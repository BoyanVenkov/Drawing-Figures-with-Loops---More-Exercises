using System;
using System.Text;

public class Diamond
{
    public static void Main(string[] args)
    {
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 100)
        {

        }

        int rows = (n % 2 == 0) ? n - 1 : n;
        int middleIndex = rows / 2;

        for (int i = 0; i < rows; i++)
        {

            int leftRight = Math.Abs(i - middleIndex);

            int mid = n - 2 * leftRight - 2;

            StringBuilder line = new StringBuilder();

            line.Append(new string('-', leftRight));

            line.Append('*');
            if (mid >= 0)
            {
                line.Append(new string('-', mid));
                line.Append('*');
            }

            line.Append(new string('-', leftRight));
            Console.WriteLine(line.ToString());
        }
    }
}
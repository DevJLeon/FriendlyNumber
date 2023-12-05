using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("The next friendly numbers under 1500 are: ");
        Console.Write(FriendlyNumber()[0] + " & " + FriendlyNumber()[1]);
    }
    static int[] FriendlyNumber()
    {
        for (int y = 1500; y > 0; y--)
        {
            int temp = 1;
            int x = 1;

            for (int i = 2; i < y; i++)
            {
                if (y % i == 0)
                {
                    x += y / i;
                }
            }

            for (int j = 2; j < x; j++)
            {
                if (x % j == 0)
                {
                    temp += x / j;
                }
            }

            if (temp == y && y > x)
            {
                return new int[] { x, y };
            }
        }

        return Array.Empty<int>();
    }
}

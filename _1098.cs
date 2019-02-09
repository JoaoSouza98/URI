using System;

namespace _1098
{
    class _1098
    {
        static void Main(string[] args)
        {
            double i = 0.0;
            double j = 0.0;

            while (i <= 2)
            {
                for (int aux = 1; aux <= 3; aux++)
                {
                    Console.WriteLine($"I={i} J={(double)aux + j}");
                }
                i += 0.2;
                j += 0.2;
            }
        }
    }
}

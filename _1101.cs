using System;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, m = 1, sum;


            while (n > 0 && m > 0)
            {
                string[] _in = Console.ReadLine().Split(' ');
                n = int.Parse(_in[0]);
                m = int.Parse(_in[1]);

                if (m > 0 && n > 0)
                {
                    if (n > m)
                    {
                        sum = 0;
                        for (int i = m; i <= n; i++)
                        {
                            Console.Write($"{i} ");
                            sum += i;
                        }
                        Console.WriteLine($"Sum={sum}");
                    }
                    else if (n < m)
                    {
                        sum = 0;
                        for (int i = n; i <= m; i++)
                        {
                            Console.Write($"{i} ");
                            sum += i;
                        }
                        Console.WriteLine($"Sum={sum}");
                    }
                    else
                    {
                        Console.WriteLine($"{n} Sum={m}");
                    }
                }
            }

        }
    }
}

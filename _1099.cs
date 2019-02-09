using System;

namespace _1099
{
    class _1099
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, y;

            for (int i = 0; i < n; i++)
            {
                string[] _in = Console.ReadLine().Split(' ');
                x = int.Parse(_in[0]);
                y = int.Parse(_in[1]);
                int sum = 0;

                if (x < y)
                {
                    for (int j = x+1; j <y; j++)
                    {
                        if (j % 2 == 1)
                        {
                            sum += j;
                        }
                    }
                }
                else if (x > y) {
                    for (int j = y + 1; j < x; j++)
                    {
                        if (j % 2 == 1)
                        {
                            sum += j;
                        }
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}

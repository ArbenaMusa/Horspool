using System;

namespace Horspool
{
    class Program
    {
        static void Main(string[] args)
        {
            int position;
            Horspool horsepool = new Horspool();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Give the source text:");
                string source = Console.ReadLine();
                Console.WriteLine("Give the pattern:");
                string pattern = Console.ReadLine();

                horsepool.shifttable(pattern);
                position = horsepool.horspool(source, pattern);
                if (position == -1)
                    Console.WriteLine("Pattern not found!");
                else
                    Console.WriteLine("Pattern found at: " + position);
            }
        }
    }
}

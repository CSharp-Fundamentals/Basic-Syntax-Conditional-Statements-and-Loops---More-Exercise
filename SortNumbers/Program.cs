using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int highest =int.MinValue;
            int middle = int.MinValue;
            int lowest = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > highest)
                {
                    lowest = middle;
                    middle = highest;
                    highest = n;
                }
                else if (n > middle)
                {
                    lowest = middle;
                    middle = n;
                }
                else if(n>lowest)
                {
                    lowest = n;
                }
            }
            Console.WriteLine(highest);
            Console.WriteLine(middle);
            Console.WriteLine(lowest);
        }
    }
}

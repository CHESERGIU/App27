using System;

namespace App27
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            string input;
            do
            {                
                input = Console.ReadLine();
                int.TryParse(input, out int num);
                if (num >= 0 && input != "x")
                    p++;
            } while (!(input == "x"));
            Console.WriteLine(p);
        }
    }
}

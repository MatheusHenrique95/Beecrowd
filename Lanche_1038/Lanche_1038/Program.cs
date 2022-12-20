namespace Lanche_1038
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double L1, L2, L3, L4, L5;
            string[] num = Console.ReadLine().Split();

            L1 = 4.00;
            L2 = 4.50;
            L3 = 5.00;
            L4 = 2.00;
            L5 = 1.50;

            if (num[0] == "1")
            {
                Console.WriteLine($"Total: R$ {(L1 * int.Parse(num[1])):F2}");
            }
            else if (num[0] == "2")
            {
                Console.WriteLine($"Total: R$ {(L2 * int.Parse(num[1])):F2}");
            }
            else if (num[0] == "3")
            {
                Console.WriteLine($"Total: R$ {(L3 * int.Parse(num[1])):F2}");
            }
            else if (num[0] == "4")
            {
                Console.WriteLine($"Total: R$ {(L4 * int.Parse(num[1])):F2}");
            }
            else if (num[0] == "5")
            {
                Console.WriteLine($"Total: R$ {(L5 * int.Parse(num[1])):F2}");
            }

        }
    }
}
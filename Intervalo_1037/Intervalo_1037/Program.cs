namespace Intervalo_1037
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if(0 <= num && num <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            } else if ( 25 < num && num <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if (50 < num && num <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            } else if (75 < num && num <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            } else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
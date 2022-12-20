namespace Consumo_1014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            double ConsMed = X / Y;

            Console.WriteLine($"{ConsMed:F3} km/l");
        }
    }
}
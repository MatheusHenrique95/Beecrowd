namespace GastoDeCombustivel_1016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double L;
            int kmh, h, km;

            kmh = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            km = kmh * h;
            L = km/12.0;

            Console.WriteLine($"{L:F3}");
        }
    }
}
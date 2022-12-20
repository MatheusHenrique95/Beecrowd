namespace Esfera_1011
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double pi = 3.14159;
            float R = float.Parse(Console.ReadLine());
            double VOLUME = (4.0 / 3) * (pi) * (R * R * R);

            Console.WriteLine($"VOLUME = {VOLUME:F3}");
        }
    }
}
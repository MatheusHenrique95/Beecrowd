namespace Triangulo_1043
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;

            string[] lados = Console.ReadLine().Split();

            ladoA = double.Parse(lados[0]);
            ladoB = double.Parse(lados[1]);
            ladoC = double.Parse(lados[2]);

            if (ladoB - ladoC < ladoA && ladoB - ladoC < ladoB + ladoC &&
                ladoA - ladoC < ladoB && ladoA - ladoC < ladoA + ladoC &&
                ladoA - ladoB < ladoC && ladoA - ladoB < ladoA + ladoB)
            {
                double perimetro = ladoA + ladoB + ladoC;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            } else
            {
                double area = (ladoC / 2) * (ladoB + ladoA);
                Console.WriteLine($"Area = {area:F1}");
            }
        }
    }
}
namespace Area_1012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            double A, B, C, pi, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
            pi = 3.14159;
            A = double.Parse(arr[0]);
            B = double.Parse(arr[1]);
            C = double.Parse(arr[2]);

            TRIANGULO = (A * C) / 2;
            CIRCULO = pi * C * C;
            TRAPEZIO = C / 2 * (A + B);
            QUADRADO = B * B;
            RETANGULO = B * A;

            Console.WriteLine($"TRIANGULO: {TRIANGULO:F3}");
            Console.WriteLine($"CIRCULO: {CIRCULO:F3}");
            Console.WriteLine($"TRAPEZIO: {TRAPEZIO:F3}");
            Console.WriteLine($"QUADRADO: {QUADRADO:F3}");
            Console.WriteLine($"RETANGULO: {RETANGULO:F3}");

        }
    }
}
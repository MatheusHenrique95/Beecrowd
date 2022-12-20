namespace Media2_1006
{
    using System;
    public class Program
    {
    public static void Main(string[] args)
        {
            double A, B, C, p1, p2, p3, MEDIA;

            p1 = 2;
            p2 = 3;
            p3 = 5;
            
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            A = A * p1;
            B = B * p2;
            C = C * p3;

            MEDIA = (A + B + C) / 10;

            Console.WriteLine($"MEDIA = {MEDIA:F1}");
        }
    }
}
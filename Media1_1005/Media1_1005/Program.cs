namespace Media1_1005
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, MEDIA, W1, W2;

            W1 = 3.5;
            W2 = 7.5;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            A = A * W1;
            B = B * W2;

            MEDIA = (A + B) / 11;

            Console.WriteLine($"MEDIA = {MEDIA:F5}");
        }
    }
}
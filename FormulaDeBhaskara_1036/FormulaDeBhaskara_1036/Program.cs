namespace FormulaDeBhaskara_1036
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double A, B, C, D, BASPOS, BASNEG;
            string[] num = Console.ReadLine().Split();

            A = double.Parse(num[0]);
            B = double.Parse(num[1]);
            C = double.Parse(num[2]);

            D = (B * B) - (4 * A * C);

            if (D < 0 || A==0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                BASPOS = (-B + Math.Sqrt(D)) / (2 * A);
                BASNEG = (-B - Math.Sqrt(D)) / (2 * A);
                Console.WriteLine($"{BASPOS:F5}");
                Console.WriteLine($"{BASNEG:F5}");
            }
        }
    }
}
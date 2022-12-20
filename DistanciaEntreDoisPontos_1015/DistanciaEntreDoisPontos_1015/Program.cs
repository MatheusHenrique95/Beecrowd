namespace DistanciaEntreDoisPontos_1015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            float X1, X2, Y1, Y2;
            double DISTANCIA, x, y;

            string[] p1 = Console.ReadLine().Split();
            string[] p2 = Console.ReadLine().Split();

            X1 = float.Parse(p1[0]);
            X2 = float.Parse(p2[0]);
            Y1 = float.Parse(p1[1]);
            Y2 = float.Parse(p2[1]);

            DISTANCIA = Math.Sqrt(Math.Pow(x = (X2 - X1), 2) + Math.Pow(y = (Y2 - Y1), 2));

            Console.WriteLine("{0:0.0000}", DISTANCIA);

        }
    }
}
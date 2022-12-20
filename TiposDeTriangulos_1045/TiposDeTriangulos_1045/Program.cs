namespace TiposDeTriangulos_1045
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

            if (ladoC > ladoA && ladoC > ladoB)
            {
                double aux = ladoC;
                ladoC = ladoA;
                ladoA = aux;
            }
            else if (ladoB > ladoA && ladoB > ladoC) { 
                double aux = ladoB;
                ladoB = ladoA;
                ladoA = aux;
            }
            if(ladoC > ladoB)
            {
                double aux = ladoC;
                ladoC = ladoB;
                ladoB= aux;
            }


            if (ladoA >= (ladoC + ladoB))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }
            if (ladoA * ladoA == (ladoC * ladoC + ladoB * ladoB))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (ladoA * ladoA > (ladoC * ladoC + ladoB * ladoB))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
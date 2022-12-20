namespace Quadrante_1115 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            while (true) {

                string[] coordenadas = Console.ReadLine().Split();
                double x = double.Parse(coordenadas[0]);
                double y = double.Parse(coordenadas[1]);

                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("quarto");
                } else if (x == 0 || y == 0) {
                    return;
                }
            }
        }
    }
}
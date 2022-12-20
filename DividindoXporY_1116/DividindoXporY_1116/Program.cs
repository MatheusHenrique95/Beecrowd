namespace DividindoXporY_1116 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {

                string[] valores = Console.ReadLine().Split();
                int numX = int.Parse(valores[0]);
                int numY = int.Parse(valores[1]);

                if(numY == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double div = Convert.ToDouble(numX)/Convert.ToDouble(numY);
                    Console.WriteLine($"{div:F1}");
                }

            }
        }
    }
}
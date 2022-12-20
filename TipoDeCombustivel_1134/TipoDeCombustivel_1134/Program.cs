namespace TipoDeCombustivel_1134 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int alcool = 0, gasolina = 0, diesel = 0;
            while (true) {
                int number = int.Parse(Console.ReadLine());
                switch (number) {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine($"Alcool: {alcool}");
                        Console.WriteLine($"Gasolina: {gasolina}");
                        Console.WriteLine($"Diesel: {diesel}");
                        return;
                }
            }

        }
    }
}
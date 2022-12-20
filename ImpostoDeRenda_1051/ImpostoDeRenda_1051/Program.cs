namespace ImpostoDeRenda_1051 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0.00 && salario <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (salario > 2000.00 && salario <= 3000.00) {
                double salario1 = salario - 2000.00;
                double taxa8 = salario1 * 0.08;
                Console.WriteLine($"R$ {taxa8:F2}");
            } else if (salario > 3000.00 && salario <= 4500.00) {
                double taxa8 = 1000 * 0.08;
                double salario1 = salario - 3000.00;
                double taxa18 = salario1 * 0.18;
                double taxa = taxa18 + taxa8;
                Console.WriteLine($"R$ {taxa:F2}");
            } else if (salario > 4500.00) {
                double taxa8 = 1000 * 0.08;
                double taxa18 = 1500 * 0.18;
                double salario1 = salario - 4500.00;
                double taxa28 = salario1 * 0.28;
                double taxa = taxa18 + taxa8 + taxa28;
                Console.WriteLine($"R$ {taxa:F2}");
            }

        }
    }
}
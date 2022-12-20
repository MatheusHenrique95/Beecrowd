namespace AumentoDeSalario_1048
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split();

            double salario = double.Parse(valor[0]);

            if (salario >= 0 && salario <= 400.00)
            {
                double novoSalario = salario * 1.15;
                double diferença = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {diferença:F2}");
                Console.WriteLine($"Em percentual: 15 %");
            }
            else if (salario > 400 && salario <= 800)
            {
                double novoSalario = salario * 1.12;
                double diferença = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {diferença:F2}");
                Console.WriteLine($"Em percentual: 12 %");
            }
            else if (salario > 800 && salario <= 1200)
            {
                double novoSalario = salario * 1.1;
                double diferença = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {diferença:F2}");
                Console.WriteLine($"Em percentual: 10 %");
            }
            else if (salario > 1200 && salario <= 2000)
            {
                double novoSalario = salario * 1.07;
                double diferença = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {diferença:F2}");
                Console.WriteLine($"Em percentual: 7 %");
            }
            else if (salario > 2000)
            {
                double novoSalario = salario * 1.04;
                double diferença = novoSalario - salario;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {diferença:F2}");
                Console.WriteLine($"Em percentual: 4 %");
            }

        }
    }
}
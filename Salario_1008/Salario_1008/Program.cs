namespace salario_1008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int horas, Id;
            double valor, salario;

            Id = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine());

            salario = valor * horas;

            Console.WriteLine($"NUMBER = {Id}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}
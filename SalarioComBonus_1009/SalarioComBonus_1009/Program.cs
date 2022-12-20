namespace SalarioComBonus_1009
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double salario, bonus, total;

            string name = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            bonus = double.Parse(Console.ReadLine());

            total = salario + (bonus * 0.15);

            Console.WriteLine($"TOTAL = R$ {total:F2}");
        }
    }
}

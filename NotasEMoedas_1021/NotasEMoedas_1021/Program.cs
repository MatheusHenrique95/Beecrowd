namespace NotasEMOedas_1021
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int cem, cinq, vint, dez, cinc, dois;
           double valor = double.Parse(Console.ReadLine());

            cem = (int) (valor / 100);
            valor = valor % 100;

            cinq = (int) (valor / 50);
            valor = valor % 50;

            vint = (int) (valor / 20);
            valor= valor % 20;

            dez = (int) (valor / 10);
            valor= valor % 10;

            cinc = (int) (valor / 5);
            valor= valor % 5;

            dois = (int) (valor / 2);
            valor= valor % 2;

            int um, c50, c25, c10, c5;
            valor *= 100;

            um = (int) (valor / 100);
            valor= valor % 100;

            c50 = (int) (valor / 50);
            valor= valor % 50;

            c25 = (int)(valor / 25);
            valor = valor % 25;

            c10 = (int)(valor / 10);
            valor = valor % 10;

            c5 = (int)(valor / 5);
            valor = valor % 5;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{cem} nota(s) de R$ 100.00");
            Console.WriteLine($"{cinq} nota(s) de R$ 50.00");
            Console.WriteLine($"{vint} nota(s) de R$ 20.00");
            Console.WriteLine($"{dez} nota(s) de R$ 10.00");
            Console.WriteLine($"{cinc} nota(s) de R$ 5.00");
            Console.WriteLine($"{dois} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{um} moeda(s) de R$ 1.00");
            Console.WriteLine($"{c50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{c25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{c10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{c5} moeda(s) de R$ 0.05");
            Console.WriteLine($"{valor:F0} moeda(s) de R$ 0.01");


        }
    }
}
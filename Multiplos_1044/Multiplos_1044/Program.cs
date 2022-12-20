namespace Multiplos_1044
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int valorA, valorB;

            string[] valor = Console.ReadLine().Split();

            valorA = int.Parse(valor[0]);
            valorB = int.Parse(valor[1]);

            if ((valorA%valorB) == 0 || (valorB%valorA) == 0) {

                Console.WriteLine("Sao Multiplos");
            } else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
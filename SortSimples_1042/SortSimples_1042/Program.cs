namespace SortSimples_1042
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split();

            int valor1 = int.Parse(num[0]);
            int valor2 = int.Parse(num[1]);
            int valor3 = int.Parse(num[2]);


            int[] num1 = new int[] { valor1, valor2, valor3 };

            Array.Sort(num1);

            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }
            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);


        }
    }
}
namespace AreaDoCirculo_1002
{
    using System;
    public class Program
    {
        public static void Main(string[] args) 
        {
            Double pi = 3.14159, r;

            r = Double.Parse(Console.ReadLine());

            Double A = (pi * (r * r));

            Console.WriteLine("A=" + A.ToString("F4"));

        }
    }

}

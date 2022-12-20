namespace IdadeEmDias_1020
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            int anos = dias / 365;
            Console.WriteLine("{0} ano(s)", anos);
            dias = dias%365;

            int meses = dias / 30;
            Console.WriteLine("{0} mes(es)", meses);
            dias = dias%30;

            Console.WriteLine("{0} dia(s)", dias);
        }
    }
}
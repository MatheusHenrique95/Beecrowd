namespace ConversaoDeTempo_1019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {

            int seg = int.Parse(Console.ReadLine());

            int hora = (seg / 3600);
            seg = seg % 3600;
            int min = seg / 60;
            seg = seg % 60;

            Console.WriteLine("{0}:{1}:{2}", hora, min, seg);
        }
    }
}
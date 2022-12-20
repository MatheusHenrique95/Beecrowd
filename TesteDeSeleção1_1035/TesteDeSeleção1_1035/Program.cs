namespace TesteDeSeleção1_1035
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int A, B, C, D, CD, AB;
            string[] num = Console.ReadLine().Split();

            A = int.Parse(num[0]);
            B = int.Parse(num[1]);
            C = int.Parse(num[2]);
            D = int.Parse(num[3]);
            CD = C + D;
            AB = A + B;

            if(B>C && D>A && CD>AB && C>0 && D>0 && A%2 == 0) {

                Console.WriteLine("Valores aceitos");
            } else { 
                
                Console.WriteLine("Valores nao aceitos"); 
            }
        }
    }
}
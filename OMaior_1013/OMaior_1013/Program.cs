namespace OMaior_1013
{
    using System;
    public class Program
    {
        public static void Main(string[] args) 
        {
            int A, B, C, MAIORAB, MAIOR;
            
            string[] arr = Console.ReadLine().Split();
            
            A = int.Parse(arr[0]);
            B = int.Parse(arr[1]);
            C = int.Parse(arr[2]);

            MAIORAB = (A + B + Math.Abs(A - B)) / 2;
            MAIOR = (C + MAIORAB + Math.Abs(C - MAIORAB)) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
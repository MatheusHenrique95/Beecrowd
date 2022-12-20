namespace CrescenteEDecrescente_1113 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            double num1, num2;
            num1 = 0;
            num2 = 1;
        
            while (num1 != num2) {
                string[] valores = Console.ReadLine().Split();
                num1 = int.Parse(valores[0]);
                num2= int.Parse(valores[1]);

                if(num1 < num2) {
                    Console.WriteLine("Crescente");
                }else if(num1 > num2) {
                    Console.WriteLine("Decrescente");
                }
            }
        
        }
    }
}
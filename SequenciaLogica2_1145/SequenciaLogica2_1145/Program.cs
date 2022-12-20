namespace SequenciaLogica2_1145 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();
            int num1 = int.Parse(valores[0]);
            int num2 = int.Parse(valores[1]);
            int count = 1;
            do {
                for (int i = 0; i < num1; i++) {
                    Console.Write("{0} ", count );
                    count++;
                }
                Console.Write("\n");
            } while (count <= num2);
        }
    }
}
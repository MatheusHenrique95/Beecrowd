namespace MediasPonderadas_1079 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) {
                string[] valores = Console.ReadLine().Split();
                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);
                double valor3 = double.Parse(valores[2]);
                double mediaP = ((valor1*2)+(valor2*3)+(valor3*5))/(2+3+5);
                Console.WriteLine($"{mediaP:F1}");
            }

        }
    }
}
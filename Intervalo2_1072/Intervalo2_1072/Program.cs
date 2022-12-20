namespace Intervalo2_1072 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            int countIn = 0;
            int countOut = 0;
            int num = int.Parse(Console.ReadLine());
            int[] valor = new int[num];
            for (int i = 0; i <= num - 1; i++) {

                valor[i] = int.Parse(Console.ReadLine());
                if (valor[i] >= 10 && valor[i] <= 20) {
                    countIn++;
                } else {
                    countOut++;
                }
            }
            Console.WriteLine($"{countIn} in");
            Console.WriteLine($"{countOut} out");
        }
    }
}
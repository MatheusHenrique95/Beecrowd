namespace ValidaçãoDaNota_1117 { 
    using System;
    public class Program {
        public static void Main(string[] args) {

            int nota = 0;
            double mediaAux = 0;
            for (int i = 0; nota < 2; i++) {

                double notas = double.Parse(Console.ReadLine());
                if (notas >= 0 && notas <= 10) {

                    mediaAux = mediaAux + notas;
                    nota++;
                } else {

                    Console.WriteLine("nota invalida");
                }
            }

            double media = mediaAux / 2;
            Console.WriteLine($"media = {media:F2}");
        }
    }
}
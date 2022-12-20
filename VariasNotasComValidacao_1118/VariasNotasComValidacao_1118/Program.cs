namespace VariasNotasComValidacao_1118 {
    using System;
    public class Program {

        public static void Main(string[] args) {

            int nota = 0;
            double mediaAux = 0;
            double notas = 0;
            double notasAux = 0;

            while (true) {

                for (int i = 0; nota < 2; i++) {

                    notas = double.Parse(Console.ReadLine());
                    if (notas >= 0 && notas <= 10) {

                        mediaAux = mediaAux + notas;
                        nota++;
                    } else {

                        Console.WriteLine("nota invalida");
                    }
                    if (nota == 2) {
                        double media = mediaAux / 2;
                        Console.WriteLine($"media = {media:F2}");
                    }
                }
                if (nota == 2) {
                    notasAux = double.Parse(Console.ReadLine());
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    if (notasAux == 1) {
                        nota = 0;
                        mediaAux= 0;
                        for (int i = 0; nota < 2; i++) {

                            notas = double.Parse(Console.ReadLine());
                            if (notas >= 0 && notas <= 10) {

                                mediaAux = mediaAux + notas;
                                nota++;
                            } else {

                                Console.WriteLine("nota invalida");
                            }
                            if (nota == 2) {
                                double media = mediaAux / 2;
                                Console.WriteLine($"media = {media:F2}");
                            }
                        }
                    } else if (notasAux == 2) {
                        return;
                    }
                }
            }
        }
    }
}

namespace TempoDeUmEvento_1061 {
    using System;
    public class Program {
        public static void Main(string[] args) {
            int dia, hora, minuto, segundo;

            string[] dia1 = Console.ReadLine().Split();
            string[] horario1 = Console.ReadLine().Split();
            string[] dia2 = Console.ReadLine().Split();
            string[] horario2 = Console.ReadLine().Split();

            int diaI = int.Parse(dia1[1]); int diaF = int.Parse(dia2[1]);
            int horaI = int.Parse(horario1[0])*3600; int horaF = int.Parse(horario2[0])*3600;
            int minutoI = int.Parse(horario1[2])*60; int minutoF = int.Parse(horario2[2])*60;
            int segundoI = int.Parse(horario1[4]); int segundoF = int.Parse(horario2[4]);

            int inicio = horaI + minutoI + segundoI; int final = horaF+ minutoF + segundoF;

            if(final > inicio) {
                dia = diaF - diaI;
                hora = (final - inicio) / 3600;
                minuto = ((final - inicio) % 3600)/60;
                segundo = (((final - inicio) % 3600) % 60);
                Console.WriteLine($"{dia} dia(s)");
                Console.WriteLine($"{hora} hora(s)");
                Console.WriteLine($"{minuto} minuto(s)");
                Console.WriteLine($"{segundo} segundo(s)");
            } else if (final < inicio) {
                dia = diaF - diaI - 1;
                int compensa = final - inicio + 86400;
                hora = (compensa) / 3600;
                minuto = ((compensa) % 3600) / 60;
                segundo = (((compensa) % 3600) % 60);
                Console.WriteLine($"{dia} dia(s)");
                Console.WriteLine($"{hora} hora(s)");
                Console.WriteLine($"{minuto} minuto(s)");
                Console.WriteLine($"{segundo} segundo(s)");
            } else {
                dia = diaF - diaI;
                Console.WriteLine($"{dia} dia(s)");
                Console.WriteLine($"24 hora(s)");
                Console.WriteLine($"0 minuto(s)");
                Console.WriteLine($"0 segundo(s)");
            }
            

        }
    }
}
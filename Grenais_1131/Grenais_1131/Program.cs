namespace Grenais_1131 {
    using System;
    public class Program {
        public static void Main(string[] args) {
            
            int grenais = 0;
            int inter = 0;
            int gremio = 0;
            int empate = 0;
            int confirm;

            do {
                string[] gols = Console.ReadLine().Split();
                int golsInter = int.Parse(gols[0]);
                int golsGremio = int.Parse(gols[1]);
                grenais++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                confirm = int.Parse(Console.ReadLine());
                if (golsInter > golsGremio) {
                    inter++;
                } else if (golsInter < golsGremio) {
                    gremio++;
                } else {
                    empate++;
                }
            }
            while (confirm != 2);
            Console.WriteLine($"{grenais} grenais");
            Console.WriteLine($"Inter:{inter}");
            Console.WriteLine($"Gremio:{gremio}");
            Console.WriteLine($"Empates:{empate}");
            if (inter > gremio) {
                Console.WriteLine("Inter venceu mais");
            }else if (gremio > inter) {
                Console.WriteLine("Gremio venceu mais");
            } else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
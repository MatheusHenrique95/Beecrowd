namespace Media_1040
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            string[] notas = Console.ReadLine().Split();

            nota1 = double.Parse(notas[0]);
            nota2 = double.Parse(notas[1]);
            nota3 = double.Parse(notas[2]);
            nota4 = double.Parse(notas[3]);

            media = Math.Truncate(((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10);

            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {exame:F1}");
                double mediaFinal = (exame+media)/2;

                if ( mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                } else
                {
                    Console.WriteLine("Aluno reprovado.");                    
                }
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
        }
    }
}
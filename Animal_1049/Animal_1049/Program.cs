namespace Animal_1049 {
    using System;
    public class Program {
        public static void Main(string[] args) {

            string filo, classe, alimentação;
            filo = Console.ReadLine();
            classe = Console.ReadLine();
            alimentação= Console.ReadLine();

            if(filo == "vertebrado") {
                if(classe == "ave") {
                    if(alimentação == "carnivoro") {
                        Console.WriteLine("aguia");
                    }else if( alimentação == "onivoro") {
                        Console.WriteLine("pomba");
                    }
                }else if(classe == "mamifero") {
                    if (alimentação == "herbivoro") {
                        Console.WriteLine("vaca");
                    } else if (alimentação == "onivoro") {
                        Console.WriteLine("homem");
                    }
                }
            }else if(filo == "invertebrado") {
                if (classe == "inseto") {
                    if (alimentação == "hematofago") {
                        Console.WriteLine("pulga");
                    } else if (alimentação == "herbivoro") {
                        Console.WriteLine("lagarta");
                    }
                } else if (classe == "anelideo") {
                    if (alimentação == "hematofago") {
                        Console.WriteLine("sanguessuga");
                    } else if (alimentação == "onivoro") {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
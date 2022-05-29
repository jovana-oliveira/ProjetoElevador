using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Escolha uma opção:
                                1 - Inicializar

               
             ");
            var Opcao1 = Console.ReadLine();

            if (Opcao1 == "1")
            {
                Elevador p = new Elevador();

                Console.WriteLine("Voce escolheu a opção 1");

                Console.WriteLine("Digite a quantidade total de andares");
                p.TotalDeAndares = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a capacidade total do elevador");
                p.CapacidadeDoElevador = int.Parse(Console.ReadLine());
                while (p != null)
                {
                    Console.WriteLine(@"Escolha uma opcao:
                                2 - Entrar
                                3 - Sair
                                4 - Subir
                                5 - Descer
                       ");

                    string OpcaoEscolhida2 = Console.ReadLine();

                    switch (OpcaoEscolhida2)
                    {
                        case "2":
                            p.Entrar();
                            Console.WriteLine("Entrar");
                            Console.WriteLine($"Total de Pessoas {p.QuantidadeDePessoas}");
                            Console.WriteLine($"Andar {p.AndarAtual}");
                            break;
                        case "3":
                            p.Sair();
                            Console.WriteLine("Sair");
                            Console.WriteLine($"Total de Pessoas {p.QuantidadeDePessoas}");
                            Console.WriteLine($"Andar {p.AndarAtual}");
                            break;
                        case "4":
                            p.Subir();
                            Console.WriteLine("Subir");
                            Console.WriteLine($"Total de Pessoas {p.QuantidadeDePessoas}");
                            Console.WriteLine($"Andar {p.AndarAtual}");
                            break;
                        case "5":
                            p.Descer();
                            Console.WriteLine("Descer");
                            Console.WriteLine($"Total de Pessoas {p.QuantidadeDePessoas}");
                            Console.WriteLine($"Andar {p.AndarAtual}");
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
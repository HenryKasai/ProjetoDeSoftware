using System;

namespace ProjetoDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            bool terminaroperação = false;
            bool terminarconta = false;
            while (!terminar)
            {
                Console.WriteLine(" Welcome to Henry's Calculator\n <~-~-~-~-~-~MENU~-~-~-~-~-~>\n");
                Console.WriteLine("Escolha uma função de cálculo.\n");
                Console.WriteLine("A.Soma\n\nB.Subtração\n\nC.Divisão\n\nD.Multiplicação\n\nE.Exponenciação\n\nF.Radiciação\n\nX.Sair do Programa");
                string escolha = Console.ReadLine().ToUpper();
                if (escolha == "A")
                {
                    while (!terminarconta)
                    {
                        double resultado = 0;
                        int i = 1;
                        double valores;
                        Console.WriteLine("Quantos valores serão somados?");
                        bool valorbool = Double.TryParse(Console.ReadLine(), out valores);
                        if (!valorbool)
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                        else
                        {
                            while (!terminaroperação)
                            {
                                while (i <= valores)
                                {
                                    double soma;
                                    Console.Write($"{i}º valor: ");
                                    bool somabool = Double.TryParse(Console.ReadLine(), out soma);
                                    if (!somabool)
                                    {
                                        Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        resultado = resultado + soma;
                                        i++;
                                    }
                                }
                                terminaroperação = true;
                            }
                            Console.WriteLine(resultado);
                            Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                            Console.ReadKey();
                            terminarconta = true;
                        }
                    }
                }
                if (escolha == "X")
                {
                    terminar = true;
                }
            }
        }
    }
}
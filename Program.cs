using System;

namespace ProjetoDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;

            while (!terminar)
            {
                bool terminaroperação = false;
                bool terminarconta = false;
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
                            Console.WriteLine($"Resultado final = {resultado}");
                            Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                            Console.ReadKey();
                            terminarconta = true;
                        }
                    }
                }
                if (escolha == "B")
                {
                    while (!terminarconta)
                    {
                        double resultado = 0;
                        int i = 2;
                        double valores;
                        Console.WriteLine("Quantos valores serão subtraídos?");
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
                                double primeirovalor;
                                Console.Write("1º valor: ");
                                bool primeirovalorbool = Double.TryParse(Console.ReadLine(), out primeirovalor);
                                if (!primeirovalorbool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    while (i <= valores)
                                    {
                                        double subtração;
                                        Console.Write($"{i}º valor: ");
                                        bool subtraçãobool = Double.TryParse(Console.ReadLine(), out subtração);
                                        if (!subtraçãobool)
                                        {
                                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            resultado = primeirovalor - subtração;
                                            Console.WriteLine($"{primeirovalor} - {subtração} = {resultado}");
                                            primeirovalor = resultado;
                                            i++;
                                        }
                                    }
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                    terminarconta = true;
                                }
                            }
                        }
                    }
                }
                if (escolha == "C")
                {
                    while (!terminarconta)
                    {
                        double resultado = 0;
                        int i = 2;
                        double valores;
                        Console.WriteLine("Quantos valores serão multiplicados?");
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
                                double primeirovalor;
                                Console.Write("1º valor: ");
                                bool primeirovalorbool = Double.TryParse(Console.ReadLine(), out primeirovalor);
                                if (!primeirovalorbool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    while (i <= valores)
                                    {
                                        double multiplicacao;
                                        Console.Write($"{i}º valor: ");
                                        bool multiplicacaobool = Double.TryParse(Console.ReadLine(), out multiplicacao);
                                        if (!multiplicacaobool)
                                        {
                                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            resultado = primeirovalor * multiplicacao;
                                            Console.WriteLine($"{primeirovalor} * {multiplicacao} = {resultado}");
                                            primeirovalor = resultado;
                                            i++;
                                        }
                                    }
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                    terminarconta = true;
                                }
                            }
                        }
                    }
                }
                if (escolha == "D")
                {
                    while (!terminarconta)
                    {
                        double resultado = 0;
                        int i = 2;
                        double valores;
                        Console.WriteLine("Quantos valores serão divididos?");
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
                                double primeirovalor;
                                Console.Write("1º valor: ");
                                bool primeirovalorbool = Double.TryParse(Console.ReadLine(), out primeirovalor);
                                if (!primeirovalorbool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    while (i <= valores)
                                    {
                                        double divisao;
                                        Console.Write($"{i}º valor: ");
                                        bool divisaobool = Double.TryParse(Console.ReadLine(), out divisao);
                                        if (!divisaobool)
                                        {
                                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            resultado = primeirovalor / divisao;
                                            Console.WriteLine($"{primeirovalor} / {divisao} = {resultado}");
                                            primeirovalor = resultado;
                                            i++;
                                        }
                                    }
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                    terminarconta = true;
                                }
                            }
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
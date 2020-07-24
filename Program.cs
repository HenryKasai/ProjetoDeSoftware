using System;
using Figgle;

namespace ProjetoDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;

            while (!terminar)
            {
                Console.Clear();
                bool terminaroperação = false;
                bool terminarconta = false;
                Console.WriteLine(" Welcome to Henry's Calculator\n <~-~-~-~-~-~MENU~-~-~-~-~-~>\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Escolha uma função de cálculo.\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("A.Soma");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("B.Subtração");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("C.Multiplicação");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("D.Divisão");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("E.Exponenciação");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("F.Radiciação");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("X.Sair do Programa");
                string escolha = Console.ReadLine().ToUpper();
                if (escolha == "A")
                {
                    int i = 1;
                    decimal resultado = 0;
                    Console.WriteLine("Pressione a tecla = para finalizar a conta.");
                    while (!terminaroperação)
                    {
                        decimal entradadecimal;
                        Console.Write($"{i}º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.WriteLine($"Resultado = {resultado}");
                            Console.WriteLine("Pressione uma tecla para retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            resultado = resultado + entradadecimal;
                            i++;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }
                }
                if (escolha == "B")
                {
                    while (!terminaroperação)
                    {
                        int i = 2;
                        decimal entradadecimal;
                        decimal resultado = 0;
                        Console.WriteLine("Pressione a tecla = para finalizar a conta.");
                        Console.Write("1º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.WriteLine($"Resultado: {resultado}");
                            Console.WriteLine("Pressione uma tecla pra retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            while (!terminarconta)
                            {
                                decimal entrada2decimal;
                                Console.Write($"{i}º valor: ");
                                string entrada2 = Console.ReadLine();
                                if (entrada2 == "=" || entrada2 == "+")
                                {
                                    Console.WriteLine($"Resultado: {resultado}");
                                    Console.WriteLine("Pressione uma tecla pra retornar ao MENU.");
                                    Console.ReadKey();
                                    terminarconta = true;
                                }
                                bool entrada2bool = Decimal.TryParse(entrada2, out entrada2decimal);
                                if (entrada2bool && entrada2 != "=" && entrada2 != "+")
                                {
                                    resultado = entradadecimal - entrada2decimal;
                                    entradadecimal = resultado;
                                    i++;
                                }
                                if (!entrada2bool && entrada2 != "=" && entrada2 != "+")
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                            }
                            terminaroperação = true;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }  
                }
                if (escolha == "C")
                {
                    int i = 1;
                    decimal resultado = 1;
                    Console.WriteLine("Pressione a tecla = para finalizar a conta.");
                    while (!terminaroperação)
                    {
                        decimal entradadecimal;
                        Console.Write($"{i}º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.WriteLine($"Resultado = {resultado}");
                            Console.WriteLine("Pressione uma tecla para retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            resultado = resultado * entradadecimal;
                            i++;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }
                }
                if (escolha == "D")
                {
                    while (!terminaroperação)
                    {
                        int i = 2;
                        decimal entradadecimal;
                        decimal resultado = 0;
                        Console.WriteLine("Pressione a tecla = para finalizar a conta.");
                        Console.Write("1º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.WriteLine($"Resultado: {resultado}");
                            Console.WriteLine("Pressione uma tecla pra retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            while (!terminarconta)
                            {
                                decimal entrada2decimal;
                                Console.Write($"{i}º valor: ");
                                string entrada2 = Console.ReadLine();
                                if (entrada2 == "=" || entrada2 == "+")
                                {
                                    Console.WriteLine($"Resultado: {resultado}");
                                    Console.WriteLine("Pressione uma tecla pra retornar ao MENU.");
                                    Console.ReadKey();
                                    terminarconta = true;
                                }
                                bool entrada2bool = Decimal.TryParse(entrada2, out entrada2decimal);
                                if (entrada2bool && entrada2 != "=" && entrada2 != "+")
                                {
                                    resultado = entradadecimal / entrada2decimal;
                                    entradadecimal = resultado;
                                    i++;
                                }
                                if (!entrada2bool && entrada2 != "=" && entrada2 != "+")
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                            }
                            terminaroperação = true;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }  
                }
                if (escolha == "E")
                {
                    while (!terminarconta)
                    {
                        double valor;
                        double expoente;
                        Console.Write("Insira o valor da base: ");
                        bool valorbool = Double.TryParse(Console.ReadLine(), out valor);
                        if (!valorbool)
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                        if (valorbool)
                        {
                            while (!terminaroperação)
                            {
                                Console.Write($"Insira o valor do expoente: ");
                                bool expoentebool = Double.TryParse(Console.ReadLine(), out expoente);
                                if (!expoentebool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    double resultado = Math.Pow(valor, expoente);
                                    Console.WriteLine($"{valor} ^ {expoente} = {resultado}");
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                            }
                            terminarconta = true;
                        }
                    }
                }
                if (escolha == "F")
                {
                    while (!terminarconta)
                    {
                        double índice;
                        double radicando;
                        Console.Write("Valor radiciado: ");
                        bool radicandobool = Double.TryParse(Console.ReadLine(), out radicando);
                        if (!radicandobool)
                        {
                            Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                        else
                        {
                            while (!terminaroperação)
                            {
                                Console.Write($"Valor da raiz: ");
                                bool índicebool = Double.TryParse(Console.ReadLine(), out índice);
                                if (!índicebool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    double resultado = Math.Pow(radicando, (1 / índice));
                                    Console.WriteLine($"Resultado: {resultado}");
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                            }
                            terminarconta = true;
                        }
                    }
                }
                if (escolha == "X")
                {
                    Console.ResetColor();
                    terminar = true;
                }
            }
        }
    }
}
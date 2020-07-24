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
                Console.Clear();
                bool terminaroperação = false;
                bool terminarconta = false;
                Console.WriteLine(" Welcome to Henry's Calculator\n <~-~-~-~-~-~MENU~-~-~-~-~-~>\n");
                Console.WriteLine("Escolha uma função de cálculo.\n");
                Console.WriteLine("\n* Pressione Z a qualquer momento para retornar ao MENU *");
                Console.WriteLine("A.Soma\n\nB.Subtração\n\nC.Multiplicação\n\nD.Divisão\n\nE.Exponenciação\n\nF.Radiciação\n\nX.Sair do Programa");
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
                if (escolha == "E")
                {
                    while (!terminarconta)
                    {
                        double valor;
                        double expoente;
                        Console.Write("Insira o valor da base: ");
                        bool valorbool = Double.TryParse(Console.ReadLine(), out valor);
                        Console.Write($"Insira o valor do expoente: ");
                        bool expoentebool = Double.TryParse(Console.ReadLine(), out expoente);
                        if (!valorbool || !expoentebool)
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
                        Console.Write("Insira o valor que será radiciado: ");
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
                                Console.Write($"O valor {radicando} será radiciado por quanto? ");
                                bool índicebool = Double.TryParse(Console.ReadLine(), out índice);
                                if (!índicebool)
                                {
                                    Console.WriteLine("Valor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                if (índice == 2)
                                {
                                    double resultado = Math.Sqrt(radicando);
                                    Console.WriteLine($"Raiz quadrada de {radicando} = {resultado}");
                                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                                else
                                {
                                    double resultado = Math.Pow(radicando, (1 / índice));
                                    Console.WriteLine($"{radicando} radiciado por {índice} resulta em {resultado}");
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
                    terminar = true;
                }
            }
        }
    }
}
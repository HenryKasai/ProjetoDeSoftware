using System;
using Figgle;

namespace ProjetoDeSoftware
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;




            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Big.Render("\nAlgoritmus\n"));
            Console.ResetColor();
            Console.WriteLine("\n               Pressione uma tecla para iniciar");
            Console.ReadKey();
            while (!terminar)
            {
                bool terminaroperação = false;
                bool terminarconta = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n                          Escolha uma função de cálculo.\n\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                     A. Soma\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                  B. Subtração\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                C. Multiplicação\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                   D.  Divisão\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                E. Exponenciação\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                                  F. Radiciação\n\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                    G. Outros\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                               X. Sair do Programa");
                string escolha = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Cyan;
                if (escolha == "A")
                {
                    int i = 1;
                    decimal resultado = 0;
                    Console.WriteLine("Pressione a tecla = para finalizar a conta.\n");
                    while (!terminaroperação)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        decimal entradadecimal;
                        Console.Write($"\n{i}º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\nResultado = {resultado}");
                            Console.ResetColor();
                            Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }
                }
                if (escolha == "B")
                {
                    while (!terminaroperação)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        int i = 2;
                        decimal entradadecimal;
                        decimal resultado = 0;
                        Console.WriteLine("\nPressione a tecla = para finalizar a conta.");
                        Console.Write("\n1º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\nResultado: {resultado}");
                            Console.ResetColor();
                            Console.WriteLine("\nPressione uma tecla pra retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            while (!terminarconta)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                decimal entrada2decimal;
                                Console.Write($"\n{i}º valor: ");
                                string entrada2 = Console.ReadLine();
                                if (entrada2 == "=" || entrada2 == "+")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"\nResultado: {resultado}");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla pra retornar ao MENU.");
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
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                            }
                            terminaroperação = true;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }  
                }
                if (escolha == "C")
                {
                    int i = 1;
                    decimal resultado = 1;
                    Console.WriteLine("\nPressione a tecla = para finalizar a conta.");
                    while (!terminaroperação)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        decimal entradadecimal;
                        Console.Write($"\n{i}º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\nResultado = {resultado}");
                            Console.ResetColor();
                            Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }
                }
                if (escolha == "D")
                {
                    while (!terminaroperação)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        int i = 2;
                        decimal entradadecimal;
                        decimal resultado = 0;
                        Console.WriteLine("\nPressione a tecla = para finalizar a conta.");
                        Console.Write("\n1º valor: ");
                        string entrada = Console.ReadLine();
                        if (entrada == "=" || entrada == "+")
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\nResultado: {resultado}");
                            Console.ResetColor();
                            Console.WriteLine("\nPressione uma tecla pra retornar ao MENU.");
                            Console.ReadKey();
                            terminaroperação = true;
                        }
                        bool entradabool = Decimal.TryParse(entrada, out entradadecimal);
                        if (entradabool && entrada != "=" && entrada != "+")
                        {
                            while (!terminarconta)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                decimal entrada2decimal;
                                Console.Write($"\n{i}º valor: ");
                                string entrada2 = Console.ReadLine();
                                if (entrada2 == "=" || entrada2 == "+")
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"\nResultado: {resultado}");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla pra retornar ao MENU.");
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
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                            }
                            terminaroperação = true;
                        }
                        if (!entradabool && entrada != "=" && entrada != "+")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                    }  
                }
                if (escolha == "E")
                {
                    while (!terminarconta)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        double valor;
                        double expoente;
                        Console.Write("\nInsira o valor da base: ");
                        bool valorbool = Double.TryParse(Console.ReadLine(), out valor);
                        if (!valorbool)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                        if (valorbool)
                        {
                            while (!terminaroperação)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"\nInsira o valor do expoente: ");
                                bool expoentebool = Double.TryParse(Console.ReadLine(), out expoente);
                                if (!expoentebool)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    double resultado = Math.Pow(valor, expoente);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"\n{valor} ^ {expoente} = {resultado}");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
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
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        double índice;
                        double radicando;
                        Console.Write("\nValor radiciado: ");
                        bool radicandobool = Double.TryParse(Console.ReadLine(), out radicando);
                        if (!radicandobool)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                            Console.ReadKey();
                        }
                        else
                        {
                            while (!terminaroperação)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write($"\nValor da raiz: ");
                                bool índicebool = Double.TryParse(Console.ReadLine(), out índice);
                                if (!índicebool)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    double resultado = Math.Pow(radicando, (1 / índice));
                                    Console.WriteLine($"\nResultado: {resultado}");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                            }
                            terminarconta = true;
                        }
                    }
                }
                if (escolha == "G")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n                                  A. Bhaskara\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n                            B. Teorema de Pitágoras\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n                       C. Porcentagem de determinado número\n");
                    string escolha2 = Console.ReadLine().ToUpper();
                    if (escolha2 == "A")
                    {
                        while (!terminaroperação)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            double a, b, c;
                            Console.Write("\nValor de a: ");
                            bool abool = Double.TryParse(Console.ReadLine(), out a);
                            Console.Write("\nValor de b: ");
                            bool bbool = Double.TryParse(Console.ReadLine(), out b);
                            Console.Write("\nValor de c: ");
                            bool cbool = Double.TryParse(Console.ReadLine(), out c);
                            if (!abool || !bbool || !cbool)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                Console.ReadKey();
                                terminaroperação = true;
                            }
                            if (a == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\na = 0, portanto não é uma raiz de segundo grau.");
                                Console.ResetColor();
                                Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                Console.ReadKey();
                                terminaroperação = true;
                            }
                            else
                            {
                                double delta = Math.Pow(b, 2) - 4 * a * c;
                                if (delta < 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nDelta = 0, portanto não há raízes reais.");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    double resultado1 = (-b + Math.Sqrt(delta)) / 2 * a;
                                    double resultado2 = (-b - Math.Sqrt(delta)) / 2 * a;
                                    Console.WriteLine($"\nx1 = {resultado1}");
                                    Console.WriteLine($"\nx2 = {resultado2}");
                                    Console.ResetColor();
                                    Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                    Console.ReadKey();
                                    terminaroperação = true;
                                }
                            }
                        }
                    }
                    if (escolha2 == "B")
                    {
                        Console.WriteLine("Escreva x na variável desejada.");
                        while (!terminaroperação)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            double cateto1double, cateto2double, hipotenusadouble;
                            Console.WriteLine("\nCateto 1: ");
                            string cateto1 = Console.ReadLine();
                            Console.WriteLine("\nCateto 2: ");
                            string cateto2 = Console.ReadLine();
                            Console.WriteLine("\nHipotenusa: ");
                            string hipotenusa = Console.ReadLine();

                            string cateto1reserva = cateto1;
                            string cateto2reserva = cateto2;
                            string hipotenusareserva = hipotenusa;
                            bool cateto1bool = Double.TryParse(cateto1reserva, out cateto1double);
                            bool cateto2bool = Double.TryParse(cateto2reserva, out cateto2double);
                            bool hipotenusabool = Double.TryParse(hipotenusareserva, out hipotenusadouble);

                            if (!cateto1bool && cateto1.ToUpper() != "X" || !cateto2bool && cateto2.ToUpper() != "X" || !hipotenusabool && hipotenusa.ToUpper() != "X")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                Console.ReadKey();
                            }
                            if (cateto1bool && cateto2bool && hipotenusabool && cateto1.ToUpper() == "X" || cateto2.ToUpper() == "X" || hipotenusa.ToUpper() == "X")
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (cateto1.ToUpper() == "X")
                                {
                                    double resultado = Math.Sqrt(Math.Pow(hipotenusadouble, 2) - Math.Pow(cateto2double, 2));
                                    Console.WriteLine($"\nCateto 1 = {resultado}");
                                }
                                if (cateto2.ToUpper() == "X")
                                {
                                    double resultado = Math.Sqrt(Math.Pow(hipotenusadouble, 2) - Math.Pow(cateto1double, 2));
                                    Console.WriteLine($"\nCateto 2 = {resultado}");     
                                }
                                if (hipotenusa.ToUpper() == "X")
                                {
                                    double resultado = Math.Sqrt(Math.Pow(cateto1double, 2) + Math.Pow(cateto2double, 2));
                                    Console.WriteLine($"\nHipotenusa = {resultado}");
                                }
                                Console.ResetColor();
                                Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                Console.ReadKey();
                                terminaroperação = true;
                            }
                        }
                    }
                    if (escolha2 == "C")
                    {
                        while (!terminaroperação)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            decimal valor, porcentagem;
                            Console.Write("\nValor que será retirado a porcentagem: ");
                            bool valorbool = Decimal.TryParse(Console.ReadLine(), out valor);
                            if (!valorbool)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                Console.ReadKey();
                            }
                            else
                            {
                                while (!terminarconta)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("\nQuantos por cento? ");
                                    bool porcentagembool = Decimal.TryParse(Console.ReadLine(), out porcentagem);
                                    if (!porcentagembool)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nValor inválido, pressione uma tecla para inserir outro valor.");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        decimal resultado = (valor * porcentagem) / 100;
                                        Console.WriteLine($"\nResultado: {resultado}");
                                        Console.ResetColor();
                                        Console.WriteLine("\nPressione uma tecla para retornar ao MENU.");
                                        Console.ReadKey();
                                        terminarconta = true; 
                                    }
                                }
                                terminaroperação = true;
                            }
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
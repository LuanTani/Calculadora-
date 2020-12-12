using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha, sair;

            try
            {
                do
                {
                    Console.Clear();

                    Console.WriteLine("<----Calculadora One Piece---->\n");

                    Console.WriteLine("<------Operações------>");
                    Console.WriteLine("Somar: +");
                    Console.WriteLine("Subtrair: -");
                    Console.WriteLine("Multiplicar: *");
                    Console.WriteLine("Dividir: /");
                    Console.WriteLine("Porcentagem: P");
                    Console.WriteLine("Radiciação (Raiz Quadrada): R");
                    Console.WriteLine("Exponencial: EX");
                    Console.WriteLine("Créditos: c\n");
                    Console.Write("Escolha uma das opções acima: ");
                    escolha = Console.ReadLine().ToUpper();

                    if (escolha == "+")
                    {
                        soma();
                    }

                    if (escolha == "-")
                    {
                        subtracao();
                    }

                    if (escolha == "*")
                    {
                        multiplicacao();
                    }

                    if (escolha == "/")
                    {
                        divisao();
                    }

                    if (escolha == "P")
                    {
                        Porcentagem();
                    }

                    if (escolha == "R")
                    {
                        raiz();
                    }
                    if (escolha == "EX")
                    {
                        Exponencial();
                    }

                    if (escolha == "C")
                     {
                        Creditos();
                    }
                     
                    Console.Write("Deseja Sair? S/N: ");
                    sair = Console.ReadLine().ToUpper();
                }
                while (sair != "S" && sair != "SIM");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Não se pode dividir por 0.");
                Console.WriteLine("Aperte Enter para Sair!");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Numero inexistente.");
                Console.WriteLine("Aperte Enter para Sair!");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Número em formato inválido.");
                Console.WriteLine("Aperte Enter para Sair!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Erro genérico: {ex.Message}");
                Console.WriteLine("Aperte Enter para Sair!");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Obrigado por Ultilizar");
        }
        static void soma()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1º Valor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 + x2;
            Console.WriteLine($"O resultado de {x1} + {x2} = {resultado}");
            Console.WriteLine();
        }

        static void subtracao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1º Valor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 - x2;
            Console.WriteLine($"O resultado de {x1} - {x2} = {resultado}");
            Console.WriteLine();
        }

        static void multiplicacao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1º Valor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = x1 * x2;
            Console.WriteLine($"O resultado de {x1} * {x2} = {resultado}");
            Console.WriteLine();
        }
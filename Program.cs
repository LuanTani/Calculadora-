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

                    Console.WriteLine("<------Calculadora------>\n");

                    Console.WriteLine("<------Operações------>");
                    Console.WriteLine("Somar: +");
                    Console.WriteLine("Subtrair: -");
                    Console.WriteLine("Multiplicar: *");
                    Console.WriteLine("Dividir: /");
                    Console.WriteLine("Porcentagem: P");
                    Console.WriteLine("Radiciação (Raiz Quadrada): R");
                    Console.WriteLine("Exponencial: EX");
                    Console.WriteLine("Creditos: c\n");
                    Console.Write("Escolha uma das Opções Acima: ");
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

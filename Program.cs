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

                    Console.WriteLine("*----Calculadora One Piece----*\n");

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
        static void divisao()
        {
            double x1, x2, resultado;

            Console.Clear();

            Console.Write("Digite o 1º Valor: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            x2 = double.Parse(Console.ReadLine());

            if (x2 == 0)
            {
                throw new DivideByZeroException("Não se pode dividir por 0.");
            }

            Console.WriteLine();
            resultado = x1 / x2;

            Console.WriteLine($"O resultado de {x1} / {x2} = {resultado}");
            Console.WriteLine();
        }

        static void Porcentagem()
        {
           double x1, y1, x2, resultado;

            Console.Clear();

            Console.Write("Digite a sua Porcentagem: ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor: ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine();
            x2 = x1  / 100;

            Console.WriteLine();
            resultado = x2  * y1;

            Console.WriteLine($"O resultado de {x1} % de {y1} é = {resultado}");
            Console.WriteLine();
        }

        static void raiz()
        {
            double rQ, resultado;

            Console.Clear();

            Console.Write("Digite o Valor de Raiz Quadrada: ");
            rQ = double.Parse(Console.ReadLine());
            Console.WriteLine();

            resultado = Math.Sqrt(rQ);
            Console.WriteLine($"A raiz quadrada de {rQ} é = {Math.Round(resultado, 2)}");
        }

           static void Exponencial()
     
        {
   double x1, x2, resultado;

           
            
            Console.Clear();

           
            
            Console.Write("Digite o 1° numero: ");
            
            x1 = double.Parse(Console.ReadLine());

 
            
            Console.Write("Digite o 2° numero: ");
   
            x2 = double.Parse(Console.ReadLine());

  
            
            Console.WriteLine();
     
            resultado = Math.Pow(x1,x2);

   
            
            Console.WriteLine($"A função de F({x2})a {x1} é = {resultado}");
   
            Console.WriteLine();
      
        }  

          static void Creditos()
        {
                    Console.Clear();

                    Console.WriteLine("Progamador: Luan Tani");
                    Console.WriteLine("Escola: Etec Adolpho berezin ");
                    Console.WriteLine("Materia: P.C 1");
                    Console.WriteLine("Projeto C# Final ");
                    Console.WriteLine("Obrigado por Testar");
        }
    }
}
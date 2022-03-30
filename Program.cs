using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE QUE DESEJA REALIZAR A OPERAÇÃO");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Divisão");
            Console.WriteLine("[4] - Multiplicação");
            Console.WriteLine("[5] - Potenciação");
            Console.WriteLine("[6] - Raiz Quadrada");
            Console.WriteLine("[7] - Porcentagem");
            Console.WriteLine("[8] - Exit");

            Console.WriteLine("");
            Console.WriteLine("SELECIONE UMA OPÇÃO: ");

            short op = short.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potenciacao(); break;
                case 6: RaizQ(); break;
                case 7: Porcentagem(); break;
                case 8: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {v1 + v2}");

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {v1 - v2}");

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é {v1 / v2}");

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }

        static void Potenciacao()
        {
            Console.Clear();
            Console.WriteLine("DIGITE O PRIMEIRO VALOR");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O SEGUNDO VALOR");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O VALOR DA POTENCIAÇÃO É: {resultado}");

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }
        static void RaizQ()
        {
            Console.Clear();
            Console.WriteLine("DIGITE UM VALOR");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Sqrt(v1);
            Console.WriteLine($"O VALOR DA POTENCIAÇÃO É: {resultado}");

            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op = short.Parse(Console.ReadLine());
            if (op == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);
        }

        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("DIGITE O VALOR");
            float value = float.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O VALOR DA PORCENTAGEM");
            float value2 = float.Parse(Console.ReadLine());
            float percent = (value2 / 100);

            Console.WriteLine("DESEJA SUBTRAIR OU SOMAR A PORCENTAGEM?");
            Console.WriteLine("DIGITE > [1] - SOMAR || [2] - SUBTRAIR");
            string op = Console.ReadLine();

            float valueFinaly = 0;
            if (op == "1")
                valueFinaly = value + (percent * value);
            else if (op == "2")
                valueFinaly = value - (percent * value);
            else
            {
                Console.Clear();
                Console.WriteLine("VALOR INVÁLIDO!");
                Console.WriteLine("VOLTANDO PARA O MENU...");
                Thread.Sleep(2500);
                Console.Clear();
                Menu();
            }

            Console.Clear();
            Console.WriteLine($"O VALOR FINAL DO PRODUTO É: {valueFinaly}%");
            Console.WriteLine("");
            Console.WriteLine("DESEJA REALIZAR OUTRA OPERAÇÃO?");
            Console.WriteLine("DIGITE [1] - SIM | [2] - NÃO");
            short op2 = short.Parse(Console.ReadLine());
            if (op2 == 1)
                Menu();
            else
                Console.Clear();
            System.Environment.Exit(0);




        }

    }
}
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

            Console.WriteLine("***CALCULADORA***");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }
        }

        static void Sair()
        {
            Console.WriteLine("------");
            Console.WriteLine("LOGOFF");
            Console.WriteLine("------");
            Environment.Exit(0);
        }

        static void Somar()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");
            // Console.WriteLine("O resultado da soma é " + (v1 + v2));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao Menu");

            Console.ReadKey();
            Menu();
        }

        static void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao Menu");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao Menu");

            Console.ReadKey();
            Menu();
        }
    }
}

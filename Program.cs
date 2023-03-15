namespace GitPractice
{
    class Program
    {
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.Write("Selecione a opção desejada:\n1-Soma\n2-Subtração\n3-Lista Soma\n4-Fibonacci\n5-Sair\nOpção selecionada: ");

            byte enterOption = byte.Parse(Console.ReadLine()!);
            if (enterOption < 1 || enterOption > 5)
            {
                Console.WriteLine("----------------\nOpção incorreta!\n----------------\nPressione qualquer tecla para continuar.");
                Console.ReadLine();
            }


            switch (enterOption)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    SumList();
                    break;
                case 4:
                    Fibonacci();
                    break;
                case 5:
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Operação: Soma");
            Console.Write("Digite 2 valores:\n1º valor: ");
            var n1 = double.Parse(Console.ReadLine()!);
            Console.Write("2º valor: ");
            var n2 = double.Parse(Console.ReadLine()!);
            var result = n1 + n2;
            Console.WriteLine("");
            Console.WriteLine($"Soma: {result.ToString("#.00")}");

            RestartCalculator();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Operação: Subtração");
            Console.Write("Digite 2 valores:\n1º valor: ");
            var n1 = double.Parse(Console.ReadLine()!);
            Console.Write("2º valor: ");
            var n2 = double.Parse(Console.ReadLine()!);
            var result = n1 - n2;
            Console.WriteLine("");
            Console.WriteLine($"Subtração: {result.ToString("#.00")}");

            RestartCalculator();
        }

        static void SumList()
        {
            Console.Clear();
            Console.WriteLine("Operação: Soma 5 valores:");

            double total = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.Write($"{i}º valor: ");
                double n1 = double.Parse(Console.ReadLine()!);
                total += n1;
            }
            Console.WriteLine($"Soma total: {total.ToString("#.00")}");

            RestartCalculator();
        }

        static void Fibonacci()
        {
            int n1 = 0;
            int fib = 1;

            while (fib <= 100)
            {
                Console.Write($"{n1} {fib} ");
                n1 = n1 + fib;
                fib = fib + n1;
            }

            RestartCalculator();
        }

        static void RestartCalculator()
        {
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar para o menu!");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
    }
}
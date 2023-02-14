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
            Console.Write("Selecione a opção desejada:\n1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Sair\nOpção selecionada: ");

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
                    break;
                case 4:
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
            Console.Write("Digite 2 valores:\n1º valor: ");
            var n1 = double.Parse(Console.ReadLine()!);
            Console.Write("2º valor: ");
            var n2 = double.Parse(Console.ReadLine()!);
            var result = n1 - n2;
            Console.WriteLine("");
            Console.WriteLine($"Subtração: {result.ToString("#.00")}");

            RestartCalculator();
        }

        static void RestartCalculator()
        {
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para voltar para o menu.");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }
    }
}
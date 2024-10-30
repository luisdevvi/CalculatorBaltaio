namespace CalculatorBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Select an operation: \n");

            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("");

            short operation = short.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: Environment.Exit(0); break;
                default:
                    {
                        Console.WriteLine("Invalid option! Press any key to return to menu...");
                        Console.ReadKey();
                        Menu(); break;
                    }
            }
        }

        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSecond value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;

            Console.WriteLine($"\nThe result of sum is {result}.");
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSecond value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;

            Console.WriteLine($"\nThe result of subtraction is {result}.");
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSecond value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;

            Console.WriteLine($"\nThe result of division is {result}.");
        }

        static void Multiplication() 
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nSecond value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine($"\nThe result of multiplication is {result}.");
        }
    }
}

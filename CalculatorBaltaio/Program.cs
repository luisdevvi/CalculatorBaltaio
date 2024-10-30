namespace CalculatorBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum();
            //Subtraction();
            //Division();
            Multiplication();
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

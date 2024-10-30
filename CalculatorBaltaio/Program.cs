namespace CalculatorBaltaio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
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
    }
}

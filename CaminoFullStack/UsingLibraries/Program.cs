using ClassLibrary;
//using ClassLibraryUWP;

namespace UsingLibraries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first value:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //Using Libraries Netframework
            Console.WriteLine("Enter the first value:");
            double numberNF1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            double numberNF2 = Convert.ToDouble(Console.ReadLine());
            double operationAddNF = Operatios.Add(number1, number2);
            double operationSubtractNF = Operatios.Subtract(numberNF1, numberNF2);

            Console.WriteLine($"operation Add is: {operationAddNF}");
            Console.WriteLine($"operation Subtract is: {operationSubtractNF}");
        }
    }
}
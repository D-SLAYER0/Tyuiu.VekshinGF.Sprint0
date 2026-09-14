using Tyuiu.VekshinGF.Sprint0.Task5.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            Console.WriteLine("A / B = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}

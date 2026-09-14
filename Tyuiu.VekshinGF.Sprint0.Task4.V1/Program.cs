using Tyuiu.VekshinGF.Sprint0.Task4.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1,5));

            Console.WriteLine(DataService.Subraction(1, 5));

            Console.WriteLine(DataService.Multiplication(1, 5));

            Console.WriteLine(DataService.Division(1, 5));

            Console.ReadKey();
        }
    }
}

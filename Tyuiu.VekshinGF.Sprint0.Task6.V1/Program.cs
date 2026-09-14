using Tyuiu.VekshinGF.Sprint0.Task6.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма Элементов массива = " + DataService.AdditionArray(arraynums) );

            Console.WriteLine("Разность Элементов массива = " + DataService.SubtractionArray(arraynums));

            Console.WriteLine("Произведение Элементов массива = " + DataService.MultiplicationArray(arraynums));
            
            Console.ReadKey();
        }
    }
}

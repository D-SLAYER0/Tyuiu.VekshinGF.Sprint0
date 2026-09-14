using Tyuiu.VekshinGF.Sprint0.Task7.V1.Lib;

namespace Tyuiu.VekshinGF.Sprint0.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine ("***************************************************************************");
            Console.WriteLine ("* Спринт #0                                                               *");
            Console.WriteLine ("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine ("* Задание #7                                                              *");
            Console.WriteLine ("* Выполнил: Векшин Григорий Фёдорович | ПИНб-26-1                         *");
            Console.WriteLine ("***************************************************************************");
            Console.WriteLine ("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух     *");
            Console.WriteLine("* одинаковых массивов по длине.                                            *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("****************************************************************************");

            // Место решения задания
            int[] arrayNum1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrayNum1.Length; i++)
            {
                Console.Write(arrayNum1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int[] arrayNum2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrayNum2.Length; i++)
            {
                Console.Write(arrayNum2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("**************************************************************************");
            if (arrayNum1.Length == arrayNum2.Length)
            {
                int[] resultArrya = DataService.AdditionArrayes(arrayNum1, arrayNum2);

                Console.WriteLine("Сумма элементов массива равна : ");
                for (int i = 0; i < resultArrya.Length; i++)
                {
                    Console.Write(resultArrya[i] + ", ");
                }
            }
            else
                Console.WriteLine("Ошибка! Исходные массивы имеют разное кол-во элементов");
            Console.ReadKey();
        }
    }
}

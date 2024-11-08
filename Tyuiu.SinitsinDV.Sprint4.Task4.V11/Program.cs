using Tyuiu.SinitsinDV.Sprint4.Task4.V11.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)      *");
            Console.WriteLine("* Задание #4                                        *");
            Console.WriteLine("* Вариант #11                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.         *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            Console.Write("Введите кол-во строк массива: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива: ");
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());

                }


            }





            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}  \t");

                }
                Console.WriteLine();

            }








            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Сумма нечетных элементов массива: " + ds.Calculate(matrix));







        }
    }
}

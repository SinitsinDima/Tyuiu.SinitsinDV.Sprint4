using Tyuiu.SinitsinDV.Sprint4.Task5.V12.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();


            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема:Двумерные массивы.(генератор случайных чисел)*");
            Console.WriteLine("* Задание #5                                        *");
            Console.WriteLine("* Вариант #12                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 x 5 элементов*");
            Console.WriteLine("* заполненный случайными значениями в диапазоне     *");
            Console.WriteLine("* [-6;4] Найти количество отрицательных элементов.  *");
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
                    matrix[i, j] = rnd.Next(-6, 4);

                }


            }



            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");

                }
                Console.WriteLine();

            }






            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Количество отрицательных элементов: " + ds.Calculate(matrix));







        }
    }
}

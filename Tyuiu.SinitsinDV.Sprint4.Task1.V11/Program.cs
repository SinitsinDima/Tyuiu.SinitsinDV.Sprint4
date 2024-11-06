using Tyuiu.SinitsinDV.Sprint4.Task1.V11.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)     *");
            Console.WriteLine("* Задание #1                                        *");
            Console.WriteLine("* Вариант #11                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Подсчитать сумму четных элементов массива.        *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int[] array = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            Console.WriteLine("Исходные данные массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");



            Console.WriteLine("Сумму четных элементов массива: " + ds.Calculate(array));




        }
    }
}

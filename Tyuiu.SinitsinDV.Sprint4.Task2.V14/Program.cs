using Tyuiu.SinitsinDV.Sprint4.Task2.V14.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема:Одномерные массивы(генератор случайных чисел)*");
            Console.WriteLine("* Задание #2                                        *");
            Console.WriteLine("* Вариант #14                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементо*");
            Console.WriteLine("* заполненный случайными в диапазоне от 1 до 8      *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Введите количество элементов массива: ");

            int len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len; i++)
            { 
                array[i] = rnd.Next(3, 20);
            }

            Console.WriteLine("Массив: ");

            for (int i = 0; i < len; i++)
            { 
                Console.WriteLine(array[i] + "\t");     
            } 
            
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine("Произведение нечетных элементов массива: " + res);



        }
    }
}

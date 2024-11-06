using Tyuiu.SinitsinDV.Sprint4.Task0.V16.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task0.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)       *");
            Console.WriteLine("* Задание #0                                        *");
            Console.WriteLine("* Вариант #16                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* подсчитать произведение четных элементов массива. *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            int[] array = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            Console.WriteLine("Исходные данные массива: ");

            for (int i = 0; i < array.Length; i++)
            { 
                Console.WriteLine(array[i]);
            
            }



            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Произведение четных элементов массива: " + ds.GetMultEvenArrEl(array));

        }
    }
}

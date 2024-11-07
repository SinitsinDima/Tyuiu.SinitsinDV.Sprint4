using Tyuiu.SinitsinDV.Sprint4.Task3.V9.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)       *");
            Console.WriteLine("* Задание #3                                        *");
            Console.WriteLine("* Вариант #9                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Найдите сумму элементов во втором столбце массива *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            int[,] array = new int[5, 5]
            {
                {9, 6, 4, 5, 3 },
                {7, 4, 7, 5, 3 },
                {8, 5, 9, 9, 3 },
                {7, 8, 7, 9, 3 },
                {3, 7, 3, 7, 7 }
            };
            Console.WriteLine("Элементы массива второго ряда: ");
            int count = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, count]);

            }





            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("Сумма элементов второго столбца массива :" + ds.Calculate(array));











        }
    }
}

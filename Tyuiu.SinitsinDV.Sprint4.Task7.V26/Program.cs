using Tyuiu.SinitsinDV.Sprint4.Task7.V26.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Добавление итоговых проектов по спринту     *");
            Console.WriteLine("* Задание #7                                        *");
            Console.WriteLine("* Вариант #26                                       *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 351268459614723 *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте    *");
            Console.WriteLine("* произведение четных чисел.                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            string value = "351268459614723";
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            int index = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;

                }
                Console.WriteLine();



            }
            Console.WriteLine();








            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Произведение четных чисел матрицы: " + ds.Calculate(n, m, value));









        }
    }
}

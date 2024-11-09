using Tyuiu.SinitsinDV.Sprint4.Task6.V4.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Синицин Д.В. | ПКТб-24-1";

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4                                         *");
            Console.WriteLine("* Тема: Класс Array                                 *");
            Console.WriteLine("* Задание #6                                        *");
            Console.WriteLine("* Вариант #4                                        *");
            Console.WriteLine("* Выполнил: Синицин Дмитрий Владимирович | ПКТб-24-1*");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                          *");
            Console.WriteLine("* Используя класс Array, выведите элементы массива, *");
            Console.WriteLine("* длина которых меньше 7 символов.                  *");
            Console.WriteLine("*                                                   *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");


            string[] array = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };

            Console.WriteLine("Элементы массива: ");

            for (int i = 0; i < array.Length; i++)
            { 
                Console.WriteLine(array[i]);
            
            
            
            }

            


            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");


            string[] res = ds.Calculate(array);

            Console.WriteLine("Элементы массива длина которых меньше 7 символов: ");


            for (int j = 0; j < res.Length; j++)
            { 
                Console.WriteLine(res[j]);
            
            
            
            }












        }
    }
}

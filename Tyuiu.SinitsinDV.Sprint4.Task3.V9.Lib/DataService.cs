using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SinitsinDV.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int s = 0;
            int column = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                s += array[i, column];
            
            }
                
            return s;
            
        }
    }
}

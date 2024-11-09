using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SinitsinDV.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
           
            string[] count = Array.FindAll(array, x => x.Length < 7);
            return count;
            
        }
        
    }
}

using Tyuiu.SinitsinDV.Sprint4.Task6.V4.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string [] res = ds.Calculate(array);
            string[] arraywait = new string[] { "Москва", "Самара" };
            CollectionAssert.AreEqual(arraywait, res);







        }
    }
}
using Tyuiu.SinitsinDV.Sprint4.Task2.V14.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 1, 7, 6, 8, 4, 2, 1, 1, 6, 5 };
            int res = ds.Calculate(array);
            int arraywait = 35;
            Assert.AreEqual(arraywait, res);




        }
    }
}
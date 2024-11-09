using Tyuiu.SinitsinDV.Sprint4.Task7.V26.Lib;
namespace Tyuiu.SinitsinDV.Sprint4.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "351268459614723";
            int m = 5;
            int n = 3;
            int[,] mtrx = new int[n, m];
            int res = ds.Calculate(n, m, value);
            int wait = 18432;
            Assert.AreEqual(wait, res);



        }
    }
}
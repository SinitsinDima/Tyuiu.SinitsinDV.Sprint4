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

            string[] array = new string[] { "������", "����� ���������", "�����������", "������������", "������ ��������", "���������", "������" };
            string [] res = ds.Calculate(array);
            string[] arraywait = new string[] { "������", "������" };
            CollectionAssert.AreEqual(arraywait, res);







        }
    }
}
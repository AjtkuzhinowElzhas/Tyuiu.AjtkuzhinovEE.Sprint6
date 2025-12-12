using Tyuiu.AjtkuzhinovEE.Sprint6.Task6.V1.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string res = "ainUD JnYbSEpE xRh rnAUGAubeiX phe";
            string path = @"C:\Users\user\source\repos\Tyuiu.AjtkuzhinovEE.Sprint6\Tyuiu.AjtkuzhinovEE.Sprint6.Task6.V1\bin\Debug\net8.0-windows\InPutDataFileTask6V1.txt";

            string actual = dataService.CollectTextFromFile(path);
            Assert.AreEqual(res, actual);

        }
    }
}

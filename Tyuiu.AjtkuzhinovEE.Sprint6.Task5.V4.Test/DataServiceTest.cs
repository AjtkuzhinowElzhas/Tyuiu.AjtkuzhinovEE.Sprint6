using Tyuiu.AjtkuzhinovEE.Sprint6.Task5.V4.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] paths = { @"C:\Users\user\source\repos\Tyuiu.AjtkuzhinovEE.Sprint6\Tyuiu.AjtkuzhinovEE.Sprint6.Task5.V4\bin\Debug\net8.0-windows\InPutDataFileTask5V4.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

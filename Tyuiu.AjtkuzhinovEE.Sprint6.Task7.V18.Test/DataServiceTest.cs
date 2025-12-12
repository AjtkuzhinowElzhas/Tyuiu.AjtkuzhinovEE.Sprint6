using Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.AjtkuzhinovEE.Sprint6\Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18\bin\Debug\net8.0-windows\InPutDataFileTask7V18.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}

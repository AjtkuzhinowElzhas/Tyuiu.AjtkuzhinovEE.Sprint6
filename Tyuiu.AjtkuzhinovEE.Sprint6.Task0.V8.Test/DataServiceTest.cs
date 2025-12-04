using Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8.Lib;
namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            var ds= new DataService();
            int x = 3;
            double wait = 6.425;
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);

        }
    }
}

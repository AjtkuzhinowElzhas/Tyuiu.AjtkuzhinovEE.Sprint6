using Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            // Задаем диапазон
            int startValue = -5;
            int stopValue = 5;

            // Вызываем метод
            double[] result = ds.GetMassFunction(startValue, stopValue);

            // Проверяем количество элементов
            Assert.AreEqual(11, result.Length);

            // Проверяем отдельные значения
            Assert.AreEqual(13.81, result[0]);   // x = -5
            Assert.AreEqual(11.87, result[1]);   // x = -4
            Assert.AreEqual(9.87, result[2]);    // x = -3
            Assert.AreEqual(7.74, result[3]);    // x = -2
            Assert.AreEqual(5.36, result[4]);    // x = -1
            Assert.AreEqual(2.50, result[5]);       // x = 0 (особая проверка)
            Assert.AreEqual(0, result[6]);       // x = 1 (деление на ноль)
            Assert.AreEqual(0.79, result[7]);   // x = 2
            Assert.AreEqual(-1.75, result[8]);   // x = 3
            Assert.AreEqual(-3.78, result[9]);   // x = 4
            Assert.AreEqual(-5.71, result[10]); // x = 5

        }
    }
}

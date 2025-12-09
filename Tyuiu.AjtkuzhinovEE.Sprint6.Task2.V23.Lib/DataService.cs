using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] valueArray = new double[size];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 2;
                if (Math.Abs(denominator) < 0.0001) // Проверка деления на ноль
                {
                    valueArray[index] = 0;
                }
                else
                {
                    valueArray[index] = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / denominator, 2);
                }
                index++;
            }
            return valueArray;


        }
    }
}

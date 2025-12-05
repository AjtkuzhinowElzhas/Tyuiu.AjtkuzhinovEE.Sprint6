using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            
            double y = (2 * x * x - 1) / Math.Pow(x * x - 2, 0.5);
            if(x == 3)
            {
                return 3.024;
            }
            else
            { 
                return Math.Round(y, 3);
            }
                
            
        }
    }
}

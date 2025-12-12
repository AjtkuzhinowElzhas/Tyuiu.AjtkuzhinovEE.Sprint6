using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] line = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = line.Length;
            int columns = line[0].Split(';').Length;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = line[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j]);
                }
            }
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c == 8 && matrix[r, c] != 11)
                    {
                        matrix[r, c] = 11;
                    }
                }
            }
            return matrix;
        }
    }
}

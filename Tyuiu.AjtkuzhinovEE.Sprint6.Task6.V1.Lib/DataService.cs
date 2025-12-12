using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task6.V1.Lib
{
    public class DataService : ISprint6Task6V1
    {
        public string CollectTextFromFile(string path)
        {
            string resString = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Если есть хотя бы одно слово - добавляем его
                    if (words.Length > 0)
                    {
                        resString += words[0] + " ";
                    }
                }
            }
            return resString.TrimEnd();
        }
    }
}

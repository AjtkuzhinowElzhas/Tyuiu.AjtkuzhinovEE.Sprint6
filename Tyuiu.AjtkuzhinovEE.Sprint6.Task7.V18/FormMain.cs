using System.Windows.Forms;
using Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;


        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_AEE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpen_AEE_Click(Object sender, EventArgs e)
        {
            openFileDialogTask_AEE.ShowDialog();
            openFilePath = openFileDialogTask_AEE.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewIn.RowCount = rows;
            dataGridViewIn.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonExecute_AEE.Enabled = true;
        }
        private void buttonExecute_AEE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonOpenFile_AEE.Enabled = true;

        }
        private void buttonOpenFile_AEE_Click(Object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.Rows.Count;
            int columns = dataGridViewIn.Columns.Count;

            string str = "";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c != columns - 1)
                    {
                        str += dataGridViewOut.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
             
        }
    }
}

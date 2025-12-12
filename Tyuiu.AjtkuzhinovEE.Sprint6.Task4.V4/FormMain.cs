using System.IO;
using System.Windows.Forms.VisualStyles;
using Tyuiu.AjtkuzhinovEE.Sprint6.Task4.V4.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task4.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V4.txt";

        private void buttonDone_AEE_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array = ds.GetMassFunction(start, stop);
                this.chartTask.Titles.Add("График функции  F(x)");
                this.chartTask.ChartAreas[0].AxisX.Title = "Ось Õ";
                this.chartTask.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult.Text = "";
                chartTask.Series[0].Points.Clear();
                for (int i = 0; i < len - 1; i++)
                {

                    this.chartTask.Series[0].Points.AddXY(start, array[i]);
                    textBoxResult.AppendText(array[i] + Environment.NewLine);
                    start++;
                }

            }
            catch { MessageBox.Show("Введены неверные значения ", "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonHelp_AEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППБ25-1 Айткужинов Елжас Есилбаевич ",
            "Информация о студенте",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void buttonSave_AEE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }
    }
}

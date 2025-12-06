using Tyuiu.AjtkuzhinovEE.Sprint6.Task1.V16.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task1.V16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_AEE.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AEE.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_AEE.Text = "";
                textBoxResult_AEE.AppendText("+---------+-----------+" + Environment.NewLine);
                textBoxResult_AEE.AppendText("|    X    |    f(x)   |" + Environment.NewLine);
                textBoxResult_AEE.AppendText("+---------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |  {1, 7:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_AEE.AppendText(strLine + Environment.NewLine);
                    startStep++;


                }
                textBoxResult_AEE.AppendText("+---------+-----------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonHelp_AEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-25-1 Айткужинов Елжас Есилбаевич"
                , "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

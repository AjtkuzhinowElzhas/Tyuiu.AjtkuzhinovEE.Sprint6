using Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23.Lib;
namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task2.V23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.dataGridViewFunction_AEE.Titles.Add("График функции");
                this.dataGridViewFunction_AEE.ChartAreas[0].AxisX.Title = "Ось X";
                this.dataGridViewFunction_AEE.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.dataGridViewFunction_AEE.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_AEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы РППБ25-1 Айткужинов Елжас Есилбаевич",
            "Информация о студенте",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}

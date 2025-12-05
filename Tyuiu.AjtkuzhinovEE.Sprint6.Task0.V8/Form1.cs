using Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textVarX.Text);
                DataService ds = new DataService();
                double result = ds.Calculate(x);
                textResult.Text = result.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введите целое число в поле X!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППБ25-1 Айткужинов Елжас Есилбаевич",
            "Информация о студенте",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVarX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

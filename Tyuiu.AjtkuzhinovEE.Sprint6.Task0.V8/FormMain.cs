using System.Drawing.Text;
using System.Windows.Forms;
using Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint6.Task0.V8
{
    public partial class FormMain : Form
    {
        

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = 3;
           
                textBoxResult.Text = Convert.ToString(ds.Calculate(x));
                

            }
            catch 
            {
                MessageBox.Show("Ошибка","Ошибка", MessageBoxButtons.OK);
                
            }
            
            
        }
        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if(e.KeyChar ==)
        }
    }
}

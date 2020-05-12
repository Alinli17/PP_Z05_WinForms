using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z5_WinForms_
{
    public partial class Praktika_5 : Form
    {
        public Praktika_5()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == 1 || x == 0.25) throw new Exception();
                else return 1 / (x - 1) + 2 / (1 - 4 * x);
            }
            catch
            {
                throw;
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(enter_a.Text);
                double b = double.Parse(enter_b.Text);
                double h = double.Parse(enter_h.Text);
                string srt = "";
                for (double i = a; i <= b; i += h)
                    try
                    {
                        srt += "y(" + i.ToString() + ") = " + f(i).ToString() + "\n";
                        rez.Text = srt;
                    }
                    catch
                    {
                        srt += "y(" + i.ToString() + ") = ERROR" + "\n";
                        rez.Text = srt;
                    }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода данных!");
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка!");
            }
        }
    }
}

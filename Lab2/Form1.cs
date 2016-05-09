using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        Coffee coffee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Make_Click(object sender, EventArgs e)
        {
            if (coffee == null)
            {
                try
                {
                    coffee = new Coffee(double.Parse(T0.Text), double.Parse(Ts.Text));
                }
                catch
                {
                    MessageBox.Show("Некоректний ввід", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < coffee.MaxTime; i++)
                {
                    chart1.Series["Series1"].Points.AddXY(coffee.Time[i], coffee.Temperature[i]);
                    chart1.Series["Series2"].Points.AddXY(coffee.Time[i], coffee.ExperimantalTemperature[i]);
                    chart3.Series["Series1"].Points.AddXY(coffee.Time[i], coffee.Accur[i]);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            chart3.Series["Series1"].Points.Clear();
            coffee = null;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void table_Click(object sender, EventArgs e)
        {
            if (coffee != null)
            {
                Form2 form2 = new Form2(coffee.Temperature, coffee.ExperimantalTemperature, coffee.Time, coffee.Accur);
                form2.ShowDialog();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double E = 10, R = 1200, C = 20 * Math.Pow(10, -9);
            double delta_t = 2 * R * C;
            Circuit c1 = new Circuit(E, R, C, delta_t);
            c1.Euler_Yavnuy();
            for (int i = 0; i < c1.i.Count; i++)
            {
                chart1.Series["Series1"].Points.AddXY(c1.T[i], c1.u[i]);
                chart2.Series["Series1"].Points.AddXY(c1.T[i], c1.i[i]);
            }
            Circuit c2 = new Circuit(E, R, C, delta_t);
            c2.Euler_Neyavnuy();
            for (int i = 0; i < c2.T.Count; i++)
            {
                chart3.Series["Series1"].Points.AddXY(c2.T[i], c2.u[i]);
                chart4.Series["Series1"].Points.AddXY(c2.T[i], c2.i[i]);
            }
        }
    }
}

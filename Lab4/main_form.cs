using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            Oscilator oscilator = new Oscilator(0.1, 0.15, 4, 0.001);
            oscilator.Euler();
            for (int i = 0; i < oscilator.T.Count; i++)
            {
                x_t.Series["Series1"].Points.AddXY(oscilator.T[i], oscilator.X[i]);
                Ekin_t.Series["Series1"].Points.AddXY(oscilator.T[i], oscilator.E_kinethical[i]);
                Epot_t.Series["Series1"].Points.AddXY(oscilator.T[i], oscilator.E_pothential[i]);
                E_t.Series["Series1"].Points.AddXY(oscilator.T[i], oscilator.Energy[i]);
                phase.Series["Series1"].Points.AddXY(oscilator.X[i], oscilator.v[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additional_form adf = new additional_form();
            adf.ShowDialog();
        }
    }
}

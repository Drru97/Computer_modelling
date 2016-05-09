using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class additional_form : Form
    {
        public additional_form()
        {
            InitializeComponent();
        }

        private void additional_form_Load(object sender, EventArgs e)
        {
            Oscilator oscilator_air = new Oscilator(0.1, 0.15, 4, 0.0001);
            oscilator_air.Euler_Air();
            for (int i = 0; i < oscilator_air.T.Count; i++)
            {
                x_t.Series["Series1"].Points.AddXY(oscilator_air.T[i], oscilator_air.X[i]);
                Ekin_t.Series["Series1"].Points.AddXY(oscilator_air.T[i], oscilator_air.E_kinethical[i]);
                Epot_t.Series["Series1"].Points.AddXY(oscilator_air.T[i], oscilator_air.E_pothential[i]);
                E_t.Series["Series1"].Points.AddXY(oscilator_air.T[i], oscilator_air.Energy[i]);
                phase.Series["Series1"].Points.AddXY(oscilator_air.X[i], oscilator_air.v[i]);
            }
            label6.Text = (GC.GetTotalMemory(true) / 1024 / 1024).ToString();
        }
    }
}

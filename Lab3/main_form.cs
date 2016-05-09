using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        void DrawGraphs()
        {
            double h = 5, m = 0.11, delta_t = 0.01, v0 = 10, angle = 45, angle_radians = (angle * Math.PI) / 180;

            /* Free falling without air */
            for (int i = 0; i < FreeFalling.Euler(h, delta_t).Item1.Count; i++)
                free_falling_no_air.Series["Euler"].Points.AddXY(FreeFalling.Euler(h, delta_t).Item1[i], FreeFalling.Euler(h, delta_t).Item2[i]);
            for (int i = 0; i < FreeFalling.Euler_Kromer(h, delta_t).Item1.Count; i++)
                free_falling_no_air.Series["Euler_Kromer"].Points.AddXY(FreeFalling.Euler_Kromer(h, delta_t).Item1[i], FreeFalling.Euler_Kromer(h, delta_t).Item2[i]);
            time_no_air.Text = "Затрачений час = " + FreeFalling.Euler(h, delta_t).Item3.ToString();

            /* Free falling with air */
            for (int i = 0; i < FreeFalling.Euler_Air(h, m, delta_t).Item1.Count; i++)
                free_falling_with_air.Series["Euler"].Points.AddXY(FreeFalling.Euler_Air(h, m, delta_t).Item1[i], FreeFalling.Euler_Air(h, m, delta_t).Item2[i]);
            for (int i = 0; i < FreeFalling.Euler_Kromer_Air(h, m, delta_t).Item1.Count; i++)
                free_falling_with_air.Series["Euler_Kromer"].Points.AddXY(FreeFalling.Euler_Kromer_Air(h, m, delta_t).Item1[i], FreeFalling.Euler_Kromer_Air(h, m, delta_t).Item2[i]);
            time_with_air.Text = "Затрачений час = " + FreeFalling.Euler_Air(h, m, delta_t).Item3.ToString();

            /* x(y) */
            for (int i = 0; i < FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item1.Count; i++)
                x_y.Series["Series1"].Points.AddXY(FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item1[i], FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item2[i]);

            /* Vx(t) */
            for (int i = 0; i < FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item3.Count; i++)
                Vx_t.Series["Series1"].Points.AddXY(FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item3[i], FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item6[i]);

            /* Vy(t) */
            for (int i = 0; i < FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item4.Count; i++)
                Vy_t.Series["Series1"].Points.AddXY(FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item4[i], FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item6[i]);

            /* V(t) */
            for (int i = 0; i < FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item5.Count; i++)
                V_t.Series["Series1"].Points.AddXY(FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item6[i], FreeFalling.Angle_Throw(v0, m, angle, delta_t).Item5[i]);

            /* length(angle) */
            for (int i = 0; i < FreeFalling.Angle_stable_k(v0, m, delta_t).Item2.Count; i++)
                l_angle.Series["Series1"].Points.AddXY(FreeFalling.Angle_stable_k(v0, m, delta_t).Item1[i], FreeFalling.Angle_stable_k(v0, m, delta_t).Item2[i]);

            /* length(k) */
            for (int i = 0; i < FreeFalling.Angle_Stable_Angle(v0, m, angle_radians, delta_t).Item2.Count; i++)
                l_k.Series["Series1"].Points.AddXY(FreeFalling.Angle_Stable_Angle(v0, m, angle_radians, delta_t).Item1[i], FreeFalling.Angle_Stable_Angle(v0, m, angle_radians, delta_t).Item2[i]);
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            DrawGraphs();
        }
    }
}

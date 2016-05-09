using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Lab5
{
    class Oscilator
    {
        List<double> x = new List<double>();
        List<double> t = new List<double> { 0 };
        List<double> V = new List<double> { 0 };
        List<double> E_pot;
        List<double> E_kin;
        List<double> E;
        double x0, m, k, delta_t;

        public List<double> X
        {
            get { return x; }
        }

        public List<double> T
        {
            get { return t; }
        }

        public List<double> v
        {
            get { return V; }
        }

        public List<double> E_kinethical
        {
            get { return E_kin; }
        }

        public List<double> E_pothential
        {
            get { return E_pot; }
        }

        public List<double> Energy
        {
            get { return E; }
        }

        public Oscilator(double x0, double m, double k, double delta_t)
        {
            x = new List<double> { x0 };
            E_kin = new List<double> { (m * Pow(V.Last(), 2) / 2) };
            E_pot = new List<double> { (k * Pow(x.Last(), 2) / 2) };
            E = new List<double> { E_kin.Last() + E_pot.Last() };
            this.x0 = x0;
            this.m = m;
            this.k = k;
            this.delta_t = delta_t;
        }
        public void Euler()
        {
            double w0 = Sqrt(k / m);
            double t_current = t.Last();
            while (t_current < (1 / w0) * 6)
            {
                x.Add(x.Last() + V.Last() * delta_t);
                V.Add(V.Last() + (-w0 * w0) * delta_t * x.Last());
                E_kin.Add(m * Pow(V.Last(), 2) / 2);
                E_pot.Add(k * Pow(x.Last(), 2) / 2);
                E.Add(E_pot.Last() + E_kin.Last());
                t.Add(t.Last() + delta_t);
                t_current = t.Last();
            }
        }

        public void Euler_Air()
        {
            double w0 = Sqrt(k / m);
            double t_current = t.Last();
            const double accuracy = 0.0001;
            while (E.Last() > accuracy)
            {
                x.Add(x.Last() + V.Last() * delta_t);
                double V_temp = V.Last() + (-w0 * w0) * delta_t * x.Last();
                V.Add(V_temp + (delta_t * (-0.5) * V_temp));
                E_kin.Add(m * Pow(V.Last(), 2) / 2);
                E_pot.Add(k * Pow(x.Last(), 2) / 2);
                E.Add(E_pot.Last() + E_kin.Last());
                t.Add(t.Last() + delta_t);
                t_current = t.Last();
            }
        }
    }
}

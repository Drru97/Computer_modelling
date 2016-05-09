using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Circuit
    {
        List<double> t = new List<double> { 0 };
        List<double> U = new List<double> { 0 };
        List<double> I;
        double E, R, C, delta_t;

        public List<double> T
        {
            get { return t; }
        }

        public List<double> u
        {
            get { return U; }
        }

        public List<double> i
        {
            get { return I; }
        }

        public Circuit(double E, double R, double C, double delta_t = 0)
        {
            if (delta_t == 0)
                this.delta_t = R * C * 0.55;
            else
                this.delta_t = delta_t;
            this.E = E;
            this.R = R;
            this.C = C;
            I = new List<double> { this.E / this.R };
        }

        public void Euler_Yavnuy()
        {
            int i = 0;
            while (i < 10)
            {
                ++i;
                U.Add(U.Last() + ((E - U.Last()) / (R * C)) * delta_t);
                I.Add((E - U.Last()) / R);
                t.Add(t.Last() + delta_t);
            }
        }

        public void Euler_Neyavnuy()
        {
            int i = 0;
            while (i < 10)
            {
                ++i;
                U.Add((U.Last() + E * delta_t / (R * C)) / (1 + delta_t / (R * C)));
                I.Add((E - U.Last()) / R);
                t.Add(t.Last() + delta_t);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Lab3
{
    public static class FreeFalling
    {
        static double k = 0.2; // коефіцієнт опору повітря

        public static Tuple<List<double>, List<double>, double> Euler(double h, double delta_t)
        {
            double v = 0, t = 0, min = 0, a = 9.8;
            int i = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double> { h };
            while (min >= 0)
            {
                ++i;
                t = i * delta_t;
                x.Add(t);
                y.Add(y[i - 1] - delta_t * v);
                v += delta_t * a;
                min = y.Last();
            }
            return Tuple.Create(x, y, t);
        }

        public static Tuple<List<double>, List<double>, double> Euler_Kromer(double h, double delta_t)
        {
            double v = 0, t = 0, a = 9.8;
            int i = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double> { h };
            while (y.Min() >= 0)
            {
                ++i;
                t = i * delta_t;
                v += delta_t * a;
                x.Add(t);
                y.Add(y[i - 1] - delta_t * v);
            }
            return Tuple.Create(x, y, t);
        }

        public static Tuple<List<double>, List<double>, double, double> Euler_Air(double h, double m, double delta_t)
        {
            double t = 0, v = 0, g = 9.8;
            int i = 0, linear = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double> { h };
            while (y.Min() >= 0)
            {
                double a = (m * g - k * v) / m;
                if (Round(a, 5) == 0 && linear != 0 && i != 0)
                    linear = i;
                ++i;
                t = i * delta_t;
                x.Add(t);
                y.Add(y[i - 1] - delta_t * v);
                v += delta_t * a;
            }
            return Tuple.Create(x, y, t, v);
        }

        public static Tuple<List<double>, List<double>, double, double> Euler_Kromer_Air(double h, double m, double delta_t)
        {
            double t = 0, v = 0, g = 9.8;
            int i = 0, linear = 0;
            List<double> x = new List<double>();
            List<double> y = new List<double> { h };
            while (y.Min() >= 0)
            {
                double a = (m * g - k * v) / m;
                if (Round(a, 5) == 0 && linear != 0 && i != 0)
                    linear = i;
                ++i;
                t = i * delta_t;
                v += delta_t * a;
                x.Add(t);
                y.Add(y[i - 1] - delta_t * v);
            }
            return Tuple.Create(x, y, t, v);
        }

        public static Tuple<List<double>, List<double>, List<double>, List<double>, List<double>, List<double>> Angle_Throw(double v0, double m, double angle, double delta_t)
        {
            double g = 9.8, t = 0, min = 0.00001;
            int i = 0;
            List<double> x = new List<double> { 0 };
            List<double> y = new List<double> { min };
            List<double> Vx = new List<double> { v0 * Cos(angle) };
            List<double> Vy = new List<double> { v0 * Sin(angle) };
            List<double> V = new List<double> { v0 };
            List<double> T = new List<double> { 0 };
            while (min > 0)
            {
                ++i;
                t = i * delta_t;
                double ax = (-k / m) * V.Last() * Vx.Last();
                double ay = (-k / m) * V.Last() * Vy.Last() - g;
                Vx.Add(Round(Vx.Last() + delta_t * ax, 3));
                Vy.Add(Round(Vy.Last() + delta_t * ay, 3));
                V.Add(Sqrt(Pow(Vx.Last(), 2) + Pow(Vy.Last(), 2)));
                x.Add(x.Last() + Vx.Last());
                y.Add(y.Last() + Vy.Last());
                T.Add(t);
                min = y.Last();
            }
            return Tuple.Create(x, y, Vx, Vy, V, T);
        }

        public static Tuple<List<double>, List<double>> Angle_stable_k(double v0, double m, double delta_t)
        {
            double g = 9.8;
            List<double> length = new List<double>();
            List<double> angles = new List<double>();
            for (int angle_i = 0; angle_i < 91; angle_i++)
            {
                angles.Add(angle_i);
                double angle = (angle_i * PI) / 180; // convert degrees into radians 
                int i = 0;
                double x = 0, y = 0.01;
                double Vx = v0 * Cos(angle);
                double Vy = v0 * Sin(angle);
                double V = v0;
                while (y > 0)
                {
                    ++i;
                    double ax = (-k / m) * V * Vx;
                    double ay = (-k / m) * V * Vy - g;
                    Vx += delta_t * ax;
                    Vy += delta_t * ay;
                    V = Sqrt(Pow(Vx, 2) + Pow(Vy, 2));
                    x += Vx;
                    y += Vy;
                }
                length.Add(x);
            }
            return Tuple.Create(angles, length);
        }

        public static Tuple<List<double>, List<double>> Angle_Stable_Angle(double v0, double m, double angle, double delta_t)
        {
            double g = 9.8;
            List<double> length = new List<double>();
            List<double> koefs = new List<double>();
            for (int j = 0; j < 200; j++)
            {
                double k = (double)j / 100;
                koefs.Add(k);
                int i = 0;
                double x = 0, y = 0.001;
                double Vx = v0 * Cos(angle);
                double Vy = v0 * Sin(angle);
                double V = v0;
                while (y > 0)
                {
                    ++i;
                    double ax = (-k / m) * V * Vx;
                    double ay = (-k / m) * V * Vy - g;
                    Vx += delta_t * ax;
                    Vy += delta_t * ay;
                    V = Sqrt(Pow(Vx, 2) + Pow(Vy, 2));
                    x += Vx;
                    y += Vy;
                }
                length.Add(x);
            }
            return Tuple.Create(koefs, length);
        }
    }
}

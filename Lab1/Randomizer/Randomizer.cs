using System;

namespace Randomizer
{
    public class Randomizer
    {
        double a, m;  // coeficients for GGL method
        double seed;  // this is seed
        double output;  // generated random number

        public Randomizer(double a, double m)
        {
            this.a = a;
            this.m = m;
            seed = GetSeed();
        }

        private double GetSeed()
        {
            return DateTime.Now.Ticks;
        }

        public double Randomize(int decimals)
        {
            if (decimals >= 0 && decimals < 15)
            {
                double x1;
                x1 = (a * seed) % m;
                output = Math.Round(x1 / (m - 1), decimals);
                seed = x1;
            }
            return output;
        }
    }

    public static class MathValues
    {
        public static double MSP(double[] array)
        {
            double M = 0;
            for (int i = 0; i < array.Length; i++)
                M += array[i];
            return M / array.Length;
        }

        public static double DSP(double[] array)
        {
            double D = 0;
            double msp = MSP(array);
            for (int i = 0; i < array.Length; i++)
                D += Math.Pow(array[i] - msp, 2);
            return D / array.Length;
        }

        public static double AVG(double[] array)
        {
            double A = 0;
            for (int i = 0; i < array.Length; i++)
                A += array[i];
            return A / array.Length;
        }

        public static int[] Frequency(double[] array, int numberOfIntervals, out double[] intervals)
        {
            int[] v = new int[numberOfIntervals + 1];
            double[] interval = new double[numberOfIntervals + 1];
            double step = 4.0 / numberOfIntervals;
            interval[0] = 0.0;
            for (int i = 0; i < numberOfIntervals; i++)
                interval[i + 1] = Math.Round(interval[i] + step, 3);
            intervals = interval;
            for (int i = 0; i < array.Length; i++)
                for (int k = 0; k < numberOfIntervals; k++)
                    if (array[i] >= interval[k] && array[i] < interval[k + 1])
                        v[k]++;
            return v;
        }
    }
}

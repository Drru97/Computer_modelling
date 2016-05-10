using System;
using System.Windows.Forms;

namespace Lab1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a = 16807, m = 2147483647, seed = DateTime.Now.Ticks;
            int L = 10;
            Console.WriteLine("Input n:");
            int n = int.Parse(Console.ReadLine());
            GGL Rand = new GGL(a, m, n);
            Rand.Randomize(seed);
            Console.WriteLine("Random numbers in range from 0 to 1:");
            //for (int i = 0; i < n; i++)
            //    Console.WriteLine(Rand.GetRandomNumbers()[i]);
            Console.WriteLine("Математичне сподiвання = {0} \nДисперсiя = {1}  \nСереднє = {2}", Rand.GetMSP(), Rand.GetDSP(), Rand.GetAVG());
            Console.WriteLine("Interval \t Number \t Frequency");
            double[] k = new double[n];
            for (int i = 0; i < L; i++)
                Console.WriteLine((double)i / L + "\t\t" + Rand.GetV()[i] + "\t\t" + Rand.GetV()[i] / n);
            chart2.Series["Series1"].Points.AddY(0.5);
            for (int i = 0; i < L; i++)
                chart1.Series["Series1"].Points.AddXY((double)i / L, Rand.GetV()[i]);
            for (int i = 1; i < n; i++)
                chart2.Series["Series1"].Points.AddXY(Math.Log10(i), Rand.MATH()[i]);
            Rand.Table();
            Console.WriteLine("Математичне сподiвання = {0}", Rand.Table_MSP(Rand.array));
            Console.WriteLine("Дисперсiя = {0}", Rand.Table_DSP(Rand.array, Rand.Table_MSP(Rand.array)));
            Console.WriteLine("Interval \t Number \t Frequency");

            for (int i = 0; i < Rand.Xi.Length; i++)
                Console.WriteLine("[" + Rand.length[i] + ", " + Rand.length[i + 1] + "]" + "\t\t" + Rand.Table_FR(Rand.array)[i] + "\t\t" + Rand.Table_FR(Rand.array)[i] / n);
            //for (int i = 0; i < Rand.length.Length; i++)
            //    Console.WriteLine(Rand.array[i]);

        }
    }
    public class GGL
    {
        double a, m;
        int n;
        double[] output;
        double[] freq;
        double[] v;
        double msp, dsp, avg;

        public double[] Xi = new double[] { 2, 3, 5, 12, 21, 33, 44 };
        double[] Pi = new double[] { 0.1, 0.15, 0.2, 0.05, 0.02, 0.33, 0.15 };
        public double[] length;
        public double[] array;

        public GGL(double a, double m, int n)
        {
            this.a = a;
            this.m = m;
            this.n = n;
        }

        private double GetSeed()
        {
            return DateTime.Now.Ticks;
        }

        public void Randomize(double seed)
        {
            output = new double[n];
            double x1;
            for (int i = 0; i < n; i++)
            {
                x1 = (a * seed) % m;
                output[i] = Math.Round(x1 / (m - 1), 10);
                seed = x1;
            }
            MSP();
            DSP();
            AVG();
            FR();
        }

        private void MSP()
        {
            double M = 0;
            for (int i = 0; i < n; i++)
                M = M + output[i];
            msp = M / n;
        }
        public double Table_MSP(double[] array)
        {
            double M = 0;
            for (int i = 0; i < n; i++)
                M = M + array[i];
            msp = M / n;
            return msp;
        }

        public double[] MATH()
        {
            int step = 1;
            double[] mathsp = new double[n / step];
            double M = 0;
            for (int k = 0; k < n / step; k++)
            {
                for (int i = 0; i < step * (k + 1); i++)
                {
                    M = M + output[i];
                }
                mathsp[k] = M / (step * (k + 1));
                M = 0;
            }
            return mathsp;
        }

        private void DSP()
        {
            double D = 0;
            for (int i = 0; i < n; i++)
                D = D + Math.Pow(output[i] - msp, 2);
            dsp = D / n;
        }

        public double Table_DSP(double[] array, double msp)
        {
            double D = 0;
            for (int i = 0; i < n; i++)
                D = D + Math.Pow(array[i] - msp, 2);
            dsp = D / n;
            return dsp;
        }

        private void AVG()
        {
            double A = 0;
            for (int i = 0; i < n; i++)
                A = A + output[i];
            avg = A / n;
        }

        public void FR()
        {
            freq = new double[n];
            v = new double[10];
            for (int i = 0; i < n; i++)
            {
                if (output[i] < 0.1)
                    v[0]++;
                if (output[i] < 0.2 && output[i] > 0.1)
                    v[1]++;
                if (output[i] < 0.3 && output[i] > 0.2)
                    v[2]++;
                if (output[i] < 0.4 && output[i] > 0.3)
                    v[3]++;
                if (output[i] < 0.5 && output[i] > 0.4)
                    v[4]++;
                if (output[i] < 0.6 && output[i] > 0.5)
                    v[5]++;
                if (output[i] < 0.7 && output[i] > 0.6)
                    v[6]++;
                if (output[i] < 0.8 && output[i] > 0.7)
                    v[7]++;
                if (output[i] < 0.9 && output[i] > 0.8)
                    v[8]++;
                if (output[i] < 1.0 && output[i] > 0.9)
                    v[9]++;
            }
        }

        public double[] Table_FR(double[] array)
        {
            double[] freq = new double[n];
            double[] v = new double[Xi.Length];
            for (int i = 0; i < n; i++)
            {
                if (array[i] == Xi[0])
                    v[0]++;
                if (array[i] == Xi[1])
                    v[1]++;
                if (array[i] == Xi[2])
                    v[2]++;
                if (array[i] == Xi[3])
                    v[3]++;
                if (array[i] == Xi[4])
                    v[4]++;
                if (array[i] == Xi[5])
                    v[5]++;
                if (array[i] == Xi[6])
                    v[6]++;
            }
            return v;
        }
        // для дискретної функції
        public void Table()
        {
            length = new double[Xi.Length + 1];
            double sum = 0;
            for (int i = 0; i < Xi.Length; i++)
            {
                length[i] = sum;
                sum = sum + Pi[i];
            }
            length[Xi.Length] = 1;
            //for (int i = 0; i < length.Length; i++)
            //    Console.WriteLine(length[i]);

            array = new double[n];
            for (int k = 0; k < n; k++)
                for (int i = 0; i < Xi.Length; i++)
                    if (output[k] > length[i] && output[k] < length[i + 1])
                    {
                        array[k] = Xi[i];
                       // Console.WriteLine("{0} in range from {1} to {2}, Xi = {3}", output[k], length[i], length[i + 1], array[k]);
                    }
            //for (int i = 0; i < n; i++)
            //    Console.WriteLine(array[i]);
        }

        public double[] GetRandomNumbers()
        {
            return output;
        }

        public double GetMSP()
        {
            return msp;
        }

        public double GetDSP()
        {
            return dsp;
        }

        public double GetAVG()
        {
            return avg;
        }

        public double[] GetFreq()
        {
            return freq;
        }

        public double[] GetV()
        {
            return v;
        }
    }
}

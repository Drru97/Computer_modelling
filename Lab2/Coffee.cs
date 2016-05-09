using System;
using System.Collections.Generic;

namespace Lab2
{
    class Coffee
    {
        double r = -0.13;
        double timeStep = 1;
        double T0, Ts;
        double maxTime = 60;
        List<double> Temp = new List<double> { };
        List<double> Times = new List<double> { };
        List<double> expTemp = new List<double> { };
        List<double> accuracy = new List<double> { };

        public Coffee(double T0, double Ts)
        {
            this.T0 = T0;
            this.Ts = Ts;
            Analytics();
            Experimental();
            Accuracy();
        }

        public double MaxTime
        {
            get { return maxTime; }
            set { maxTime = value; }
        }

        public List<double> Temperature
        {
            get { return Temp; }
        }

        public List<double> ExperimantalTemperature
        {
            get { return expTemp; }
        }

        public List<double> Time
        {
            get { return Times; }
        }

        public List<double> Accur
        {
            get { return accuracy; }
        }

        void Analytics()
        {
            double T = T0;
            double time = 0;
            while (time < maxTime)
            {
                time += timeStep;
                T = T + timeStep * (r * (T - Ts));
                Temp.Add(T);
                Times.Add(time);
            }
        }

        void Experimental()
        {
            double T = 0;
            double time = 0;
            while (time < maxTime)
            {
                time += timeStep;
                T = Ts + Math.Exp(r * time) * (T0 - Ts);
                expTemp.Add(T);
            }
        }

        void Accuracy()
        {
            double accuracy = 0;
            double time = 0;
            for (int i = 0; i < maxTime; i += (int)timeStep)
            {
                time += timeStep;
                accuracy = Math.Pow(Temp[i] - expTemp[i], 2);
                this.accuracy.Add(accuracy);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class Sample
    {
        public double Mean { get; private set; }
        public double Dispersion { get; private set; }
        public double ExactleDispersion { get; private set; }

        private double[,] distributionLaw;
        private double N;

        public Sample(double[,] distributionLaw)
        {
            this.distributionLaw = distributionLaw;
            GetMean();
            GetDispesion();
            GetExactleDispersion();
        }

        private void GetMean()
        {
            double sum = 0;
            N = 0;
            for (int i = 0; i < distributionLaw.GetLength(1); i++)
            {
                double x = distributionLaw[0, i];
                double n = distributionLaw[1, i];
                sum += x * n;
                N += n;
            }
            Mean = (1 / N) * sum;
        }

        private void GetDispesion()
        {
            double sum = 0;
            for (int i = 0; i < distributionLaw.GetLength(1); i++)
            {
                double x = distributionLaw[0, i];
                double n = distributionLaw[1, i];
                sum += n * Math.Pow(x - Mean, 2);
            }
            Dispersion = (1 / N) * sum;
        }

        private void GetExactleDispersion()
        {
            double BesselAmendment = N / (N - 1);
            ExactleDispersion = BesselAmendment * Dispersion;
        }
    }
}

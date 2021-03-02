using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class RandomValue
    {
        public double ExpectedValue { get; private set; }
        public double Dispersion { get; private set; }

        private double[,] distributionLaw;

        public RandomValue(double[,] distributionLaw)
        {
            this.distributionLaw = distributionLaw;
            GetExpectedValue(); 
            GetDispersion();
        }
        private void GetExpectedValue()
        {
            double sum = 0;
            for (int i = 0; i < distributionLaw.GetLength(1); i++)
            {
                double x = distributionLaw[0, i];
                double p = distributionLaw[1, i];
                sum += x * p;
            }
            ExpectedValue = sum;
        }
        private void GetDispersion()
        {
            double sum = 0;
            for (int i = 0; i < distributionLaw.GetLength(1); i++)
            {
                double x = distributionLaw[0, i];
                double p = distributionLaw[1, i];
                sum += x * x * p;
            }
            Dispersion = sum - (ExpectedValue * ExpectedValue);
        }
    }
}

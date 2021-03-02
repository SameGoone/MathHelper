using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class Combinatorics
    {
        public double P { get; private set; }
        public double C { get; private set; }
        public double A { get; private set; }

        private double n;
        private double m;
        
        public Combinatorics(double n)
        {
            this.n = n;
            GetP();
        }
        public Combinatorics(double n, double m)
        {
            this.n = n;
            this.m = m;
            GetC();
            GetA();
        }

        public double Factorial(double x)
        {
            double factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private void GetP()
        {
            P = Factorial(n);
        }

        private void GetC()
        {
            C = Factorial(n) / (Factorial(m) * Factorial(n - m));
        }

        private void GetA()
        {
            A = Factorial(n) / Factorial(n - m);
        }
    }
}

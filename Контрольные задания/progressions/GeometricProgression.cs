using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class GeometricProgression : IProgression
    {
        private double a;
        private double q;

        public GeometricProgression(double a, double q)
        {
            this.a = a;
            this.q = q;
        }

        public double SumElement(int k) => (a * (Math.Pow(q, k - 1) - 1)) / (q - 1);

        public double GetElement(int k) => a * Math.Pow(q, k - 1);
    }
}

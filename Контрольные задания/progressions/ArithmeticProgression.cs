using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    class ArithmeticProgression : IProgression
    {
        private double a;
        private double d;

        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

        public double SumElement(int k) => ((2 * a) + d * (k - 1) / 2) * k;

        public double GetElement(int k) => a + d * (k - 1);
    }
}

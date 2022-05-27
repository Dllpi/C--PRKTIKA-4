using System;
using System.Collections.Generic;
using System.Text;

namespace progressions
{
    interface IProgression
    {
        double SumElement(int k);

        double GetElement(int k);
    }
}

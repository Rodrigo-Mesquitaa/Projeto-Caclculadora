using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Subtracao : ICalculo
    {
        public double Calcular(double a, double b) => a - b;
    }
}

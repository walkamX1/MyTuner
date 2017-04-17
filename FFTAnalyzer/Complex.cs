using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTAnalyzer
{
    class Complex
    {
        public double im;
        public double re;

        public Complex(double _re)
        {
            im = 0;
            re = _re;
        }

        public Complex(double _re, double _im)
        {
            re = _re;
            im = _im;
        }

        public override string ToString()
        {
            if (im == 0)
            {
                return re.ToString();
            }
            return re + (im > 0 ? "+" : "") + im;
        }
    }
}

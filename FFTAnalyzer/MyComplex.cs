using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTAnalyzer
{
    public class MyComplex
    {
        public double im;
        public double re;

        public MyComplex(double _re)
        {
            im = 0;
            re = _re;
        }

        public MyComplex(double _re, double _im)
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
            return re.ToString() + (im > 0 ? "+" : "") + im.ToString() + "i";
        }
    }
}

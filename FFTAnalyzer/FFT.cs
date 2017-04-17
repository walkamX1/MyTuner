using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTAnalyzer
{
    public class FFT
    {
        public static double[] calculateSpectr(double[] data)
        {
            return null;
        }

        private static int reverseBits(int x, int lg_n)
        {
            int ret = 0;
            for (int i=0; i< lg_n; i++)
            {
                if ((x & (1<<i)) != 0)
                {
                    ret |= 1 << (lg_n - 1 + i);
                }
            }
            return ret;
        }
    }
}

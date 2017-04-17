using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using FFTAnalyzer;

namespace MyTuner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = (new Complex(3, 0)).ToString();
            label2.Text = (new Complex(4.3344d, 0)).ToString();
            label3.Text = (new Complex(2.33d, 1.411d)).ToString();
            label4.Text = (new Complex(2.33d, -1.411d)).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 500;
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           // timer1.Interval = 100;            
            i++;
            timer1.Start();
            timer1.Enabled = true;
            textBox1.Text = i.ToString(); ;
        }

        private void Start(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
        }

        private void Stop(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Clear();
            i = 0;
        }
    }
}

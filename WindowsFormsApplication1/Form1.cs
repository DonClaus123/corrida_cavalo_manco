using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mtGradiantButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Left = 1220;
            groupBox2.Left = 1220;
            groupBox3.Left = 1220;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ap1 = new Random();
            groupBox1.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));
            groupBox2.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));
            groupBox3.Left -= (ap1.Next(0, 51) - ap1.Next(0, 11));

            if (groupBox1.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                MessageBox.Show("BEYBLADE WINS");
                
            }
            else if (groupBox2.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                MessageBox.Show("MINOTAURO WINS");
            }
            else if (groupBox3.Bounds.IntersectsWith(label1.Bounds))
            {
                timer1.Enabled = false;
                MessageBox.Show("DANÇANTE WINS");
            }
        }
    }
}

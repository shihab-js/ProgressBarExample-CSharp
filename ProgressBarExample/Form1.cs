using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Set a maximum value
            progressBar1.Maximum = 10000;

            //set a minimum value
            progressBar1.Minimum = 0;

            //set step value
            progressBar1.Step = 1;

            //set the style of the progress bar
            progressBar1.Style = ProgressBarStyle.Continuous;

            //create a loop to incrase the value
            for(int i=0; i<progressBar1.Maximum; i++)
            {
                //set the new value of progress bar
                progressBar1.Value = i;
            }
        }
    }
}

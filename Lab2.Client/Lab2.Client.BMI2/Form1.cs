using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Client.BMI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBMI_Click(object sender, EventArgs e)
        {
            var weight = int.Parse(textBoxWeight.Text);
            var length = double.Parse(textBoxLength.Text);
            BMIClient bmi = new BMIClient();
            labelBMI.Text = bmi.CalculateBMI(weight, length);
        }
    }
}

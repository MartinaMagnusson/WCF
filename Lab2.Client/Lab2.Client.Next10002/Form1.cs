using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Client.Next10002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBirthday_Click(object sender, EventArgs e)
        {
            Next1000DaysClient next = new Next1000DaysClient();
            var birthday = DateTime.Parse(textBoxBirthday.Text);
            labelNext1000.Text = next.CalculateNext1000Days(birthday);
        }
    }
}

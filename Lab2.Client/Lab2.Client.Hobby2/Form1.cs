using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Client.Hobby2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShoes_Click(object sender, EventArgs e)
        {
            var shoesName = textBoxShoes.Text;
            var size = int.Parse(textBoxSize.Text);
            var gender = radioButtonWoman.Text;
            if (radioButtonMan.Checked)
                gender = radioButtonMan.Text;
            HobbyClient hobby = new HobbyClient();
            labelAnswer.Text = hobby.Shoes(gender, shoesName, size);
        }
    }
}

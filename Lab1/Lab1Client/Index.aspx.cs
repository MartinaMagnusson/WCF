using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1Client
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonWeather_Click(object sender, EventArgs e)
        {
            Weather.Lab1WebServiceSoapClient weather = new Weather.Lab1WebServiceSoapClient();
            LabelWeather.Text = weather.Weather();
        }

        protected void ButtonAddTwoNumbers_Click(object sender, EventArgs e)
        {
            AddTwoNumbers.AddsTwoNumbersSoapClient add = new AddTwoNumbers.AddsTwoNumbersSoapClient();
            var numberOne = int.Parse(TextBoxNumberOne.Text);
            var numberTwo = int.Parse(TextBoxNumberTwo.Text);
            LabelAddTwoNumbers.Text = add.AddNumbers(numberOne, numberTwo).ToString();
        }

        protected void ButtonAddThreeNumbers_Click(object sender, EventArgs e)
        {
            AddThreeNumbers.AddThreeNumbersSoapClient add = new AddThreeNumbers.AddThreeNumbersSoapClient();
            var numberOne = int.Parse(TextBoxAddNumberOne.Text);
            var numberTwo = int.Parse(TextBoxAddNumberTwo.Text);
            var numberThree = int.Parse(TextBoxAddNumberThree.Text);
            LabelAddThreeNumbers.Text = add.AddNumbers(numberOne, numberTwo, numberThree);
        }
    }
}